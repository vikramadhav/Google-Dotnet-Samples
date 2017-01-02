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
  
    public static class UploadsSample
    {


        /// <summary>
        /// Delete data associated with a previous upload. 
        /// Documentation https://developers.google.com/analytics/v3/reference/uploads/deleteUploadData
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account Id for the uploads to be deleted.</param>
        /// <param name="webPropertyId">Web property Id for the uploads to be deleted.</param>
        /// <param name="customDataSourceId">Custom data source Id for the uploads to be deleted.</param>
        /// <param name="body">A valid analytics v3 body.</param>
        public static void DeleteUploadData(analyticsService service, string accountId, string webPropertyId, string customDataSourceId, AnalyticsDataimportDeleteUploadDataRequest body)
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
                if (customDataSourceId == null)
                    throw new ArgumentNullException(customDataSourceId);

                // Make the request.
                return service.Uploads.DeleteUploadData(body, accountId, webPropertyId, customDataSourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Uploads.DeleteUploadData failed.", ex);
            }
        }


        /// <summary>
        /// List uploads to which the user has access. 
        /// Documentation https://developers.google.com/analytics/v3/reference/uploads/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account Id for the upload to retrieve.</param>
        /// <param name="webPropertyId">Web property Id for the upload to retrieve.</param>
        /// <param name="customDataSourceId">Custom data source Id for upload to retrieve.</param>
        /// <param name="uploadId">Upload Id to retrieve.</param>
        /// <returns>UploadResponse</returns>
        public static Upload Get(analyticsService service, string accountId, string webPropertyId, string customDataSourceId, string uploadId)
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
                if (customDataSourceId == null)
                    throw new ArgumentNullException(customDataSourceId);
                if (uploadId == null)
                    throw new ArgumentNullException(uploadId);

                // Make the request.
                return service.Uploads.Get(accountId, webPropertyId, customDataSourceId, uploadId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Uploads.Get failed.", ex);
            }
        }

        public class UploadsListOptionalParms
        {
            /// The maximum number of uploads to include in this response.
            public int Max-results { get; set; }  
            /// A 1-based index of the first upload to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.
            public int Start-index { get; set; }  
        
        }
 
        /// <summary>
        /// List uploads to which the user has access. 
        /// Documentation https://developers.google.com/analytics/v3/reference/uploads/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account Id for the uploads to retrieve.</param>
        /// <param name="webPropertyId">Web property Id for the uploads to retrieve.</param>
        /// <param name="customDataSourceId">Custom data source Id for uploads to retrieve.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>UploadsResponse</returns>
        public static Uploads List(analyticsService service, string accountId, string webPropertyId, string customDataSourceId, UploadsListOptionalParms optional = null)
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
                if (customDataSourceId == null)
                    throw new ArgumentNullException(customDataSourceId);

                // Building the initial request.
                var request = service.Uploads.List(accountId, webPropertyId, customDataSourceId);

                // Applying optional parameters to the request.                
                request = (UploadsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Uploads.List failed.", ex);
            }
        }


        /// <summary>
        /// Upload data for a custom data source. 
        /// Documentation https://developers.google.com/analytics/v3/reference/uploads/uploadData
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account Id associated with the upload.</param>
        /// <param name="webPropertyId">Web property UA-string associated with the upload.</param>
        /// <param name="customDataSourceId">Custom data source Id to which the data being uploaded belongs.</param>
        /// <returns>UploadResponse</returns>
        public static Upload UploadData(analyticsService service, string accountId, string webPropertyId, string customDataSourceId)
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
                if (customDataSourceId == null)
                    throw new ArgumentNullException(customDataSourceId);

                // Make the request.
                return service.Uploads.UploadData(accountId, webPropertyId, customDataSourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Uploads.UploadData failed.", ex);
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