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
//     Build date: 01/02/2017 22:31:48
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the analytics v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Views and manages your Google Analytics data.
// API Documentation Link https://developers.google.com/analytics/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/analytics/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.analytics.v3/ 
// Install Command: PM>  Install-Package Google.Apis.analytics.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.analytics.v3;
using Google.Apis.analytics.v3.Data;
using System;

namespace GoogleSamplecSharpSample.analyticsv3.Methods
{
  
    public static class WebpropertiesSample
    {


        /// <summary>
        /// Gets a web property to which the user has access. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webproperties/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to retrieve the web property for.</param>
        /// <param name="webPropertyId">ID to retrieve the web property for.</param>
        /// <returns>WebpropertyResponse</returns>
        public static Webproperty Get(analyticsService service, string accountId, string webPropertyId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);

                // Make the request.
                return service.Webproperties.Get(accountId, webPropertyId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Webproperties.Get failed.", ex);
            }
        }


        /// <summary>
        /// Create a new property if the account has fewer than 20 properties. Web properties are visible in the Google Analytics interface only if they have at least one profile. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webproperties/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to create the web property for.</param>
        /// <param name="body">A valid analytics v3 body.</param>
        /// <returns>WebpropertyResponse</returns>
        public static Webproperty Insert(analyticsService service, string accountId, Webproperty body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Make the request.
                return service.Webproperties.Insert(body, accountId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Webproperties.Insert failed.", ex);
            }
        }

        public class WebpropertiesListOptionalParms
        {
            /// The maximum number of web properties to include in this response.
            public int Max-results { get; set; }  
            /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.
            public int Start-index { get; set; }  
        
        }
 
        /// <summary>
        /// Lists web properties to which the user has access. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webproperties/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to retrieve web properties for. Can either be a specific account ID or '~all', which refers to all the accounts that user has access to.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>WebpropertiesResponse</returns>
        public static Webproperties List(analyticsService service, string accountId, WebpropertiesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Building the initial request.
                var request = service.Webproperties.List(accountId);

                // Applying optional parameters to the request.                
                request = (WebpropertiesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Webproperties.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing web property. This method supports patch semantics. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webproperties/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to which the web property belongs</param>
        /// <param name="webPropertyId">Web property ID</param>
        /// <param name="body">A valid analytics v3 body.</param>
        /// <returns>WebpropertyResponse</returns>
        public static Webproperty Patch(analyticsService service, string accountId, string webPropertyId, Webproperty body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);

                // Make the request.
                return service.Webproperties.Patch(body, accountId, webPropertyId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Webproperties.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing web property. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webproperties/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to which the web property belongs</param>
        /// <param name="webPropertyId">Web property ID</param>
        /// <param name="body">A valid analytics v3 body.</param>
        /// <returns>WebpropertyResponse</returns>
        public static Webproperty Update(analyticsService service, string accountId, string webPropertyId, Webproperty body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);

                // Make the request.
                return service.Webproperties.Update(body, accountId, webPropertyId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Webproperties.Update failed.", ex);
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