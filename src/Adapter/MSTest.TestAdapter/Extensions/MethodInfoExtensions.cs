// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.Helpers;
using Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.Extensions;
internal static class MethodInfoExtensions
{
    /// <summary>
    /// Verifies that the class initialize has the correct signature.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <returns>True if the method has the right Assembly/Class initialize signature.</returns>
    internal static bool HasCorrectClassOrAssemblyInitializeSignature(this MethodInfo method)
    {
        DebugEx.Assert(method != null, "method should not be null.");

        ParameterInfo[] parameters = method.GetParameters();

        return
            method.IsStatic &&
            method.IsPublic &&
            (parameters.Length == 1) &&
            parameters[0].ParameterType == typeof(TestContext) &&
            method.IsVoidOrTaskReturnType();
    }

    /// <summary>
    /// Verifies that the class cleanup has the correct signature.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <returns>True if the method has the right Assembly/Class cleanup signature.</returns>
    internal static bool HasCorrectClassOrAssemblyCleanupSignature(this MethodInfo method)
    {
        DebugEx.Assert(method != null, "method should not be null.");

        return
            method.IsStatic &&
            method.IsPublic &&
            (method.GetParameters().Length == 0) &&
            method.IsVoidOrTaskReturnType();
    }

    /// <summary>
    /// Verifies that the test Initialize/cleanup has the correct signature.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <returns>True if the method has the right test init/cleanup signature.</returns>
    internal static bool HasCorrectTestInitializeOrCleanupSignature(this MethodInfo method)
    {
        DebugEx.Assert(method != null, "method should not be null.");

        return
            !method.IsStatic &&
            method.IsPublic &&
            (method.GetParameters().Length == 0) &&
            method.IsVoidOrTaskReturnType();
    }

    /// <summary>
    /// Verifies that the test method has the correct signature.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <param name="ignoreParameterLength">Indicates whether parameter length is to be ignored.</param>
    /// <param name="discoverInternals">True if internal test classes and test methods should be discovered in
    /// addition to public test classes and methods.</param>
    /// <returns>True if the method has the right test method signature.</returns>
    internal static bool HasCorrectTestMethodSignature(this MethodInfo method, bool ignoreParameterLength, bool discoverInternals = false)
    {
        DebugEx.Assert(method != null, "method should not be null.");

        return
            !method.IsAbstract &&
            !method.IsStatic &&
            !method.IsGenericMethod &&
            (method.IsPublic || (discoverInternals && method.IsAssembly)) &&
            (method.GetParameters().Length == 0 || ignoreParameterLength) &&
            method.IsVoidOrTaskReturnType(); // Match return type Task for async methods only. Else return type void.
    }

    /// <summary>
    /// Checks whether test method has correct Timeout attribute.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <returns>True if the method has the right test timeout signature.</returns>
    internal static bool HasCorrectTimeout(this MethodInfo method)
    {
        DebugEx.Assert(method != null, "method should not be null.");

        // There should be one and only one TimeoutAttribute.
        var attributes = ReflectHelper.GetCustomAttributes<TimeoutAttribute>(method, false);
        if (attributes?.Length != 1)
        {
            return false;
        }

        // Timeout cannot be less than 0.
        return !(attributes[0]?.Timeout < 0);
    }

    /// <summary>
    /// Check is return type is void for non async and Task for async methods.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <returns>True if the method has a void/task return type..</returns>
    internal static bool IsVoidOrTaskReturnType(this MethodInfo method)
    {
        return ReflectHelper.MatchReturnType(method, typeof(Task))
            || (ReflectHelper.MatchReturnType(method, typeof(void)) && method.GetAsyncTypeName() == null);
    }

    /// <summary>
    /// For async methods compiler generates different type and method.
    /// Gets the compiler generated type name for given async test method.
    /// </summary>
    /// <param name="method">The method to verify.</param>
    /// <returns>Compiler generated type name for given async test method..</returns>
    internal static string? GetAsyncTypeName(this MethodInfo method)
    {
        var asyncStateMachineAttribute = ReflectHelper.GetCustomAttributes<AsyncStateMachineAttribute>(method, false).FirstOrDefault();

        return asyncStateMachineAttribute?.StateMachineType?.FullName;
    }

    /// <summary>
    /// Invoke a <see cref="MethodInfo"/> as a synchronous <see cref="Task"/>.
    /// </summary>
    /// <param name="methodInfo">
    /// <see cref="MethodInfo"/> instance.
    /// </param>
    /// <param name="classInstance">
    /// Instance of the on which methodInfo is invoked.
    /// </param>
    /// <param name="parameters">
    /// Arguments for the methodInfo invoke.
    /// </param>
    internal static void InvokeAsSynchronousTask(this MethodInfo methodInfo, object? classInstance, params object?[]? parameters)
    {
        var methodParameters = methodInfo.GetParameters();

        // check if test method expected parameter values but no test data was provided,
        // throw error with appropriate message.
        if (methodParameters != null && methodParameters.Length > 0 && parameters == null)
        {
            throw new TestFailedException(ObjectModel.UnitTestOutcome.Error, Resource.UTA_TestMethodExpectedParameters);
        }

        Task? task;
        if (parameters is not null
            && methodParameters?.Length == 1
            && methodParameters[0].ParameterType == typeof(object[]))
        {
            task = methodInfo.Invoke(classInstance, new[] { parameters }) as Task;
        }
        else
        {
            task = methodInfo.Invoke(classInstance, parameters) as Task;
        }

        // If methodInfo is an Async method, wait for returned task
        task?.GetAwaiter().GetResult();
    }
}
