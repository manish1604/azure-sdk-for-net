// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class WorkflowsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of workflows by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<Workflow> ListBySubscription(this IWorkflowsOperations operations, int? top = default(int?), Expression<Func<WorkflowFilter, bool>> filter = default(Expression<Func<WorkflowFilter, bool>>))
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).ListBySubscriptionAsync(top, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflows by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Workflow>> ListBySubscriptionAsync( this IWorkflowsOperations operations, int? top = default(int?), Expression<Func<WorkflowFilter, bool>> filter = default(Expression<Func<WorkflowFilter, bool>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Workflow>> result = await operations.ListBySubscriptionWithHttpMessagesAsync(top, filter, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of workflows by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<Workflow> ListByResourceGroup(this IWorkflowsOperations operations, string resourceGroupName, int? top = default(int?), Expression<Func<WorkflowFilter, bool>> filter = default(Expression<Func<WorkflowFilter, bool>>))
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).ListByResourceGroupAsync(resourceGroupName, top, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflows by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Workflow>> ListByResourceGroupAsync( this IWorkflowsOperations operations, string resourceGroupName, int? top = default(int?), Expression<Func<WorkflowFilter, bool>> filter = default(Expression<Func<WorkflowFilter, bool>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Workflow>> result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, filter, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            public static Workflow Get(this IWorkflowsOperations operations, string resourceGroupName, string workflowName)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).GetAsync(resourceGroupName, workflowName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workflow> GetAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Workflow> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates or updates a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='workflow'>
            /// The workflow.
            /// </param>
            public static Workflow CreateOrUpdate(this IWorkflowsOperations operations, string resourceGroupName, string workflowName, Workflow workflow)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).CreateOrUpdateAsync(resourceGroupName, workflowName, workflow), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='workflow'>
            /// The workflow.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workflow> CreateOrUpdateAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, Workflow workflow, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Workflow> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workflowName, workflow, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Updates a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='workflow'>
            /// The workflow.
            /// </param>
            public static Workflow Update(this IWorkflowsOperations operations, string resourceGroupName, string workflowName, Workflow workflow)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).UpdateAsync(resourceGroupName, workflowName, workflow), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='workflow'>
            /// The workflow.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workflow> UpdateAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, Workflow workflow, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Workflow> result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workflowName, workflow, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            public static void Delete(this IWorkflowsOperations operations, string resourceGroupName, string workflowName)
            {
                Task.Factory.StartNew(s => ((IWorkflowsOperations)s).DeleteAsync(resourceGroupName, workflowName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workflowName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Runs a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters.
            /// </param>
            public static WorkflowRun Run(this IWorkflowsOperations operations, string resourceGroupName, string workflowName, RunWorkflowParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).RunAsync(resourceGroupName, workflowName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Runs a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowRun> RunAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, RunWorkflowParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowRun> result = await operations.RunWithHttpMessagesAsync(resourceGroupName, workflowName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Runs a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters.
            /// </param>
            public static WorkflowRun BeginRun(this IWorkflowsOperations operations, string resourceGroupName, string workflowName, RunWorkflowParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).BeginRunAsync(resourceGroupName, workflowName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Runs a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowRun> BeginRunAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, RunWorkflowParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowRun> result = await operations.BeginRunWithHttpMessagesAsync(resourceGroupName, workflowName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Disables a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            public static void Disable(this IWorkflowsOperations operations, string resourceGroupName, string workflowName)
            {
                Task.Factory.StartNew(s => ((IWorkflowsOperations)s).DisableAsync(resourceGroupName, workflowName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DisableWithHttpMessagesAsync(resourceGroupName, workflowName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Enables a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            public static void Enable(this IWorkflowsOperations operations, string resourceGroupName, string workflowName)
            {
                Task.Factory.StartNew(s => ((IWorkflowsOperations)s).EnableAsync(resourceGroupName, workflowName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.EnableWithHttpMessagesAsync(resourceGroupName, workflowName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Validates a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='workflow'>
            /// The workflow.
            /// </param>
            public static void Validate(this IWorkflowsOperations operations, string resourceGroupName, string workflowName, Workflow workflow)
            {
                Task.Factory.StartNew(s => ((IWorkflowsOperations)s).ValidateAsync(resourceGroupName, workflowName, workflow), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates a workflow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='workflow'>
            /// The workflow.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ValidateAsync( this IWorkflowsOperations operations, string resourceGroupName, string workflowName, Workflow workflow, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ValidateWithHttpMessagesAsync(resourceGroupName, workflowName, workflow, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a list of workflows by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Workflow> ListBySubscriptionNext(this IWorkflowsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).ListBySubscriptionNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflows by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Workflow>> ListBySubscriptionNextAsync( this IWorkflowsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Workflow>> result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of workflows by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Workflow> ListByResourceGroupNext(this IWorkflowsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IWorkflowsOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflows by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Workflow>> ListByResourceGroupNextAsync( this IWorkflowsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Workflow>> result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
