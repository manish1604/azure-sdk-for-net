// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.RecoveryServices;
using Microsoft.WindowsAzure.Management.RecoveryServices.Models;

namespace Microsoft.WindowsAzure.Management.RecoveryServices
{
    /// <summary>
    /// Definition of cloud service operations for the Recovery services
    /// extension.
    /// </summary>
    internal partial class CloudServiceOperations : IServiceOperations<RecoveryServicesManagementClient>, ICloudServiceOperations
    {
        /// <summary>
        /// Initializes a new instance of the CloudServiceOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal CloudServiceOperations(RecoveryServicesManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.RecoveryServicesManagementClient.
        /// </summary>
        public RecoveryServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Creates a Cloud services
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required. The cloud service name.
        /// </param>
        /// <param name='cloudService'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<AzureOperationResponse> BeginCreatingAsync(string cloudServiceName, CloudServiceCreateArgs cloudService, CancellationToken cancellationToken)
        {
            // Validate
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (cloudServiceName.Length > 100)
            {
                throw new ArgumentOutOfRangeException("cloudServiceName");
            }
            if (cloudService == null)
            {
                throw new ArgumentNullException("cloudService");
            }
            if (cloudService.Description == null)
            {
                throw new ArgumentNullException("cloudService.Description");
            }
            if (cloudService.Description.Length > 1024)
            {
                throw new ArgumentOutOfRangeException("cloudService.Description");
            }
            if (cloudService.GeoRegion == null)
            {
                throw new ArgumentNullException("cloudService.GeoRegion");
            }
            if (cloudService.Label == null)
            {
                throw new ArgumentNullException("cloudService.Label");
            }
            if (cloudService.Label.Length > 100)
            {
                throw new ArgumentOutOfRangeException("cloudService.Label");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cloudServiceName", cloudServiceName);
                tracingParameters.Add("cloudService", cloudService);
                TracingAdapter.Enter(invocationId, this, "BeginCreatingAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/cloudservices/";
            url = url + Uri.EscapeDataString(cloudServiceName);
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement cloudServiceElement = new XElement(XName.Get("CloudService", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(cloudServiceElement);
                
                XElement labelElement = new XElement(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                labelElement.Value = cloudService.Label;
                cloudServiceElement.Add(labelElement);
                
                XElement descriptionElement = new XElement(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                descriptionElement.Value = cloudService.Description;
                cloudServiceElement.Add(descriptionElement);
                
                XElement geoRegionElement = new XElement(XName.Get("GeoRegion", "http://schemas.microsoft.com/windowsazure"));
                geoRegionElement.Value = cloudService.GeoRegion;
                cloudServiceElement.Add(geoRegionElement);
                
                if (cloudService.Email != null)
                {
                    XElement emailElement = new XElement(XName.Get("Email", "http://schemas.microsoft.com/windowsazure"));
                    emailElement.Value = cloudService.Email;
                    cloudServiceElement.Add(emailElement);
                }
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AzureOperationResponse result = null;
                    // Deserialize Response
                    result = new AzureOperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required. The cloud service name.
        /// </param>
        /// <param name='cloudService'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<RecoveryServicesOperationStatusResponse> CreateAsync(string cloudServiceName, CloudServiceCreateArgs cloudService, CancellationToken cancellationToken)
        {
            RecoveryServicesManagementClient client = this.Client;
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cloudServiceName", cloudServiceName);
                tracingParameters.Add("cloudService", cloudService);
                TracingAdapter.Enter(invocationId, this, "CreateAsync", tracingParameters);
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            AzureOperationResponse response = await client.CloudServices.BeginCreatingAsync(cloudServiceName, cloudService, cancellationToken).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested();
            RecoveryServicesOperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
            int delayInSeconds = 10;
            if (client.LongRunningOperationInitialTimeout >= 0)
            {
                delayInSeconds = client.LongRunningOperationInitialTimeout;
            }
            while ((result.Status != RecoveryServicesOperationStatus.InProgress) == false)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                delayInSeconds = 5;
                if (client.LongRunningOperationRetryTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationRetryTimeout;
                }
            }
            
            if (shouldTrace)
            {
                TracingAdapter.Exit(invocationId, result);
            }
            
            if (result.Status != RecoveryServicesOperationStatus.Succeeded)
            {
                if (result.Error != null)
                {
                    CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                    ex.Error = new CloudError();
                    ex.Error.Code = result.Error.Code;
                    ex.Error.Message = result.Error.Message;
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
                else
                {
                    CloudException ex = new CloudException("");
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
            }
            
            return result;
        }
        
        /// <summary>
        /// Retrieve a list of Cloud services
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list cloud service operation.
        /// </returns>
        public async Task<CloudServiceListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/cloudservices";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-04-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    CloudServiceListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new CloudServiceListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement cloudServicesSequenceElement = responseDoc.Element(XName.Get("CloudServices", "http://schemas.microsoft.com/windowsazure"));
                        if (cloudServicesSequenceElement != null)
                        {
                            foreach (XElement cloudServicesElement in cloudServicesSequenceElement.Elements(XName.Get("CloudService", "http://schemas.microsoft.com/windowsazure")))
                            {
                                CloudService cloudServiceInstance = new CloudService();
                                result.CloudServices.Add(cloudServiceInstance);
                                
                                XElement descriptionElement = cloudServicesElement.Element(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                                if (descriptionElement != null)
                                {
                                    string descriptionInstance = descriptionElement.Value;
                                    cloudServiceInstance.Description = descriptionInstance;
                                }
                                
                                XElement geoRegionElement = cloudServicesElement.Element(XName.Get("GeoRegion", "http://schemas.microsoft.com/windowsazure"));
                                if (geoRegionElement != null)
                                {
                                    string geoRegionInstance = geoRegionElement.Value;
                                    cloudServiceInstance.GeoRegion = geoRegionInstance;
                                }
                                
                                XElement labelElement = cloudServicesElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                                if (labelElement != null)
                                {
                                    string labelInstance = labelElement.Value;
                                    cloudServiceInstance.Label = labelInstance;
                                }
                                
                                XElement nameElement = cloudServicesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement != null)
                                {
                                    string nameInstance = nameElement.Value;
                                    cloudServiceInstance.Name = nameInstance;
                                }
                                
                                XElement resourcesSequenceElement = cloudServicesElement.Element(XName.Get("Resources", "http://schemas.microsoft.com/windowsazure"));
                                if (resourcesSequenceElement != null)
                                {
                                    foreach (XElement resourcesElement in resourcesSequenceElement.Elements(XName.Get("Resource", "http://schemas.microsoft.com/windowsazure")))
                                    {
                                        Vault resourceInstance = new Vault();
                                        cloudServiceInstance.Resources.Add(resourceInstance);
                                        
                                        XElement resourceProviderNamespaceElement = resourcesElement.Element(XName.Get("ResourceProviderNamespace", "http://schemas.microsoft.com/windowsazure"));
                                        if (resourceProviderNamespaceElement != null)
                                        {
                                            string resourceProviderNamespaceInstance = resourceProviderNamespaceElement.Value;
                                            resourceInstance.ResourceProviderNamespace = resourceProviderNamespaceInstance;
                                        }
                                        
                                        XElement eTagElement = resourcesElement.Element(XName.Get("ETag", "http://schemas.microsoft.com/windowsazure"));
                                        if (eTagElement != null)
                                        {
                                            string eTagInstance = eTagElement.Value;
                                            resourceInstance.ETag = eTagInstance;
                                        }
                                        
                                        XElement labelElement2 = resourcesElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                                        if (labelElement2 != null)
                                        {
                                            string labelInstance2 = labelElement2.Value;
                                            resourceInstance.Label = labelInstance2;
                                        }
                                        
                                        XElement nameElement2 = resourcesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                        if (nameElement2 != null)
                                        {
                                            string nameInstance2 = nameElement2.Value;
                                            resourceInstance.Name = nameInstance2;
                                        }
                                        
                                        XElement operationStatusElement = resourcesElement.Element(XName.Get("OperationStatus", "http://schemas.microsoft.com/windowsazure"));
                                        if (operationStatusElement != null)
                                        {
                                            ResourceOperationStatus operationStatusInstance = new ResourceOperationStatus();
                                            resourceInstance.OperationStatus = operationStatusInstance;
                                            
                                            XElement resultElement = operationStatusElement.Element(XName.Get("Result", "http://schemas.microsoft.com/windowsazure"));
                                            if (resultElement != null)
                                            {
                                                string resultInstance = resultElement.Value;
                                                operationStatusInstance.Result = resultInstance;
                                            }
                                            
                                            XElement typeElement = operationStatusElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                            if (typeElement != null)
                                            {
                                                string typeInstance = typeElement.Value;
                                                operationStatusInstance.Type = typeInstance;
                                            }
                                            
                                            XElement errorElement = operationStatusElement.Element(XName.Get("Error", "http://schemas.microsoft.com/windowsazure"));
                                            if (errorElement != null)
                                            {
                                                ResourceErrorInfo errorInstance = new ResourceErrorInfo();
                                                operationStatusInstance.Error = errorInstance;
                                                
                                                XElement extendedCodeElement = errorElement.Element(XName.Get("ExtendedCode", "http://schemas.microsoft.com/windowsazure"));
                                                if (extendedCodeElement != null)
                                                {
                                                    string extendedCodeInstance = extendedCodeElement.Value;
                                                    errorInstance.ExtendedCode = extendedCodeInstance;
                                                }
                                                
                                                XElement httpCodeElement = errorElement.Element(XName.Get("HttpCode", "http://schemas.microsoft.com/windowsazure"));
                                                if (httpCodeElement != null)
                                                {
                                                    int httpCodeInstance = int.Parse(httpCodeElement.Value, CultureInfo.InvariantCulture);
                                                    errorInstance.HttpCode = httpCodeInstance;
                                                }
                                                
                                                XElement messageElement = errorElement.Element(XName.Get("Message", "http://schemas.microsoft.com/windowsazure"));
                                                if (messageElement != null)
                                                {
                                                    string messageInstance = messageElement.Value;
                                                    errorInstance.Message = messageInstance;
                                                }
                                            }
                                        }
                                        
                                        XElement outputItemsSequenceElement = resourcesElement.Element(XName.Get("OutputItems", "http://schemas.microsoft.com/windowsazure"));
                                        if (outputItemsSequenceElement != null)
                                        {
                                            foreach (XElement outputItemsElement in outputItemsSequenceElement.Elements(XName.Get("OutputItem", "http://schemas.microsoft.com/windowsazure")))
                                            {
                                                OutputItem outputItemInstance = new OutputItem();
                                                resourceInstance.OutputItems.Add(outputItemInstance);
                                                
                                                XElement keyElement = outputItemsElement.Element(XName.Get("Key", "http://schemas.microsoft.com/windowsazure"));
                                                if (keyElement != null)
                                                {
                                                    string keyInstance = keyElement.Value;
                                                    outputItemInstance.Key = keyInstance;
                                                }
                                                
                                                XElement valueElement = outputItemsElement.Element(XName.Get("Value", "http://schemas.microsoft.com/windowsazure"));
                                                if (valueElement != null)
                                                {
                                                    string valueInstance = valueElement.Value;
                                                    outputItemInstance.Value = valueInstance;
                                                }
                                            }
                                        }
                                        
                                        XElement planElement = resourcesElement.Element(XName.Get("Plan", "http://schemas.microsoft.com/windowsazure"));
                                        if (planElement != null)
                                        {
                                            string planInstance = planElement.Value;
                                            resourceInstance.Plan = planInstance;
                                        }
                                        
                                        XElement schemaVersionElement = resourcesElement.Element(XName.Get("SchemaVersion", "http://schemas.microsoft.com/windowsazure"));
                                        if (schemaVersionElement != null)
                                        {
                                            string schemaVersionInstance = schemaVersionElement.Value;
                                            resourceInstance.SchemaVersion = schemaVersionInstance;
                                        }
                                        
                                        XElement stateElement = resourcesElement.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                                        if (stateElement != null)
                                        {
                                            string stateInstance = stateElement.Value;
                                            resourceInstance.State = stateInstance;
                                        }
                                        
                                        XElement subStateElement = resourcesElement.Element(XName.Get("SubState", "http://schemas.microsoft.com/windowsazure"));
                                        if (subStateElement != null)
                                        {
                                            string subStateInstance = subStateElement.Value;
                                            resourceInstance.SubState = subStateInstance;
                                        }
                                        
                                        XElement typeElement2 = resourcesElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                        if (typeElement2 != null)
                                        {
                                            string typeInstance2 = typeElement2.Value;
                                            resourceInstance.Type = typeInstance2;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
