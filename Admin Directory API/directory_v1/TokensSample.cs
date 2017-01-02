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
//     Build date: 01/02/2017 22:31:42
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the directory directory_v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Admin SDK Directory API lets you view and manage enterprise resources such as users and groups, administrative notifications, security features, and more.
// API Documentation Link https://developers.google.com/admin-sdk/directory/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/directory/directory_v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.directory.directory_v1/ 
// Install Command: PM>  Install-Package Google.Apis.directory.directory_v1
//
//------------------------------------------------------------------------------  
using Google.Apis.directory.directory_v1;
using Google.Apis.directory.directory_v1.Data;
using System;

namespace GoogleSamplecSharpSample.directorydirectory_v1.Methods
{
  
    public static class TokensSample
    {


        /// <summary>
        /// Delete all access tokens issued by a user for an application. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/tokens/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address, alias email address, or unique user ID.</param>
        /// <param name="clientId">The Client ID of the application the token is issued to.</param>
        public static void Delete(directoryService service, string userKey, string clientId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userKey == null)
                    throw new ArgumentNullException(userKey);
                if (clientId == null)
                    throw new ArgumentNullException(clientId);

                // Make the request.
                return service.Tokens.Delete(userKey, clientId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tokens.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Get information about an access token issued by a user. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/tokens/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address, alias email address, or unique user ID.</param>
        /// <param name="clientId">The Client ID of the application the token is issued to.</param>
        /// <returns>TokenResponse</returns>
        public static Token Get(directoryService service, string userKey, string clientId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userKey == null)
                    throw new ArgumentNullException(userKey);
                if (clientId == null)
                    throw new ArgumentNullException(clientId);

                // Make the request.
                return service.Tokens.Get(userKey, clientId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tokens.Get failed.", ex);
            }
        }


        /// <summary>
        /// Returns the set of tokens specified user has issued to 3rd party applications. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/tokens/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address, alias email address, or unique user ID.</param>
        /// <returns>TokensResponse</returns>
        public static Tokens List(directoryService service, string userKey)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userKey == null)
                    throw new ArgumentNullException(userKey);

                // Make the request.
                return service.Tokens.List(userKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tokens.List failed.", ex);
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