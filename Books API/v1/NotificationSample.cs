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
//     Build date: 01/02/2017 22:32:01
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the books v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Searches for books and manages your Google Books library.
// API Documentation Link https://developers.google.com/books/docs/v1/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/books/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.books.v1/ 
// Install Command: PM>  Install-Package Google.Apis.books.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.books.v1;
using Google.Apis.books.v1.Data;
using System;

namespace GoogleSamplecSharpSample.booksv1.Methods
{
  
    public static class NotificationSample
    {

        public class NotificationGetOptionalParms
        {
            /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating notification title and body.
            public string Locale { get; set; }  
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Returns notification details for a given notification id. 
        /// Documentation https://developers.google.com/books/v1/reference/notification/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated books service.</param>  
        /// <param name="notification_id">String to identify the notification.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>NotificationResponse</returns>
        public static Notification Get(booksService service, string notification_id, NotificationGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (notification_id == null)
                    throw new ArgumentNullException(notification_id);

                // Building the initial request.
                var request = service.Notification.Get(notification_id);

                // Applying optional parameters to the request.                
                request = (NotificationResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Notification.Get failed.", ex);
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