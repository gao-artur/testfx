// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface;
    using Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Utilities;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

    /// <summary>
    /// A host that loads the test source.This can be in isolation for desktop using an AppDomain or just loading the source in the current context.
    /// </summary>
    public class TestSourceHost : ITestSourceHost
    {
        /// <summary>
        /// AppDomain used to discover tests
        /// </summary>
        private AppDomain appDomain;

        /// <summary>
        /// Assembly resolver used in the app-domain
        /// </summary>
        private AssemblyResolver assemblyResolver;

        private List<string> cachedResolutionPaths;

        private string sourceFileName;
        private IRunSettings runSettings;
        
        private string currentDirectory = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSourceHost"/> class.
        /// </summary>
        /// <param name="sourceFileName"> The source file name. </param>
        /// <param name="runSettings"> The run-settings provided for this session. </param>
        public TestSourceHost(string sourceFileName, IRunSettings runSettings)
        {
            this.sourceFileName = sourceFileName;
            this.runSettings = runSettings;

            // Set the environment context.
            this.SetContext(sourceFileName);
        }

        /// <summary>
        /// Creates an instance of a given type in the test source host.
        /// </summary>
        /// <param name="type"> The type that needs to be created in the host. </param>
        /// <param name="args">The arguments to pass to the constructor. 
        /// This array of arguments must match in number, order, and type the parameters of the constructor to invoke. 
        /// Pass in null for a constructor with no arguments.
        /// </param>
        /// <returns> An instance of the type created in the host. </returns>
        /// <remarks> If a type is to be created in isolation then it needs to be a MarshalByRefObject. </remarks>
        public object CreateInstanceForType(Type type, object[] args)
        {
            List<string> resolutionPaths = this.GetResolutionPaths(this.sourceFileName, VSInstallationUtilities.IsCurrentProcessRunningInPortableMode());

            // Check if user specified any runsettings
            MSTestAdapterSettings adapterSettings = MSTestSettingsProvider.Settings;

            if (resolutionPaths != null && resolutionPaths.Count > 0)
            {
                if (EqtTrace.IsInfoEnabled)
                {
                    EqtTrace.Info("TestSourceHost: Creating assembly resolver with resolution paths {0}.", string.Join(",", resolutionPaths.ToArray()));
                }

                // Adding adapter folder to resolution paths
                if (!resolutionPaths.Contains(Path.GetDirectoryName(typeof(TestSourceHost).Assembly.Location)))
                {
                    resolutionPaths.Add(Path.GetDirectoryName(typeof(TestSourceHost).Assembly.Location));
                }

                // Adding extensions folder to resolution paths
                if (!resolutionPaths.Contains(Path.GetDirectoryName(typeof(AssemblyHelper).Assembly.Location)))
                {
                    resolutionPaths.Add(Path.GetDirectoryName(typeof(AssemblyHelper).Assembly.Location));
                }
            }

            //Honour DisableAppDomain setting if it is present in runsettings
            if (this.runSettings!=null && MSTestAdapterSettings.IsAppDomainCreationDisabled(this.runSettings.SettingsXml))
            {
                if (adapterSettings != null)
                {
                    try
                    {
                        this.assemblyResolver = new AssemblyResolver(resolutionPaths);
                        this.assemblyResolver.AddSearchDirectoriesFromRunSetting(adapterSettings.GetDirectoryListWithRecursiveProperty(null));
                    }
                    catch (Exception exception)
                    {
                        if(EqtTrace.IsErrorEnabled)
                        {
                            EqtTrace.Error(exception);
                        }
                    }
                }
                return Activator.CreateInstance(type, args);
            }

            var appDomainSetup = new AppDomainSetup();

            // The below logic of preferential setting the appdomains appbase is needed because:
            // 1. We set this to the location of the test source if it is built for Full CLR  -> Ideally this needs to be done in all situations.
            // 2. We set this to the location where the current adapter is being picked up from for UWP and .Net Core scenarios -> This needs to be 
            //    different especially for UWP because we use the desktop adapter(from %temp%\VisualStudioTestExplorerExtensions) itself for test discovery
            //    in IDE scenarios. If the app base is set to the test source location, discovery will not work because we drop the 
            //    UWP platform service assembly at the test source location and since CLR starts looking for assemblies from the app base location,
            //    there would be a mismatch of platform service assemblies during discovery. 
            var frameworkVersionString = this.GetTargetFrameworkVersionString(this.sourceFileName);
            if (frameworkVersionString.Contains(PlatformServices.Constants.DotNetFrameWorkStringPrefix))
            {
                appDomainSetup.ApplicationBase = Path.GetDirectoryName(this.sourceFileName)
                                                 ?? Path.GetDirectoryName(typeof(TestSourceHost).Assembly.Location);
            }
            else
            {
                appDomainSetup.ApplicationBase = Path.GetDirectoryName(typeof(TestSourceHost).Assembly.Location);
            }
            
            if (EqtTrace.IsInfoEnabled)
            {
                EqtTrace.Info("TestSourceHost: Creating app-domain for source {0} with application base path {1}.", this.sourceFileName, appDomainSetup.ApplicationBase);
            }

            AppDomainUtilities.SetAppDomainFrameworkVersionBasedOnTestSource(appDomainSetup, frameworkVersionString);
            
            var configFile = this.GetConfigFileForTestSource(this.sourceFileName);
            AppDomainUtilities.SetConfigurationFile(appDomainSetup, configFile);

            this.appDomain = AppDomain.CreateDomain("TestSourceHost: Enumering assembly", null, appDomainSetup);

            // #824545 Load objectModel before creating assembly resolver otherwise in 3.5 process, we run into a recurive assembly resolution
            // which is trigged by AppContainerUtilities.AttachEventToResolveWinmd method. 
            EqtTrace.SetupRemoteEqtTraceListeners(this.appDomain);

            // Add an assembly resolver...
            Type assemblyResolverType = typeof(AssemblyResolver);

            if (EqtTrace.IsInfoEnabled)
            {
                EqtTrace.Info("TestSourceHost: assemblyenumerator location: {0} , fullname: {1} ", assemblyResolverType.Assembly.Location, assemblyResolverType.FullName);
            }

            var resolver = AppDomainUtilities.CreateInstance(
                this.appDomain,
                assemblyResolverType,
                new object[] { resolutionPaths });

            if (EqtTrace.IsInfoEnabled)
            {
                EqtTrace.Info(
                    "TestSourceHost: resolver type: {0} , resolve type assembly: {1} ",
                    resolver.GetType().FullName,
                    resolver.GetType().Assembly.Location);
            }

            this.assemblyResolver = (AssemblyResolver)resolver;

            if (adapterSettings != null)
            {
                try
                {
                    var additionalSearchDirectories =
                        adapterSettings.GetDirectoryListWithRecursiveProperty(appDomainSetup.ApplicationBase);
                    if (additionalSearchDirectories?.Count > 0)
                    {
                        this.assemblyResolver.AddSearchDirectoriesFromRunSetting(
                            adapterSettings.GetDirectoryListWithRecursiveProperty(appDomainSetup.ApplicationBase));
                    }
                }
                catch (Exception exception)
                {
                    if (EqtTrace.IsErrorEnabled)
                    {
                        EqtTrace.Error(exception);
                    }
                }
            }
            
            var enumerator = AppDomainUtilities.CreateInstance(
                this.appDomain,
                type,
                args);

            return enumerator;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.assemblyResolver != null)
            {
                this.assemblyResolver.Dispose();
                this.assemblyResolver = null;
            }

            if (this.appDomain != null)
            {
                AppDomain.Unload(this.appDomain);
                this.appDomain = null;
            }

            this.ResetContext();

            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Gets the probing paths to load the test assembly dependencies.
        /// </summary>
        /// <param name="sourceFileName">
        /// The source File Name.
        /// </param>
        /// <param name="isPortableMode">
        /// True if running in portable mode else false.
        /// </param>
        /// <returns>
        /// A list of path.
        /// </returns>
        internal List<string> GetResolutionPaths(string sourceFileName, bool isPortableMode)
        {
            if (this.cachedResolutionPaths == null || this.cachedResolutionPaths.Count <= 0)
            {
                this.cachedResolutionPaths = new List<string>();

                // Add path of test assembly in resolution path. Mostly will be used for resovling winmd.
                this.cachedResolutionPaths.Add(Path.GetDirectoryName(sourceFileName));

                if (!isPortableMode)
                {
                    if (EqtTrace.IsInfoEnabled)
                    {
                        EqtTrace.Info("TestSourceHost: Not running in portable mode");
                    }

                    string pathToPublicAssemblies = VSInstallationUtilities.PathToPublicAssemblies;
                    if (!StringUtilities.IsNullOrWhiteSpace(pathToPublicAssemblies))
                    {
                        this.cachedResolutionPaths.Add(pathToPublicAssemblies);
                    }

                    string pathToPrivateAssemblies = VSInstallationUtilities.PathToPrivateAssemblies;
                    if (!StringUtilities.IsNullOrWhiteSpace(pathToPrivateAssemblies))
                    {
                        this.cachedResolutionPaths.Add(pathToPrivateAssemblies);
                    }
                }
            }

            return this.cachedResolutionPaths;
        }
        
        internal virtual string GetTargetFrameworkVersionString(string sourceFileName)
        {
            return AppDomainUtilities.GetTargetFrameworkVersionString(sourceFileName);
        }

        private string GetConfigFileForTestSource(string sourceFileName)
        {
            return new DeploymentUtility().GetConfigFile(sourceFileName);
        }
        
        /// <summary>
        /// Sets context required for running tests.
        /// </summary>
        /// <param name="source">
        /// source parameter used for setting context
        /// </param>
        /// <returns>
        /// Returns false if context cannot be set. True otherwise.
        /// </returns>
        private void SetContext(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return;
            }

            Exception setWorkingDirectoryException = null;
            this.currentDirectory = Environment.CurrentDirectory;

            try
            {
                Environment.CurrentDirectory = Path.GetDirectoryName(source);
                EqtTrace.InfoIf(EqtTrace.IsInfoEnabled, "MSTestExecutor: Changed the working directory to {0}", Environment.CurrentDirectory);
            }
            catch (IOException ex)
            {
                setWorkingDirectoryException = ex;
            }
            catch (System.Security.SecurityException ex)
            {
                setWorkingDirectoryException = ex;
            }

            if (setWorkingDirectoryException != null)
            {
                EqtTrace.ErrorIf(EqtTrace.IsErrorEnabled, "MSTestExecutor.SetWorkingDirectory: Failed to set the working directory to '{0}'. {1}", Path.GetDirectoryName(source), setWorkingDirectoryException);
            }
        }

        /// <summary>
        /// Resets the context as it was before calling SetContext()
        /// </summary>
        private void ResetContext()
        {
            if (!string.IsNullOrEmpty(this.currentDirectory))
            {
                Environment.CurrentDirectory = this.currentDirectory;
            }
        }
    }
}
