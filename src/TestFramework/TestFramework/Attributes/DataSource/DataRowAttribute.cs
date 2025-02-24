// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Attribute to define in-line data for a test method.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class DataRowAttribute : Attribute, ITestDataSource
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataRowAttribute"/> class.
    /// </summary>
    public DataRowAttribute()
        : this(Array.Empty<object>())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataRowAttribute"/> class.
    /// </summary>
    /// <param name="stringArrayData"> The string array data. </param>
    public DataRowAttribute(string?[]? stringArrayData)
        : this(new object?[] { stringArrayData })
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataRowAttribute"/> class which takes in an array of arguments.
    /// </summary>
    /// <param name="data"> The data. </param>
    public DataRowAttribute(params object?[]? data)
    {
        if (data == null)
        {
            Data = new object?[] { null };
        }
        else
        {
            Data = data;
        }
    }

    /// <summary>
    /// Gets data for calling test method.
    /// </summary>
    public object?[] Data { get; }

    /// <summary>
    /// Gets or sets display name in test results for customization.
    /// </summary>
    public string? DisplayName { get; set; }

    /// <inheritdoc />
    public IEnumerable<object?[]> GetData(MethodInfo methodInfo)
    {
        return new[] { Data };
    }

    /// <inheritdoc />
    public virtual string? GetDisplayName(MethodInfo methodInfo, object?[]? data)
    {
        if (!string.IsNullOrWhiteSpace(DisplayName))
        {
            return DisplayName;
        }

        if (data == null)
        {
            return null;
        }

        var parameters = methodInfo.GetParameters();

        // We want to force call to `data.AsEnumerable()` to ensure that objects are casted to strings (using ToString())
        // so that null do appear as "null". If you remove the call, and do string.Join(",", new object[] { null, "a" }),
        // you will get empty string while with the call you will get "null,a".
        IEnumerable<object?> displayData = parameters.Length == 1 && parameters[0].ParameterType == typeof(object[])
            ? new object[] { data.AsEnumerable() }
            : data.AsEnumerable();

        return string.Format(CultureInfo.CurrentCulture, FrameworkMessages.DataDrivenResultDisplayName, methodInfo.Name,
            string.Join(",", displayData));
    }
}
