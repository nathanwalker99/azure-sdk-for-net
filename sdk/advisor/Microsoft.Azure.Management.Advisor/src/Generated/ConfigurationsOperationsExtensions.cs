// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Advisor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConfigurationsOperations.
    /// </summary>
    public static partial class ConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Retrieve Azure Advisor configurations.
            /// </summary>
            /// <remarks>
            /// Retrieve Azure Advisor configurations and also retrieve configurations of
            /// contained resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ConfigData> ListBySubscription(this IConfigurationsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve Azure Advisor configurations.
            /// </summary>
            /// <remarks>
            /// Retrieve Azure Advisor configurations and also retrieve configurations of
            /// contained resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConfigData>> ListBySubscriptionAsync(this IConfigurationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create/Overwrite Azure Advisor configuration.
            /// </summary>
            /// <remarks>
            /// Create/Overwrite Azure Advisor configuration and also delete all
            /// configurations of contained resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='configContract'>
            /// The Azure Advisor configuration data structure.
            /// </param>
            public static ARMErrorResponseBody CreateInSubscription(this IConfigurationsOperations operations, ConfigData configContract)
            {
                return operations.CreateInSubscriptionAsync(configContract).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create/Overwrite Azure Advisor configuration.
            /// </summary>
            /// <remarks>
            /// Create/Overwrite Azure Advisor configuration and also delete all
            /// configurations of contained resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='configContract'>
            /// The Azure Advisor configuration data structure.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ARMErrorResponseBody> CreateInSubscriptionAsync(this IConfigurationsOperations operations, ConfigData configContract, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateInSubscriptionWithHttpMessagesAsync(configContract, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve Azure Advisor configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the Azure resource group.
            /// </param>
            public static IEnumerable<ConfigData> ListByResourceGroup(this IConfigurationsOperations operations, string resourceGroup)
            {
                return operations.ListByResourceGroupAsync(resourceGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve Azure Advisor configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ConfigData>> ListByResourceGroupAsync(this IConfigurationsOperations operations, string resourceGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create/Overwrite Azure Advisor configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='configContract'>
            /// The Azure Advisor configuration data structure.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the Azure resource group.
            /// </param>
            public static ARMErrorResponseBody CreateInResourceGroup(this IConfigurationsOperations operations, ConfigData configContract, string resourceGroup)
            {
                return operations.CreateInResourceGroupAsync(configContract, resourceGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create/Overwrite Azure Advisor configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='configContract'>
            /// The Azure Advisor configuration data structure.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ARMErrorResponseBody> CreateInResourceGroupAsync(this IConfigurationsOperations operations, ConfigData configContract, string resourceGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateInResourceGroupWithHttpMessagesAsync(configContract, resourceGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve Azure Advisor configurations.
            /// </summary>
            /// <remarks>
            /// Retrieve Azure Advisor configurations and also retrieve configurations of
            /// contained resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConfigData> ListBySubscriptionNext(this IConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve Azure Advisor configurations.
            /// </summary>
            /// <remarks>
            /// Retrieve Azure Advisor configurations and also retrieve configurations of
            /// contained resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConfigData>> ListBySubscriptionNextAsync(this IConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
