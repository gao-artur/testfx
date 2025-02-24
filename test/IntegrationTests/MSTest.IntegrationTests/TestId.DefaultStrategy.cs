﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;

using FluentAssertions;

using Microsoft.MSTestV2.CLIAutomation;

namespace MSTest.IntegrationTests;
public partial class TestId : CLITestBase
{
    private const string DefaultStrategyDll = "TestIdProject.DefaultStrategy";

    public void TestIdUniqueness_DataRowArray_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DataRowArraysTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "DataRowArraysTests (0,System.Int32[])",
            "DataRowArraysTests (0,System.Int32[])",
            "DataRowArraysTests (0,System.Int32[])");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_DataRowString_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DataRowStringTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "DataRowStringTests ()",
            "DataRowStringTests ()",
            "DataRowStringTests ( )",
            "DataRowStringTests (  )");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_DynamicDataArrays_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DynamicDataArraysTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "DynamicDataArraysTests (0,System.Int32[])",
            "DynamicDataArraysTests (0,System.Int32[])",
            "DynamicDataArraysTests (0,System.Int32[])");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_DynamicDataTuple_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DynamicDataTuplesTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "DynamicDataTuplesTests ((1, text, True))",
            "DynamicDataTuplesTests ((1, text, False))");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_DynamicDataGenericCollections_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DynamicDataGenericCollectionsTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])",
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])",
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])",
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_TestDataSourceArrays_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~TestDataSourceArraysTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "Custom name",
            "Custom name",
            "Custom name");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_TestDataSourceTuples_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~TestDataSourceTuplesTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "Custom name",
            "Custom name");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }

    public void TestIdUniqueness_TestDataSourceGenericCollections_DefaultStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(DefaultStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~TestDataSourceGenericCollectionsTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            "Custom name",
            "Custom name",
            "Custom name",
            "Custom name");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Should().OnlyHaveUniqueItems();
    }
}
