﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:33:06
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the appengine v1beta5 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Provisions and manages App Engine applications.
// API Documentation Link https://cloud.google.com/appengine/docs/admin-api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/appengine/v1beta5/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.appengine.v1beta5/ 
// Install Command: PM>  Install-Package Google.Apis.appengine.v1beta5
//
//------------------------------------------------------------------------------  
using Google.Apis.appengine.v1beta5;
using Google.Apis.appengine.v1beta5.Data;
using System;

namespace GoogleSamplecSharpSample.appenginev1beta5.Methods
{
  
    public static class InstancesSample
    {


        /// <summary>
        /// Stops a running instance. 
        /// Documentation https://developers.google.com/appengine/v1beta5/reference/instances/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated appengine service.</param>  
        /// <param name="appsId">Part of `name`. Name of the resource requested. For example: "apps/myapp/services/default/versions/v1/instances/instance-1".</param>
        /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="instancesId">Part of `name`. See documentation of `appsId`.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(appengineService service, string appsId, string servicesId, string versionsId, string instancesId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (appsId == null)
                    throw new ArgumentNullException(appsId);
                if (servicesId == null)
                    throw new ArgumentNullException(servicesId);
                if (versionsId == null)
                    throw new ArgumentNullException(versionsId);
                if (instancesId == null)
                    throw new ArgumentNullException(instancesId);

                // Make the request.
                return service.Instances.Delete(appsId, servicesId, versionsId, instancesId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Gets instance information. 
        /// Documentation https://developers.google.com/appengine/v1beta5/reference/instances/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated appengine service.</param>  
        /// <param name="appsId">Part of `name`. Name of the resource requested. Example: apps/myapp/services/default/versions/v1/instances/instance-1.</param>
        /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="instancesId">Part of `name`. See documentation of `appsId`.</param>
        /// <returns>InstanceResponse</returns>
        public static Instance Get(appengineService service, string appsId, string servicesId, string versionsId, string instancesId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (appsId == null)
                    throw new ArgumentNullException(appsId);
                if (servicesId == null)
                    throw new ArgumentNullException(servicesId);
                if (versionsId == null)
                    throw new ArgumentNullException(versionsId);
                if (instancesId == null)
                    throw new ArgumentNullException(instancesId);

                // Make the request.
                return service.Instances.Get(appsId, servicesId, versionsId, instancesId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Get failed.", ex);
            }
        }

        public class InstancesListOptionalParms
        {
            /// Maximum results to return per page.
            public int PageSize { get; set; }  
            /// Continuation token for fetching the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the instances of a version. 
        /// Documentation https://developers.google.com/appengine/v1beta5/reference/instances/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated appengine service.</param>  
        /// <param name="appsId">Part of `name`. Name of the resource requested. Example: apps/myapp/services/default/versions/v1.</param>
        /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListInstancesResponseResponse</returns>
        public static ListInstancesResponse List(appengineService service, string appsId, string servicesId, string versionsId, InstancesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (appsId == null)
                    throw new ArgumentNullException(appsId);
                if (servicesId == null)
                    throw new ArgumentNullException(servicesId);
                if (versionsId == null)
                    throw new ArgumentNullException(versionsId);

                // Building the initial request.
                var request = service.Instances.List(appsId, servicesId, versionsId);

                // Applying optional parameters to the request.                
                request = (InstancesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.List failed.", ex);
            }
        }


        /// <summary>
        /// Enables debugging on a VM instance. This allows you to use the SSH command to connect to the virtual machine where the instance lives. While in "debug mode", the instance continues to serve live traffic. You should delete the instance when you are done debugging and then allow the system to take over and determine if another instance should be started.Only applicable for instances in App Engine flexible environment. 
        /// Documentation https://developers.google.com/appengine/v1beta5/reference/instances/debug
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated appengine service.</param>  
        /// <param name="appsId">Part of `name`. Name of the resource requested. Example: apps/myapp/services/default/versions/v1/instances/instance-1.</param>
        /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="instancesId">Part of `name`. See documentation of `appsId`.</param>
        /// <param name="body">A valid appengine v1beta5 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Debug(appengineService service, string appsId, string servicesId, string versionsId, string instancesId, DebugInstanceRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (appsId == null)
                    throw new ArgumentNullException(appsId);
                if (servicesId == null)
                    throw new ArgumentNullException(servicesId);
                if (versionsId == null)
                    throw new ArgumentNullException(versionsId);
                if (instancesId == null)
                    throw new ArgumentNullException(instancesId);

                // Make the request.
                return service.Instances.Debug(body, appsId, servicesId, versionsId, instancesId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Debug failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}