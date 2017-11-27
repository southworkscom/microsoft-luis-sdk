// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Apps.
    /// </summary>
    public static partial class AppsExtensions
    {
            /// <summary>
            /// Creates a new LUIS app.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='applicationCreateObject'>
            /// A JSON object containing Name, Description (optional), Culture, Usage
            /// Scenario (optional), Domain (optional) and initial version ID (optional) of
            /// the application.
            /// Default value for the version ID is 0.1.
            /// Note that the culture cannot be changed after the app is created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> AddApplicationAsync(this IApps operations, AzureRegions azureRegion, ApplicationCreateObject applicationCreateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddApplicationWithHttpMessagesAsync(azureRegion, applicationCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the user applications.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ApplicationInfoResponse>> GetApplicationsListAsync(this IApps operations, AzureRegions azureRegion, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationsListWithHttpMessagesAsync(azureRegion, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports an application to LUIS, the application's JSON should be included
            /// in in the request body.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appName'>
            /// The imported application name.
            /// </param>
            /// <param name='jSONApp'>
            /// A JSON representing the LUIS application structure.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ImportApplicationAsync(this IApps operations, AzureRegions azureRegion, string appName = default(string), JSONApp jSONApp = default(JSONApp), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportApplicationWithHttpMessagesAsync(azureRegion, appName, jSONApp, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the endpoint URLs for the prebuilt Cortana applications.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersonalAssistantsResponse> GetPersonalAssistantApplicationsAsync(this IApps operations, AzureRegions azureRegion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPersonalAssistantApplicationsWithHttpMessagesAsync(azureRegion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the available application domains.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetApplicationDomainsAsync(this IApps operations, AzureRegions azureRegion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationDomainsWithHttpMessagesAsync(azureRegion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the application available usage scenarios.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetApplicationUsageScenariosAsync(this IApps operations, AzureRegions azureRegion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationUsageScenariosWithHttpMessagesAsync(azureRegion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the supported application cultures.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AvailableCulture>> GetApplicationCulturesAsync(this IApps operations, AzureRegions azureRegion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationCulturesWithHttpMessagesAsync(azureRegion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the query logs of the past month for the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> DownloadApplicationQueryLogsAsync(this IApps operations, AzureRegions azureRegion, string appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.DownloadApplicationQueryLogsWithHttpMessagesAsync(azureRegion, appId, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Gets the application info.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInfoResponse> GetApplicationInfoAsync(this IApps operations, AzureRegions azureRegion, string appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationInfoWithHttpMessagesAsync(azureRegion, appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the name or description of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='applicationUpdateObject'>
            /// A JSON object containing Name and Description of the application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RenameApplicationAsync(this IApps operations, AzureRegions azureRegion, string appId, ApplicationUpdateObject applicationUpdateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RenameApplicationWithHttpMessagesAsync(azureRegion, appId, applicationUpdateObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteApplicationAsync(this IApps operations, AzureRegions azureRegion, string appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteApplicationWithHttpMessagesAsync(azureRegion, appId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Publishes a specific version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='applicationPublishObject'>
            /// The application publish object.The region is the target region that the
            /// application is published to. Possible values are "westus", "eastus2",
            /// "westcentralus" or "southeastasia" for applications created in west US, and
            /// "westeurope" for applications created in West Europe.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationPublishResponse> PublishApplicationAsync(this IApps operations, AzureRegions azureRegion, string appId, ApplicationPublishObject applicationPublishObject = default(ApplicationPublishObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PublishApplicationWithHttpMessagesAsync(azureRegion, appId, applicationPublishObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the application settings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationSettings> GetApplicationSettingsAsync(this IApps operations, AzureRegions azureRegion, string appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationSettingsWithHttpMessagesAsync(azureRegion, appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the application settings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='applicationSettingUpdateObject'>
            /// An app setting object contains the new app settings
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateApplicationSettingsAsync(this IApps operations, AzureRegions azureRegion, string appId, ApplicationSettingUpdateObject applicationSettingUpdateObject = default(ApplicationSettingUpdateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateApplicationSettingsWithHttpMessagesAsync(azureRegion, appId, applicationSettingUpdateObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the available endpoint deployment regions and urls
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='appId'>
            /// Format - guid. The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableEndpoints> GetEndpointsAsync(this IApps operations, AzureRegions azureRegion, string appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEndpointsWithHttpMessagesAsync(azureRegion, appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the available custom prebuilt domains for all cultures
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PrebuiltDomain>> GetAvailableCustomPrebuiltDomainsAsync(this IApps operations, AzureRegions azureRegion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableCustomPrebuiltDomainsWithHttpMessagesAsync(azureRegion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a prebuilt domain along with its models as a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='prebuiltDomainCreateObject'>
            /// A prebuilt domain create object containing the name and culture of the
            /// domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> AddCustomPrebuiltApplicationAsync(this IApps operations, AzureRegions azureRegion, PrebuiltDomainCreateObject prebuiltDomainCreateObject = default(PrebuiltDomainCreateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddCustomPrebuiltApplicationWithHttpMessagesAsync(azureRegion, prebuiltDomainCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the available custom prebuilt domains for a specific culture
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope'
            /// </param>
            /// <param name='culture'>
            /// Format - string. Culture
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PrebuiltDomain>> GetAvailableCustomPrebuiltDomainsForCultureAsync(this IApps operations, AzureRegions azureRegion, string culture, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableCustomPrebuiltDomainsForCultureWithHttpMessagesAsync(azureRegion, culture, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
