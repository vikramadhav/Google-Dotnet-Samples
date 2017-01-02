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
  
    public static class CalendarsSample
    {


        /// <summary>
        /// Deletes a calendar resource. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/calendars/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="customer">The unique ID for the customer's Google account. As an account administrator, you can also use the my_customer alias to represent your account's customer ID.</param>
        /// <param name="calendarResourceId">The unique ID of the calendar resource to delete.</param>
        public static void Delete(directoryService service, string customer, string calendarResourceId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customer == null)
                    throw new ArgumentNullException(customer);
                if (calendarResourceId == null)
                    throw new ArgumentNullException(calendarResourceId);

                // Make the request.
                return service.Calendars.Delete(customer, calendarResourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves a calendar resource. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/calendars/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="customer">The unique ID for the customer's Google account. As an account administrator, you can also use the my_customer alias to represent your account's customer ID.</param>
        /// <param name="calendarResourceId">The unique ID of the calendar resource to retrieve.</param>
        /// <returns>CalendarResourceResponse</returns>
        public static CalendarResource Get(directoryService service, string customer, string calendarResourceId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customer == null)
                    throw new ArgumentNullException(customer);
                if (calendarResourceId == null)
                    throw new ArgumentNullException(calendarResourceId);

                // Make the request.
                return service.Calendars.Get(customer, calendarResourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts a calendar resource. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/calendars/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="customer">The unique ID for the customer's Google account. As an account administrator, you can also use the my_customer alias to represent your account's customer ID.</param>
        /// <param name="body">A valid directory directory_v1 body.</param>
        /// <returns>CalendarResourceResponse</returns>
        public static CalendarResource Insert(directoryService service, string customer, CalendarResource body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customer == null)
                    throw new ArgumentNullException(customer);

                // Make the request.
                return service.Calendars.Insert(body, customer).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Insert failed.", ex);
            }
        }

        public class CalendarsListOptionalParms
        {
            /// Maximum number of results to return.
            public int MaxResults { get; set; }  
            /// Token to specify the next page in the list.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of calendar resources for an account. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/calendars/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="customer">The unique ID for the customer's Google account. As an account administrator, you can also use the my_customer alias to represent your account's customer ID.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>CalendarResourcesResponse</returns>
        public static CalendarResources List(directoryService service, string customer, CalendarsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customer == null)
                    throw new ArgumentNullException(customer);

                // Building the initial request.
                var request = service.Calendars.List(customer);

                // Applying optional parameters to the request.                
                request = (CalendarsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates a calendar resource. This method supports patch semantics. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/calendars/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="customer">The unique ID for the customer's Google account. As an account administrator, you can also use the my_customer alias to represent your account's customer ID.</param>
        /// <param name="calendarResourceId">The unique ID of the calendar resource to update.</param>
        /// <param name="body">A valid directory directory_v1 body.</param>
        /// <returns>CalendarResourceResponse</returns>
        public static CalendarResource Patch(directoryService service, string customer, string calendarResourceId, CalendarResource body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customer == null)
                    throw new ArgumentNullException(customer);
                if (calendarResourceId == null)
                    throw new ArgumentNullException(calendarResourceId);

                // Make the request.
                return service.Calendars.Patch(body, customer, calendarResourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates a calendar resource. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/calendars/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated directory service.</param>  
        /// <param name="customer">The unique ID for the customer's Google account. As an account administrator, you can also use the my_customer alias to represent your account's customer ID.</param>
        /// <param name="calendarResourceId">The unique ID of the calendar resource to update.</param>
        /// <param name="body">A valid directory directory_v1 body.</param>
        /// <returns>CalendarResourceResponse</returns>
        public static CalendarResource Update(directoryService service, string customer, string calendarResourceId, CalendarResource body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customer == null)
                    throw new ArgumentNullException(customer);
                if (calendarResourceId == null)
                    throw new ArgumentNullException(calendarResourceId);

                // Make the request.
                return service.Calendars.Update(body, customer, calendarResourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Update failed.", ex);
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