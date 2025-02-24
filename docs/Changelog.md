# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)

## [3.0.4] - 2023-06-01

See full log [here](https://github.com/microsoft/testfx/compare/v3.0.3...v3.0.4)

### Fixed

* Fix out of range exception in deployment tool [#1682](https://github.com/microsoft/testfx/pull/1682)
* Fix issue/crash with deployment items and disabled app domains [#1681](https://github.com/microsoft/testfx/pull/1681)

### Artifacts

* MSTest: [3.0.4](https://www.nuget.org/packages/MSTest/3.0.4)
* MSTest.TestFramework: [3.0.4](https://www.nuget.org/packages/MSTest.TestFramework/3.0.4)
* MSTest.TestAdapter: [3.0.4](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.4)

## [3.0.3] - 2023-05-24

See full log [here](https://github.com/Microsoft/testfx/compare/v3.0.2...v3.0.3)

### Fixed

* Revert change for timeout test execution [#1675](https://github.com/Microsoft/testfx/pull/1675)
* Fix assembly resolution error [#1670](https://github.com/Microsoft/testfx/pull/1670)
* Revert usage of System.Collections.Immutable for TypeCache
* Remove DataRowAttribute argument count limitation [#1646](https://github.com/Microsoft/testfx/pull/1646)
* Use Test Platform 17.4.1 instead of 17.4.0

### Artifacts

* MSTest: [3.0.3](https://www.nuget.org/packages/MSTest/3.0.3)
* MSTest.TestFramework: [3.0.3](https://www.nuget.org/packages/MSTest.TestFramework/3.0.3)
* MSTest.TestAdapter: [3.0.3](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.3)

## [3.0.2] - 2022-12-27

See full log [here](https://github.com/microsoft/testfx/compare/v3.0.1...v3.0.2)

### Fixed

* Fix issue cannot load Microsoft.TestPlatform.CoreUtilities [#1502](https://github.com/microsoft/testfx/pull/1502)

### Artifacts

* MSTest: [3.0.2](https://www.nuget.org/packages/MSTest/3.0.2)
* MSTest.TestFramework: [3.0.2](https://www.nuget.org/packages/MSTest.TestFramework/3.0.2)
* MSTest.TestAdapter: [3.0.2](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.2)

## [3.0.1] - 2022-12-20

See full log [here](https://github.com/microsoft/testfx/compare/v3.0.0...v3.0.1)

### Fixed

* Fix cleanup inheritance calls [#1475](https://github.com/microsoft/testfx/pull/1475)
* Fix some race condition issue [#1477](https://github.com/microsoft/testfx/pull/1477)
* Fix class/assembly cleanups log collect and attachment [#1470](https://github.com/microsoft/testfx/pull/1470)
* Allow most APIs to accept nullable values or arguments [#1467](https://github.com/microsoft/testfx/pull/1467)
* Add console, trace and debug writeline calls to the lifecycle integration tests [#1464](https://github.com/microsoft/testfx/pull/1464)
* Revert Framework.Extension project to be CLSCompliant [#1450](https://github.com/microsoft/testfx/pull/1450)
* Fix regressions with DataRow supported arguments [#1446](https://github.com/microsoft/testfx/pull/1446)
* Add parent domain assembly resolver for netfx [#1443](https://github.com/microsoft/testfx/pull/1443)
* Remove unneeded dash in InformationalVersion for RTM builds
* Add NotNullAttribute postcondition to Assert APIs [#1441](https://github.com/microsoft/testfx/pull/1441)

### Artifacts

* MSTest: [3.0.1](https://www.nuget.org/packages/MSTest/3.0.1)
* MSTest.TestFramework: [3.0.1](https://www.nuget.org/packages/MSTest.TestFramework/3.0.1)
* MSTest.TestAdapter: [3.0.1](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.1)

## [3.0.0] - 2022-12-06

See full log [here](https://github.com/microsoft/testfx/compare/v2.2.10...v3.0.0)

Breaking changes announcements [#1274](https://github.com/microsoft/testfx/issues/1274)

### Added

* Assert.AreEqual/AreNotEqual overloads with IEquatable [#1433](https://github.com/microsoft/testfx/pull/1433)
* Add DoesNotReturn attribute for Assert.Inconclusive methods [#1422](https://github.com/microsoft/testfx/pull/1422)
* Allow to override GetDisplayName method from DataRowAttribute [#1413](https://github.com/microsoft/testfx/pull/1413)
* Add computer name on the test result [#1409](https://github.com/microsoft/testfx/pull/1409)
* Add public api analyzers [#1318](https://github.com/microsoft/testfx/pull/1318)
* Enable nullable for TestAdapter project [#1370](https://github.com/microsoft/testfx/pull/1370)
* Enable nullable for Platform Services [#1366](https://github.com/microsoft/testfx/pull/1366)
* Enable nullables for Framework [#1365](https://github.com/microsoft/testfx/pull/1365)
* Enable nullable for TestFramework.Extensions [#1363](https://github.com/microsoft/testfx/pull/1363)
* [breaking change] Introduce strategies for test ID generation [#1306](https://github.com/microsoft/testfx/pull/1306)
* Add support for AsyncDisposable cleanup [#1288](https://github.com/microsoft/testfx/pull/1288)
* Add Assert.IsInstanceOfType\<T\> [#1241](https://github.com/microsoft/testfx/pull/1241)

### Changed

* [breaking change] Follow supported .NET frameworks:
  * Dropped support for .NET Framework before 4.6.2 (net462)
  * Dropped support for .NET Standard before 2.0 (netstandard2.0)
  * Dropped support for UWP before 16299
  * Dropped support for WinUI before 18362
  * Replaced support of .NET 5 by .NETCore 3.1 and .NET 6.0
* [breaking change] Assert.AreSame/AreNotSame use generic instead of object [#1430](https://github.com/microsoft/testfx/pull/1430)
* Make BeginTimer and EndTimer methods obsolete [#1425](https://github.com/microsoft/testfx/pull/1425)
* [breaking change] Unify DeploymentDirectory location across target frameworks [#1414](https://github.com/microsoft/testfx/pull/1414)
* [breaking change] Add class/assembly cleanup/init messages to first/last test [#1390](https://github.com/microsoft/testfx/pull/1390)
* Document that DeploymentItemAttribute only works for a test class with test method [#1399](https://github.com/microsoft/testfx/pull/1399)
* Use NewtonsoftJson v13.0.1 [#1361](https://github.com/microsoft/testfx/pull/1361)
* [breaking change] Merge timeout behaviors for .NET Core and .NET Framework [#1296](https://github.com/microsoft/testfx/pull/1296)
* Mark exceptions with SerializableAttribute [#1186](https://github.com/microsoft/testfx/pull/1186)

### Removed

* [breaking change] Remove Assert.AreEqual/AreNotEqual overloads with object object [#1429](https://github.com/microsoft/testfx/pull/1429)

### Fixed

* Propagate UI culture to appdomain [#1401](https://github.com/microsoft/testfx/pull/1401)
* Include localization in Test Framework NuGet [#1397](https://github.com/microsoft/testfx/pull/1397)
* [breaking change] Refactor available ctors for DataRowAttribute [#1332](https://github.com/microsoft/testfx/pull/1332)
* Fix issue causing null ref when test class has no namespace [#1283](https://github.com/microsoft/testfx/pull/1283)
* [breaking change] Unwrap real exception from TargetInvocationException [#1254](https://github.com/microsoft/testfx/pull/1254)
* Fixed the case ignoring in AreEqual() with culture parameter [#1216](https://github.com/microsoft/testfx/pull/1216)

### Artifacts

* MSTest: [3.0.0](https://www.nuget.org/packages/MSTest/3.0.0)
* MSTest.TestFramework: [3.0.0](https://www.nuget.org/packages/MSTest.TestFramework/3.0.0)
* MSTest.TestAdapter: [3.0.0](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.0)

## [3.0.0-preview-20221122-01] - 2022-11-23

See full log [here](https://github.com/microsoft/testfx/compare/v3.0.0-preview-20221110-04...v3.0.0-preview-20221122-01)

### Added

* Enable proper tooling for localization [#1393](https://github.com/microsoft/testfx/pull/1393)
* Include localization in Test Framework NuGet [#1397](https://github.com/microsoft/testfx/pull/1397)
* Propagate UI culture to appdomain [#1401](https://github.com/microsoft/testfx/pull/1401)

### Changed

* Visual Studio grouping tests by `Traits` rendering has changed. To keep something similar to the past, you will have to use group by `Traits` + `Class`. [#1634](https://github.com/microsoft/testfx/issues/1634)
* Disable again the generation of localization files
* Cleanup TestFx.Loc.props
* Update xlf files [#1387](https://github.com/microsoft/testfx/pull/1387)
* Reformat scripts
* Re-enable localization of dlls in CI [#1386](https://github.com/microsoft/testfx/pull/1386)
* Move platformservices localization files to the right folder [#1384](https://github.com/microsoft/testfx/pull/1384)
* Reformat and simplify build.ps1
* Replace other instances of Env.CurrentDir with Assembly.GetExecutingA… [#1380](https://github.com/microsoft/testfx/pull/1380)
* Update testfx repo detection mechanism [#1378](https://github.com/microsoft/testfx/pull/1378)
* Rename folder containing localization dlls in MSTest.TestAdapter NuGet package [#1398](https://github.com/microsoft/testfx/pull/1398)

### Fixed

* Fix TestContext nullabilities [#1382](https://github.com/microsoft/testfx/pull/1382)
* Fix ThrowsException methods return nullability [#1381](https://github.com/microsoft/testfx/pull/1381)
* Fix all markdown issues in releases.md
* Fix some failing debug assertions [#1379](https://github.com/microsoft/testfx/pull/1379)
* DeploymentItemAttribute only works for a test class with test method [#1399](https://github.com/microsoft/testfx/pull/1399)

### Removed

* Remove unused build switch
* Remove DependsOnTargets="TestFxLocalization" for signing
* Remove stale xlf.lcl files

### Artifacts

* MSTest: [3.0.0-preview-20221122-01](https://www.nuget.org/packages/MSTest/3.0.0-preview-20221122-01)
* MSTest.TestFramework: [3.0.0-preview-20221122-01](https://www.nuget.org/packages/MSTest.TestFramework/3.0.0-preview-20221122-01)
* MSTest.TestAdapter: [3.0.0-preview-20221122-01](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.0-preview-20221122-01)

## [3.0.0-preview-20221110-04] - 2022-11-11

See full log [here](https://github.com/microsoft/testfx/compare/v2.3.0-preview-20220810-02...v3.0.0-preview-20221110-04)

### Added

* Enable and fix CA1806 violations [#1227](https://github.com/microsoft/testfx/pull/1227)
* Enable and fix CA1822 (make member static) violations [#1226](https://github.com/microsoft/testfx/pull/1226)
* Enable and fix performance analyzers [#1223](https://github.com/microsoft/testfx/pull/1223)
* Id generator logic restored. [#1174](https://github.com/microsoft/testfx/pull/1174)
* Enable nullable for TestAdapter project [#1370](https://github.com/microsoft/testfx/pull/1370)
* Enable nullable for Platform Services [#1366](https://github.com/microsoft/testfx/pull/1366)
* Enable nullables for Framework [#1365](https://github.com/microsoft/testfx/pull/1365)
* Enable nullable for TestFramework.Extensions [#1363](https://github.com/microsoft/testfx/pull/1363)
* Add tests to document test suite messages [#1313](https://github.com/microsoft/testfx/pull/1313)
* Add support for AsyncDisposable cleanup [#1288](https://github.com/microsoft/testfx/pull/1288)
* Added version parameter to build script [#1264](https://github.com/microsoft/testfx/pull/1264)
* Add WinUI tests to PlatformServices [#1234](https://github.com/microsoft/testfx/pull/1234)
* Add net6.0 tests for PlatformServices [#1233](https://github.com/microsoft/testfx/pull/1233)
* Add Assert.IsInstanceOfType\<T\> [#1241](https://github.com/microsoft/testfx/pull/1241)
* Add some simple test framwork to allow testing MSTest [#1242](https://github.com/microsoft/testfx/pull/1242)
* Merge testfx-docs repo here and update links [#1326](https://github.com/microsoft/testfx/pull/1326)
* Install required .NET before build instead of before test [#1290](https://github.com/microsoft/testfx/pull/1290)
* Allow mirroring. **BYPASS_SECRET_SCANNING**
* List files in case Pdb2Pdb.exe is not found
* List files in case Pdb2Pdb.exe is not found
* Align MicrosoftDiaSymReaderPdb2PdbVersion with arcade one
* Use Foreach-Object to display contents
* Define and apply field naming conventions [#1198](https://github.com/microsoft/testfx/pull/1198)

### Changed

* Improve release notes generator [#1374](https://github.com/microsoft/testfx/pull/1374)
* Bump version to v3.0.0 [#1373](https://github.com/microsoft/testfx/pull/1373)
* Sort lines in public API files
* Refactor reflection helper to return strongly typed attributes [#1369](https://github.com/microsoft/testfx/pull/1369)
* Use NewtonsoftJson v13.0.1 [#1361](https://github.com/microsoft/testfx/pull/1361)
* Refactor integration tests to use FluentAssertions [#1349](https://github.com/microsoft/testfx/pull/1349)
* Revert temporary hack related to .net 6.0.10 [#1346](https://github.com/microsoft/testfx/pull/1346)
* Naming and using cleanup [#1347](https://github.com/microsoft/testfx/pull/1347)
* Update links to official MSTest documentation
* Revisit RFCs [#1342](https://github.com/microsoft/testfx/pull/1342)
* Refactor available ctors for DataRowAttribute [#1332](https://github.com/microsoft/testfx/pull/1332)
* Refactor solution items to add UnitTests folder
* Update prerequisites section
* Bring back stylecop analyzers [#1314](https://github.com/microsoft/testfx/pull/1314)
* Update version of Microsoft.CodeAnalysis.PublicApiAnalyzers
* Update GitHub issues and PR templates [#1315](https://github.com/microsoft/testfx/pull/1315)
* Update Install-DotNetCli end to use similar wording as other steps
* Update PlatformServices.Desktop.Component.Tests to use new test fwk [#1252](https://github.com/microsoft/testfx/pull/1252)
* Update comment about assembly version in TestFx.targets
* Update azure-pipelines.yml
* Update azure-pipelines.yml
* Various styling refactoring [#1334](https://github.com/microsoft/testfx/pull/1334)
* Merge extension projects into one [#1202](https://github.com/microsoft/testfx/pull/1202)
* Merge various PlatformServices.XXX.UnitTests projects together [#1232](https://github.com/microsoft/testfx/pull/1232)
* Merge interfaces into PlatformServices [#1293](https://github.com/microsoft/testfx/pull/1293)
* Merge all implementations of TestContext [#1302](https://github.com/microsoft/testfx/pull/1302)
* Merge timeout behaviors for .NET Core and .NET Framework [#1296](https://github.com/microsoft/testfx/pull/1296)
* Merge TFM specific classes together [#1209](https://github.com/microsoft/testfx/pull/1209)
* Merge TFM specific PlatformServices into a single PlatformServices [#1208](https://github.com/microsoft/testfx/pull/1208)
* Try to simplify automation.cli and support of different TFMs [#1312](https://github.com/microsoft/testfx/pull/1312)
* Don't exclude TestAssets from source control [#1298](https://github.com/microsoft/testfx/pull/1298)
* Rename projects to better match assembly [#1291](https://github.com/microsoft/testfx/pull/1291)
* Convert PlatformServices tests to use new test framework [#1249](https://github.com/microsoft/testfx/pull/1249)
* Convert test.core.unit.tests to use local test framework [#1259](https://github.com/microsoft/testfx/pull/1259)
* Convert smoke.e2e.tests and DiscoveryAndExecutionTests to use local test framework [#1261](https://github.com/microsoft/testfx/pull/1261)
* Ensure we run core tests for all supported TFMs [#1268](https://github.com/microsoft/testfx/pull/1268)
* Ensure we run adapter tests for all supported TFMs [#1267](https://github.com/microsoft/testfx/pull/1267)
* Cleanup solution and test projects [#1282](https://github.com/microsoft/testfx/pull/1282)
* Cleanup on MSTest.CoreAdapter.UnitTests [#1257](https://github.com/microsoft/testfx/pull/1257)
* Unwrap real exception from TargetInvocationException [#1254](https://github.com/microsoft/testfx/pull/1254)
* Convert MSTest.CoreAdapter.Unit.Tests to use new test framework [#1245](https://github.com/microsoft/testfx/pull/1245)
* Revert CallerArgumentExpression attribute changes [#1251](https://github.com/microsoft/testfx/pull/1251)
* Do not fail generate release task notes when skipping
* Display full packages folder
* Discard auto PRs in write-release-notes.ps1 [#1173](https://github.com/microsoft/testfx/pull/1173)
* Split Assert class per group of feature [#1238](https://github.com/microsoft/testfx/pull/1238)
* Improve assembly versions and available metadata [#1231](https://github.com/microsoft/testfx/pull/1231)
* More project/files simplification for PlatformServices [#1221](https://github.com/microsoft/testfx/pull/1221)
* Projects cleanup [#1219](https://github.com/microsoft/testfx/pull/1219)
* Factorize out some project properties [#1217](https://github.com/microsoft/testfx/pull/1217)
* Find TP package version using Versions.props [#1211](https://github.com/microsoft/testfx/pull/1211)
* Simplify Link references in csproj
* Review compiler directives [#1203](https://github.com/microsoft/testfx/pull/1203)
* Ignore commit 4bb533 from revision logs
* Use newer C# syntaxes [#1200](https://github.com/microsoft/testfx/pull/1200)
* Ignore commit "Define and apply field naming conventions"
* Ignore convert to file-scoped namespace revision
* Convert to file-scoped namespaces [#1197](https://github.com/microsoft/testfx/pull/1197)
* Target .NET 6 instead of .NET 5 [#1196](https://github.com/microsoft/testfx/pull/1196)
* Prefer specific tfm over generic ones [#1192](https://github.com/microsoft/testfx/pull/1192)
* Simplify projects dependencies and files [#1193](https://github.com/microsoft/testfx/pull/1193)
* Target netstandard2.0 as minimal netstandard [#1194](https://github.com/microsoft/testfx/pull/1194)
* Simplify UWP projects [#1191](https://github.com/microsoft/testfx/pull/1191)
* Make private fields readonly when possible [#1188](https://github.com/microsoft/testfx/pull/1188)
* Favor inline initialization over static ctor [#1189](https://github.com/microsoft/testfx/pull/1189)
* Mark exceptions with SerializableAttribute [#1186](https://github.com/microsoft/testfx/pull/1186)
* Apply modern C# features/syntaxes [#1183](https://github.com/microsoft/testfx/pull/1183)
* Rename MSTest.CoreAdapter into MSTest.TestAdapter [#1181](https://github.com/microsoft/testfx/pull/1181)
* Move test projects to SDK style [#1179](https://github.com/microsoft/testfx/pull/1179)

### Fixed

* Fix broken tests and refactor test API [#1352](https://github.com/microsoft/testfx/pull/1352)
* Fix issue causing null ref when test class has no namespace [#1283](https://github.com/microsoft/testfx/pull/1283)
* Fix localization path
* Fix .gitignore
* Fix included package [#1280](https://github.com/microsoft/testfx/pull/1280)
* Fix common.lib.ps1 to download latest patched SDKs [#1279](https://github.com/microsoft/testfx/pull/1279)
* Fix included package [#1280](https://github.com/microsoft/testfx/pull/1280)
* Fix common.lib.ps1 to download latest patched SDKs [#1279](https://github.com/microsoft/testfx/pull/1279)
* Fix broken unit tests
* Fix testasset of ComponentTests
* Fix some typos in test names
* Fix some typos
* Fix NuGet packages content + support netcoreapp3.1 [#1228](https://github.com/microsoft/testfx/pull/1228)
* Fix broken tests on main [#1265](https://github.com/microsoft/testfx/pull/1265)
* Fixed the case ignoring in AreEqual() with culture parameter [#1216](https://github.com/microsoft/testfx/pull/1216)
* Fix behavior for netcore TFMs [#1230](https://github.com/microsoft/testfx/pull/1230)
* Fixed package restore.

### Removed

* Remove class/assembly initialization messages from logs. [#1339](https://github.com/microsoft/testfx/pull/1339)
* Remove unexpected dll in target [#1308](https://github.com/microsoft/testfx/pull/1308)

### Artifacts

* MSTest: [3.0.0-preview-20221110-04](https://www.nuget.org/packages/MSTest/3.0.0-preview-20221110-04)
* MSTest.TestFramework: [3.0.0-preview-20221110-04](https://www.nuget.org/packages/MSTest.TestFramework/3.0.0-preview-20221110-04)
* MSTest.TestAdapter: [3.0.0-preview-20221110-04](https://www.nuget.org/packages/MSTest.TestAdapter/3.0.0-preview-20221110-04)

## [2.3.0-preview-20220810-02] 2022-08-10

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.10...v2.3.0-preview-20220810-02)

### Added

* [Add whitespace editorconfig and run dotnet format whitespace](https://github.com/microsoft/testfx/pull/1090)
* [Adding Microsoft SECURITY.MD](https://github.com/microsoft/testfx/pull/1109)

### Changed

* [Better messages for XXXInitialize and XXXCleanup](https://github.com/microsoft/testfx/pull/1147)
* [TestResults folder names are now cross platform compatible, as per #678](https://github.com/microsoft/testfx/pull/1119)
* Bumped up version to 2.3.0
* [Assert failure messages](https://github.com/microsoft/testfx/pull/1172)
* [Ensure assertions do not fail with FormatException](https://github.com/microsoft/testfx/pull/1126)
* [Prevent format exceptions when parameters array is empty](https://github.com/microsoft/testfx/pull/1124)
* [\[main\] Update dependencies from dotnet/arcade](https://github.com/microsoft/testfx/pull/1098)

### Fixed

* [Fixed issues with SDK style projects.](https://github.com/microsoft/testfx/pull/1171)

### Removed

* [Remove unused classes](https://github.com/microsoft/testfx/pull/1089)

### Artifacts

* MSTest: [2.3.0-preview-20220810-02](https://www.nuget.org/packages/MSTest/2.3.0-preview-20220810-02)
* MSTest.TestFramework: [2.3.0-preview-20220810-02](https://www.nuget.org/packages/MSTest.TestFramework/2.3.0-preview-20220810-02)
* MSTest.TestAdapter: [2.3.0-preview-20220810-02](https://www.nuget.org/packages/MSTest.TestAdapter/2.3.0-preview-20220810-02)

## [2.2.10] - 2022-04-26

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.10-preview-20220414-01...v2.2.10)

### Added

* [Added more fail paths for data serialization.](https://github.com/microsoft/testfx/pull/1084)
* [Added MSTest meta-package.](https://github.com/microsoft/testfx/pull/1076)
* [Static init of StackTraceHelper.typesToBeExcluded](https://github.com/microsoft/testfx/pull/1055)

### Changed

* [Update description of the Nuget packages](https://github.com/microsoft/testfx/pull/981)
* [Converted files to utf-8 so they can be diffed.](https://github.com/microsoft/testfx/pull/1070)
* [Update dependencies from https://github.com/dotnet/arcade build 20220425.6](https://github.com/microsoft/testfx/pull/1087)
* [Run dotnet format whitespace](https://github.com/microsoft/testfx/pull/1085)

### Fixed

* [Test execution bugs in specific TFMs addressed.](https://github.com/microsoft/testfx/pull/1071)

### Artifacts

* MSTest: [2.2.10](https://www.nuget.org/packages/MSTest/2.2.10)
* MSTest.TestFramework: [2.2.10](https://www.nuget.org/packages/MSTest.TestFramework/2.2.10)
* MSTest.TestAdapter: [2.2.10](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.10)

## [2.2.10-preview-20220414-01] - 2022-04-14

### Fixed

* [Fix write conflicts in parallel output](https://github.com/microsoft/testfx/pull/1068)
* [Fixed test run executable files.](https://github.com/microsoft/testfx/pull/1064)
* [\[UITestMethod\] should invoke test method with null](https://github.com/microsoft/testfx/pull/1045)

### Artifacts

* MSTest.TestFramework: [2.2.10-preview-20220414-01](https://www.nuget.org/packages/MSTest.TestFramework/2.2.10-preview-20220414-01)
* MSTest.TestAdapter: [2.2.10-preview-20220414-01](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.10-preview-20220414-01)

## [2.2.9] 2022-04-08

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.8...v2.2.9)

### Parallel output

> 🙇 Shout out to @SimonCropp, for bringing this functionality to XUnit in his <https://github.com/SimonCropp/XunitContext> project. And being an inspiration for implementing this.

MSTest 2.2.9 captures all Console output and attaches it to the correct test, even if you are running tests in parallel. This output is captured from your test code as well as from the tested code. And it requires no special setup.

#### Before

In 2.2.8, test output is scattered among tests, in our example, one unlucky test gets all the output of other tests just mixed together:

![image](https://user-images.githubusercontent.com/5735905/162252520-0572d932-c798-4b7e-8961-44f39b5a32b9.png)

#### After

With 2.2.9, each output is correctly attached to the test that produced it:

![image](https://user-images.githubusercontent.com/5735905/162252738-2dae4ff3-d7bf-473a-9304-66cf25510a89.png)
![image](https://user-images.githubusercontent.com/5735905/162252762-4304b9c0-1e60-4089-83e3-e8f341cb9329.png)

Also notice that we are also capturing debug, trace and error. And we are not awaiting the FastChild method, and the output is still assigned correctly.  [Souce code.](https://gist.github.com/nohwnd/2936753d94301d7991059660d1d63a8a)

#### Limitations

Due to the way that class and assembly initialize, and cleanup are invoked, their output will end up in the first test that run (or last for cleanup). This is unfortunately not easily fixable.

### Artifacts

* MSTest.TestFramework: [2.2.9](https://www.nuget.org/packages/MSTest.TestFramework/2.2.9)
* MSTest.TestAdapter: [2.2.9](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.9)

## [2.2.8] - 2021-11-23

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.7...v2.2.8)

### Added

* [Added internal versioning](https://github.com/microsoft/testfx/pull/1012)
* [Added 500ms overhead to parallel execution tests.](https://github.com/microsoft/testfx/pull/962)
* [Downgrade uwp](https://github.com/microsoft/testfx/pull/1008)
* [Add DoesNotReturnIf to Assert.IsTrue/Assert.IsFalse](https://github.com/microsoft/testfx/pull/1005)
* [Implement Class Cleanup Lifecycle selection](https://github.com/microsoft/testfx/pull/968)

### Changed

* Dependency version updates.
* [Added 500ms overhead to parallel execution tests.](https://github.com/microsoft/testfx/pull/962)
* [Updated to WindowsAppSDK 1.0.0 GA](https://github.com/microsoft/testfx/pull/1009)
* [Updated to WindowsAppSDK 1.0.0-preview1](https://github.com/microsoft/testfx/pull/985)
* [Cherry-picking the changes from 2.2.7](https://github.com/microsoft/testfx/pull/958)

### Fixed

* [Fixed .nuspec files to mitigate NU5050 error.](https://github.com/microsoft/testfx/pull/1011)
* [Fix concurrent issues in DataSerializationHelper](https://github.com/microsoft/testfx/pull/998)
* [Fix for incorrect Microsoft.TestPlatform.AdapterUtilities.dll for net45 target (#980)](https://github.com/microsoft/testfx/pull/988)
* [CVE-2017-0247 fixed](https://github.com/microsoft/testfx/pull/976)

### Artifacts

* MSTest.TestFramework: [2.2.8](https://www.nuget.org/packages/MSTest.TestFramework/2.2.8)
* MSTest.TestAdapter: [2.2.8](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.8)

## [2.2.7] - 2021-09-03

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.6...v2.2.7)

### Changed

* [Resolve dependencies from GAC](https://github.com/microsoft/testfx/pull/951)

### Fixed

* [Fixed missing strong-name and Authenticode signatures](https://github.com/microsoft/testfx/pull/956)

### Artifacts

* MSTest.TestFramework: [2.2.7](https://www.nuget.org/packages/MSTest.TestFramework/2.2.7)
* MSTest.TestAdapter: [2.2.7](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.7)

## [2.2.6] - 2021-08-25

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.5...v2.2.6)

### Changed

* [Enable internal testclass discovery (#937)](https://github.com/microsoft/testfx/pull/944)
* Allow opting-out of ITestDataSource test discovery.

### Fixed

* [Fix DateTime looses significant digits in DynamicData (#875)](https://github.com/microsoft/testfx/pull/907)

### Artifacts

* MSTest.TestFramework: [2.2.6](https://www.nuget.org/packages/MSTest.TestFramework/2.2.6)
* MSTest.TestAdapter: [2.2.6](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.6)

## [2.2.5] - 2021-06-28

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.4...v2.2.5)

### Added

* [Added missing framework references for WinUI](https://github.com/microsoft/testfx/pull/890)

### Changed

* [Upgraded winui to 0.8.0](https://github.com/microsoft/testfx/pull/888)
* [Replaced license file with an expression.](https://github.com/microsoft/testfx/pull/846)

### Fixed

* [Fixes #799 by testing logged messages against "null or whitespace" instead of "null or empty"](https://github.com/microsoft/testfx/pull/892)
* [Fixed a bug in `ITestDataSource` data deserialization](https://github.com/microsoft/testfx/pull/864)
* [Fixed DataSource deserialization.](https://github.com/microsoft/testfx/pull/859)
* [Fixed a serialization issue with DataRows.](https://github.com/microsoft/testfx/pull/847)

### Artifacts

* MSTest.TestFramework: [2.2.5](https://www.nuget.org/packages/MSTest.TestFramework/2.2.5)
* MSTest.TestAdapter: [2.2.5](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.5)

## [2.2.4] - 2021-05-25

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/0b95a26282eae17f896d732381e5c77b9a603382...v2.2.4)

### Artifacts

* MSTest.TestFramework: [2.2.4](https://www.nuget.org/packages/MSTest.TestFramework/2.2.4)
* MSTest.TestAdapter: [2.2.4](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.4)

## [2.2.4-preview-20210331-02] - 2021-04-02

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.3...v2.2.4-preview-20210331-02)

### Added

* [Added basic WinUI3 support.](https://github.com/microsoft/testfx/pull/782)

### Changed

* [Some code clean-up and refactoring](https://github.com/microsoft/testfx/pull/800)

### Fixed

* [Fix StackOverflowException in StringAssert.DoesNotMatch](https://github.com/microsoft/testfx/pull/806)
* [MSBuild scripts fixed.](https://github.com/microsoft/testfx/pull/801)

### Artifacts

* MSTest.TestFramework: [2.2.4-preview-20210331-02](https://www.nuget.org/packages/MSTest.TestFramework/2.2.4-preview-20210331-02)
* MSTest.TestAdapter: [2.2.4-preview-20210331-02](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.4-preview-20210331-02)

## [2.2.3] - 2021-03-16

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.2...v2.2.3)

### Added

* [Added missing library to the NuGet package.](https://github.com/microsoft/testfx/pull/798)

### Artifacts

* MSTest.TestFramework: [2.2.3](https://www.nuget.org/packages/MSTest.TestFramework/2.2.3)
* MSTest.TestAdapter: [2.2.3](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.3)

## [2.2.2] - 2021-03-15

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.1...v2.2.2)

### Added

* [Missing assembly added to TestAdapter package](https://github.com/microsoft/testfx/pull/796)

### Fixed

* [NuGet package dependencies fixed.](https://github.com/microsoft/testfx/pull/797)
* [Unit test display name issue fixed.](https://github.com/microsoft/testfx/pull/795)
* [Fix infinite iteration in Matches method](https://github.com/microsoft/testfx/pull/792)

### Artifacts

* MSTest.TestFramework: [2.2.2](https://www.nuget.org/packages/MSTest.TestFramework/2.2.2)
* MSTest.TestAdapter: [2.2.2](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.2)

## [2.2.1] - 2021-03-01

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.0-preview-20210115-03...v2.2.1)

### Added

* [Merge parameters safely](https://github.com/microsoft/testfx/pull/778)
* [Merge settings safely](https://github.com/microsoft/testfx/pull/771)

### Changed

* [Prepend MSTest to log messages, without formatting](https://github.com/microsoft/testfx/pull/785)
* [TestPlatform version updated to v16.9.1](https://github.com/microsoft/testfx/pull/784)
* [Forward logs to EqtTrace on netcore](https://github.com/microsoft/testfx/pull/776)
* [ManagedNames impl. refactored.](https://github.com/microsoft/testfx/pull/766)

### Fixed

* [Fixed concurrency issues in the TypeCache class.](https://github.com/microsoft/testfx/pull/758)

### Removed

* [WIP: Remove .txt extension from LICENSE file](https://github.com/microsoft/testfx/pull/781)

### Artifacts

* MSTest.TestFramework: [2.2.1](https://www.nuget.org/packages/MSTest.TestFramework/2.2.1)
* MSTest.TestAdapter: [2.2.1](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.1)

## [2.2.0-preview-20210115-03] - 2021-01-20

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.2.0-preview-20201126-03...v2.2.0-preview-20210115-03)

### Changed

* [Updates](https://github.com/microsoft/testfx/pull/755)
* [Refactored `TypesToLoadAttribute` into `TestExtensionTypesAttribute`](https://github.com/microsoft/testfx/pull/754)

### Fixed

* [Fixing pdb2pdb package](https://github.com/microsoft/testfx/pull/760)
* [Fixing nugets](https://github.com/microsoft/testfx/pull/759)
* [Fixed TypesToLoadAttribute compatibility](https://github.com/microsoft/testfx/pull/753)
* [BugFix: WorkItemAttribute not extracted](https://github.com/microsoft/testfx/pull/749)
* [Pdb2Pbp path fix](https://github.com/microsoft/testfx/pull/761)

### Removed

* [Removed unnecessary whitespace](https://github.com/microsoft/testfx/pull/752)
* [Removed MyGet references from README.md](https://github.com/microsoft/testfx/pull/751)

### Artifacts

* MSTest.TestFramework: [2.2.0-preview-20210115-03](https://www.nuget.org/packages/MSTest.TestFramework/2.2.0-preview-20210115-03)
* MSTest.TestAdapter: [2.2.0-preview-20210115-03](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.0-preview-20210115-03)

## [2.2.0-preview-20201126-03] - 2020-11-26

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.1.2...v2.2.0-preview-20201126-03)

### Added

* [Added support for ManagedType and ManagedClass](https://github.com/microsoft/testfx/pull/737)
* [Add nullable-annotated Assert.IsNotNull](https://github.com/microsoft/testfx/pull/744)
* [Add support to treat class/assembly warnings as errors](https://github.com/microsoft/testfx/pull/717)
* [Added StringComparison to StringAssert Contains(), EndsWith(), and StartsWith()](https://github.com/microsoft/testfx/pull/691)

### Changed

* [Replaced deprecated certificate](https://github.com/microsoft/testfx/pull/742)
* [Assert.IsTrue() & False() to handle nullable bools](https://github.com/microsoft/testfx/pull/690)

### Fixed

* [Fix XML doc comments (code -> c)](https://github.com/microsoft/testfx/pull/730)
* [Fix null ref bug when base class cleanup fails when there is no derived class cleanup method](https://github.com/microsoft/testfx/pull/716)

### Removed

* [Load specific types from adapter](https://github.com/microsoft/testfx/pull/746)

### Artifacts

* MSTest.TestFramework: [2.2.0-preview-20201126-03](https://www.nuget.org/packages/MSTest.TestFramework/2.2.0-preview-20201126-03)
* MSTest.TestAdapter: [2.2.0-preview-20201126-03](https://www.nuget.org/packages/MSTest.TestAdapter/2.2.0-preview-20201126-03)

## [2.1.2] - 2020-06-08

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.1.1...v2.1.2)

### Changed

* [Set IsClassInitializeExecuted=true after base class init to avoid repeated class init calls](https://github.com/microsoft/testfx/pull/705)
* [Change NuGet package to use `None` ItemGroup to copy files to output directory](https://github.com/microsoft/testfx/pull/703)
* [Improve CollectionAssert.Are*Equal docs (#711)](https://github.com/microsoft/testfx/pull/712)
* [enhance documentation on when the TestCleanup is executed](https://github.com/microsoft/testfx/pull/709)
* [Make AssemblyCleanup/ClassCleanup execute even if Initialize fails.](https://github.com/microsoft/testfx/pull/696)

### Fixed

* [Fixed documentation for the TestMethodAttribute](https://github.com/microsoft/testfx/pull/715)

### Artifacts

* MSTest.TestFramework: [2.1.2](https://www.nuget.org/packages/MSTest.TestFramework/2.1.2)
* MSTest.TestAdapter: [2.1.2](https://www.nuget.org/packages/MSTest.TestAdapter/2.1.2)

## [2.1.1] - 2020-04-01

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.1.0...v2.1.1)

### Added

* [Add FSharp E2E test](https://github.com/microsoft/testfx/pull/683)
* [Create Write() in TestContext](https://github.com/microsoft/testfx/pull/686)

### Changed

* [switch arguments for expected and actual in Assert.AreEquals in multiple tests](https://github.com/microsoft/testfx/pull/685)

### Fixed

* [fix blog link](https://github.com/microsoft/testfx/pull/677)
* [Spelling / conventions and grammar fixes](https://github.com/microsoft/testfx/pull/688)

### Removed

* [remove unused usings](https://github.com/microsoft/testfx/pull/694)

### Artifacts

* MSTest.TestFramework: [2.1.1](https://www.nuget.org/packages/MSTest.TestFramework/2.1.1)
* MSTest.TestAdapter: [2.1.1](https://www.nuget.org/packages/MSTest.TestAdapter/2.1.1)

## [2.1.0] - 2020-02-03

A list of changes since last release are available [here](https://github.com/microsoft/testfx/compare/v2.1.0-beta2...v2.1.0)

### Changed

* [Record test start/end events for data driven tests](https://github.com/microsoft/testfx/pull/631)

### Fixed

* [Fix parameters in tests](https://github.com/microsoft/testfx/pull/680)
* [Fix bugs in parent class init/cleanup logic](https://github.com/microsoft/testfx/pull/660)

### Artifacts

* MSTest.TestFramework: [2.1.0](https://www.nuget.org/packages/MSTest.TestFramework/2.1.0)
* MSTest.TestAdapter: [2.1.0](https://www.nuget.org/packages/MSTest.TestAdapter/2.1.0)

## [2.1.0-beta2] - 2019-12-18

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v2.1.0-beta...v2.1.0-beta2)

### Changed

* [Friendly test names](https://github.com/microsoft/testfx/pull/466)

### Artifacts

* MSTest.TestFramework: [2.1.0-beta2](https://www.nuget.org/packages/MSTest.TestFramework/2.1.0-beta2)
* MSTest.TestAdapter: [2.1.0-beta2](https://www.nuget.org/packages/MSTest.TestAdapter/2.1.0-beta2)

## [2.1.0-beta] - 2019-11-28

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v2.0.0...v2.1.0-beta)

### Fixed

* [Fix incompatibility between multiple versions of mstest adapter present in a solution](https://github.com/Microsoft/testfx/pull/659)
* [Build script fix to work with VS2019](https://github.com/Microsoft/testfx/pull/641)

### Artifacts

* MSTest.TestFramework: [2.1.0-beta](https://www.nuget.org/packages/MSTest.TestFramework/2.1.0-beta)
* MSTest.TestAdapter: [2.1.0-beta](https://www.nuget.org/packages/MSTest.TestAdapter/2.1.0-beta)

## [2.0.0] 2019-09-03

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v2.0.0-beta4...v2.0.0)

### Added

* [Implemented 'AddResultFile' for NetCore TestContext](https://github.com/Microsoft/testfx/pull/609)
* [Implemented Initialize Inheritance for ClassInitialize attribute](https://github.com/Microsoft/testfx/issues/577)

### Changed

* [Apply TestCategory from derived class on inherited test methods](https://github.com/Microsoft/testfx/issues/513)
* [Setting MapNotRunnableToFailed to true by default](https://github.com/Microsoft/testfx/issues/610)
* [Datarow tests - support methods with optional parameters](https://github.com/Microsoft/testfx/pull/604)

### Fixed

* [Fixed IsNotInstanceOfType failing when objected being asserted on is null](https://github.com/Microsoft/testfx/issues/622)

### Artifacts

* MSTest.TestFramework: [2.0.0](https://www.nuget.org/packages/MSTest.TestFramework/2.0.0)
* MSTest.TestAdapter: [2.0.0](https://www.nuget.org/packages/MSTest.TestAdapter/2.0.0)

## [2.0.0-beta4] - 2019-04-10

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/2.0.0-beta2...v2.0.0-beta4)

### Changed

* [Deployment Item support in .NET Core](https://github.com/Microsoft/testfx/pull/565)
* [Support for CancellationTokenSource in TestContext to help in timeout scenario](https://github.com/Microsoft/testfx/pull/585)
* [Correcting error message when DynamicData doesn't have any data](https://github.com/Microsoft/testfx/issues/443)

### Artifacts

* MSTest.TestFramework: [2.0.0-beta4](https://www.nuget.org/packages/MSTest.TestFramework/2.0.0-beta4)
* MSTest.TestAdapter: [2.0.0-beta4](https://www.nuget.org/packages/MSTest.TestAdapter/2.0.0-beta4)

## [2.0.0-beta2] - 2019-02-15

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/1.4.0...2.0.0-beta2)

### Changed

* (BREAKING CHANGE) [TestContext Properties type fixed to be IDictionary](https://github.com/Microsoft/testfx/pull/563)
* [Base class data rows should not be executed](https://github.com/Microsoft/testfx/pull/546)
* [Setting option for marking not runnable tests as failed](https://github.com/Microsoft/testfx/pull/524)

### Artifacts

* MSTest.TestFramework: [2.0.0-beta2](https://www.nuget.org/packages/MSTest.TestFramework/2.0.0-beta2)
* MSTest.TestAdapter: [2.0.0-beta2](https://www.nuget.org/packages/MSTest.TestAdapter/2.0.0-beta2)

## [1.4.0] - 2018-11-26

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/1.4.0-beta...1.4.0)

### Added

* [Added new runsettings configuration to deploy all files from test source location i.e. DeployTestSourceDependencies](https://github.com/Microsoft/testfx/pull/391) [enhancement]

### Changed

* (BREAKING CHANGE) [Description, WorkItem, CssIteration, CssProjectStructure Attributes will not be treated as traits](https://github.com/Microsoft/testfx/pull/482)
* [Allow test methods returning Task to run without suppling async keyword](https://github.com/Microsoft/testfx/pull/510) [Contributed by [Paul Spangler](https://github.com/spanglerco)]

### Removed

* [Removed Test discovery warnings in Test Output pane](https://github.com/Microsoft/testfx/pull/480) [Contributed by [Carlos Parra](https://github.com/parrainc)]

### Artifacts

* MSTest.TestFramework: [1.4.0](https://www.nuget.org/packages/MSTest.TestFramework/1.4.0)
* MSTest.TestAdapter: [1.4.0](https://www.nuget.org/packages/MSTest.TestAdapter/1.4.0)

## [1.4.0-beta] 2018-10-17

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/1.3.2...1.4.0-beta)

### Added

* [Adding appropriate error message for TestMethods expecting parameters but parameters not provided](https://github.com/Microsoft/testfx/pull/457)

### Changed

* [Enabling Tfs properties in test context object](https://github.com/Microsoft/testfx/pull/472) [enhancement]
* [Description, WorkItem, CssIteration, CssProjectStructure Attributes should not be treated as traits](https://github.com/Microsoft/testfx/pull/482)

### Artifacts

* MSTest.TestFramework: [1.4.0-beta](https://www.nuget.org/packages/MSTest.TestFramework/1.4.0-beta)
* MSTest.TestAdapter: [1.4.0-beta](https://www.nuget.org/packages/MSTest.TestAdapter/1.4.0-beta)

## [1.3.2] - 2018-06-06

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.3.1...v1.3.2)

### Changed

* [Hierarchical view support for data-driven tests](https://github.com/Microsoft/testfx/pull/417)

### Artifacts

* MSTest.TestFramework: [1.3.2](https://www.nuget.org/packages/MSTest.TestFramework/1.3.2)
* MSTest.TestAdapter: [1.3.2](https://www.nuget.org/packages/MSTest.TestAdapter/1.3.2)

## [1.3.1] - 2018-05-25

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.3.0...v1.3.1)

### Changed

* [AppDomain creation should honor runsettings](https://github.com/Microsoft/testfx/pull/427)
* [Don't delete resource folder while clean/rebuild](https://github.com/Microsoft/testfx/pull/424)

### Artifacts

* MSTest.TestFramework: [1.3.1](https://www.nuget.org/packages/MSTest.TestFramework/1.3.1)
* MSTest.TestAdapter: [1.3.1](https://www.nuget.org/packages/MSTest.TestAdapter/1.3.1)

## [1.3.0] - 2018-05-11

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.2.1...v1.3.0)

### Changed

* [Run Class Cleanup in sync with Class Initialize](https://github.com/Microsoft/testfx/pull/372)
* [TestTimeout configurable via RunSettings](https://github.com/Microsoft/testfx/pull/403) [enhancement]
* [Consistent behavior of GenericParameterHelper's while running and debugging](https://github.com/Microsoft/testfx/issues/362) [Contributed by [walterlv](https://github.com/walterlv)]
* [Customize display name for DynamicDataAttribute](https://github.com/Microsoft/testfx/pull/373) [Contributed by [Brad Stoney](https://github.com/bstoney)] [enhancement]

### Fixed

* [Fix incompatibility between multiple versions of mstest adapter present in a solution](https://github.com/Microsoft/testfx/pull/404)
* [Fix multiple results not returning for custom TestMethod](https://github.com/Microsoft/testfx/pull/363) [Contributed by [Cédric Bignon](https://github.com/bignoncedric)]
* [Fix to show right error message on assembly load exception during test run](https://github.com/Microsoft/testfx/issues/395)

### Artifacts

* MSTest.TestFramework: [1.3.0](https://www.nuget.org/packages/MSTest.TestFramework/1.3.0)
* MSTest.TestAdapter: [1.3.0](https://www.nuget.org/packages/MSTest.TestAdapter/1.3.0)

## [1.3.0-beta2] - 2018-01-15

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.2.0...v1.3.0-beta2)

### Added

* [Add information about which assembly failed to discover test](https://github.com/Microsoft/testfx/pull/299) [Contributed by [Andrey Kurdyumov](https://github.com/kant2002)]
* [Adding warning message for vsmdi file](https://github.com/Microsoft/testfx/issues/61)
* [Add missing Microsoft.Internal.TestPlatform.ObjectModel](https://github.com/Microsoft/testfx/pull/301) [Contributed by [Andrey Kurdyumov](https://github.com/kant2002)]

### Changed

* [Update File version for adapter and framework dlls](https://github.com/Microsoft/testfx/issues/268)
* [In-Assembly Parallel Feature](https://github.com/Microsoft/testfx/pull/296)

### Fixed

* [Fixing Key collision for test run parameters](https://github.com/Microsoft/testfx/issues/298)
* [Fix for csv x64 scenario](https://github.com/Microsoft/testfx/issues/325)
* [DataRow DisplayName Fix in .Net framework](https://github.com/Microsoft/testfx/issues/284)

### Artifacts

* MSTest.TestFramework: [1.3.0-beta2](https://www.nuget.org/packages/MSTest.TestFramework/1.3.0-beta2)
* MSTest.TestAdapter: [1.3.0-beta2](https://www.nuget.org/packages/MSTest.TestAdapter/1.3.0-beta2)

## [1.2.1] - 2018-04-05

### Changed

* [Don't call Class Cleanup if Class Init not called](https://github.com/Microsoft/testfx/pull/372)

### Removed

* [Fixing Key collision for test run parameters](https://github.com/Microsoft/testfx/pull/328)
* [Fix masking assembly load failure error message](https://github.com/Microsoft/testfx/pull/382)
* [Fix UWP tests discovery](https://github.com/Microsoft/testfx/pull/332)

### Artifacts

* MSTest.TestFramework: [1.2.1](https://www.nuget.org/packages/MSTest.TestFramework/1.2.1)
* MSTest.TestAdapter: [1.2.1](https://www.nuget.org/packages/MSTest.TestAdapter/1.2.1)

## [1.2.0] - 2017-10-11

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.2.0-beta3...v1.2.0)

### Added

* [Adding support for DiaNavigation in UWP test adapter](https://github.com/Microsoft/testfx/pull/258)
* [Adding filtering support at discovery](https://github.com/Microsoft/testfx/pull/271)
* [DataSourceAttribute Implementation](https://github.com/Microsoft/testfx/pull/238)

### Changed

* [Improve handling of Assert.Inconclusive](https://github.com/Microsoft/testfx/pull/277)
* [Arguments order for ArgumentException](https://github.com/Microsoft/testfx/pull/262)

### Artifacts

* MSTest.TestFramework: [1.2.0](https://www.nuget.org/packages/MSTest.TestFramework/1.2.0)
* MSTest.TestAdapter: [1.2.0](https://www.nuget.org/packages/MSTest.TestAdapter/1.2.0)

## [1.2.0-beta3] - 2017-08-09

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.2.0-beta...v1.2.0-beta3)

### Added

* [Added Mapping for TestOutcome.None to the UnitTestOutcome Enum to achieve NotExecuted behaviour in VSTS](https://github.com/Microsoft/testfx/issues/217) [Contributed By [Irguzhav](https://github.com/irguzhav)] [enhancement]

### Changed

* [All the Assert constructor's has been made private and the classes sealed](https://github.com/Microsoft/testfx/issues/223)
* [Adapter is not sending TestCategory traits in Testcase object to Testhost](https://github.com/Microsoft/testfx/issues/189)
* [TestMethod failures masked by TestCleanUp exceptions](https://github.com/Microsoft/testfx/issues/58)
* [Multiple copies added for same test on running multiple times in IntelliTest](https://github.com/Microsoft/testfx/issues/92)

### Artifacts

* MSTest.TestFramework: [1.2.0-beta3](https://www.nuget.org/packages/MSTest.TestFramework/1.2.0-beta3)
* MSTest.TestAdapter: [1.2.0-beta3](https://www.nuget.org/packages/MSTest.TestAdapter/1.2.0-beta3)

## [1.2.0-beta] - 2017-06-29

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.1.18...v1.2.0-beta)

### Changed

* [Support for Dynamic Data Attribute](https://github.com/Microsoft/testfx/issues/141) [extensibility]
* [Make discovering test methods from base classes defined in another assembly the default](https://github.com/Microsoft/testfx/issues/164) [enhancement]
* [CollectSourceInformation awareness to query source information](https://github.com/Microsoft/testfx/issues/119) [enhancement]

### Artifacts

* MSTest.TestFramework: [1.2.0-beta](https://www.nuget.org/packages/MSTest.TestFramework/1.2.0-beta)
* MSTest.TestAdapter: [1.2.0-beta](https://www.nuget.org/packages/MSTest.TestAdapter/1.2.0-beta)

## [1.1.18] - 2017-06-01

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.1.17...v1.1.18)

### Changed

* [Ability to provide a reason for Ignored tests](https://github.com/Microsoft/testfx/issues/126) [enhancement]
* [VB unit test project templates that ship in VS 2017 do not reference MSTest V2 nuget packages](https://github.com/Microsoft/testfx/issues/132) [enhancement]
* [Assert.IsInstanceOf passes on value null](https://github.com/Microsoft/testfx/issues/178) [Contributed By [LarsCelie](https://github.com/larscelie)]
* [Test methods in a base class defined in a different assembly are not navigable in Test Explorer](https://github.com/Microsoft/testfx/issues/163) [Contributed By [ajryan](https://github.com/ajryan)]
* [Enable MSTest framework based tests targeting .NET Core to be run and debugged from within VSCode](https://github.com/Microsoft/testfx/issues/182)
* [Web project templates that ship in VS 2017 do not reference MSTest V2 nuget packages](https://github.com/Microsoft/testfx/issues/167)

### Artifacts

* MSTest.TestFramework: [1.1.18](https://www.nuget.org/packages/MSTest.TestFramework/1.1.18)
* MSTest.TestAdapter: [1.1.18](https://www.nuget.org/packages/MSTest.TestAdapter/1.1.18)

## [1.1.17] - 2017-04-21

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.1.14...v1.1.17)

### Changed

* [Console.WriteLine support for .NetCore Projects](https://github.com/Microsoft/testfx/issues/18) [enhancement]
* [Inheritance support for base classes that resides in different assemblies](https://github.com/Microsoft/testfx/issues/23) [enhancement]
* [TestContext.Writeline does not output messages](https://github.com/Microsoft/testfx/issues/120)
* [Logger.LogMessage logs a message mutliple times](https://github.com/Microsoft/testfx/issues/114)
* [TestContext.CurrentTestOutcome is always InProgress in the TestCleanup method](https://github.com/Microsoft/testfx/issues/89)
* [An inconclusive in a test initialize fails the test if it has an ExpectedException](https://github.com/Microsoft/testfx/issues/136)

### Artifacts

* MSTest.TestFramework: [1.1.17](https://www.nuget.org/packages/MSTest.TestFramework/1.1.17)
* MSTest.TestAdapter: [1.1.17](https://www.nuget.org/packages/MSTest.TestAdapter/1.1.17)

## [1.1.14] - 2017-03-31

A list of changes since last release are available [here](https://github.com/Microsoft/testfx/compare/v1.1.13...v1.1.14)

### Changed

* [Ability to add custom assertions](https://github.com/Microsoft/testfx/issues/116) [enhancement]

### Fixed

* [Problems with null in DataRow](https://github.com/Microsoft/testfx/issues/70)

### Artifacts

* MSTest.TestFramework: [1.1.14](https://www.nuget.org/packages/MSTest.TestFramework/1.1.14)
* MSTest.TestAdapter: [1.1.14](https://www.nuget.org/packages/MSTest.TestAdapter/1.1.14)

## [1.1.13] - 2017-03-10

This is also the first release from GitHub and with source code building against Dev15 tooling.

### Changed

* [Tests with Deployment Item do not run](https://github.com/Microsoft/testfx/issues/91)
* [Run tests fail intermittently with a disconnected from server exception](https://github.com/Microsoft/testfx/issues/28)
* [Templates and Wizards vsix should be built with RC3 tooling](https://github.com/Microsoft/testfx/issues/77)

### Artifacts

* MSTest.TestFramework: [1.1.13](https://www.nuget.org/packages/MSTest.TestFramework/1.1.13)
* MSTest.TestAdapter: [1.1.13](https://www.nuget.org/packages/MSTest.TestAdapter/1.1.13)

## [1.1.11] - 2017-02-17

Initial release.

### Artifacts

* MSTest.TestFramework: [1.1.11](https://www.nuget.org/packages/MSTest.TestFramework/1.1.11)
* MSTest.TestAdapter: [1.1.11](https://www.nuget.org/packages/MSTest.TestAdapter/1.1.11)
