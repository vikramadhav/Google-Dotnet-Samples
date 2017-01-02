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
//     Build date: 01/02/2017 22:32:33
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the dfareporting v2.5 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/reporting/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/dfareporting/v2_5/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.dfareporting.v2_5/ 
// Install Command: PM>  Install-Package Google.Apis.dfareporting.v2_5
//
//------------------------------------------------------------------------------  
using Google.Apis.dfareporting.v2_5;
using Google.Apis.dfareporting.v2_5.Data;
using System;

namespace GoogleSamplecSharpSample.dfareportingv2_5.Methods
{
  
    public static class RemarketingListsSample
    {


        /// <summary>
        /// Gets one remarketing list by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/remarketingLists/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Remarketing list ID.</param>
        /// <returns>RemarketingListResponse</returns>
        public static RemarketingList Get(dfareportingService service, string profileId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.RemarketingLists.Get(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RemarketingLists.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts a new remarketing list. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/remarketingLists/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.5 body.</param>
        /// <returns>RemarketingListResponse</returns>
        public static RemarketingList Insert(dfareportingService service, string profileId, RemarketingList body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.RemarketingLists.Insert(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RemarketingLists.Insert failed.", ex);
            }
        }

        public class RemarketingListsListOptionalParms
        {
            /// Select only active or only inactive remarketing lists.
            public bool Active { get; set; }  
            /// Select only remarketing lists that have this floodlight activity ID.
            public string FloodlightActivityId { get; set; }  
            /// Maximum number of results to return.
            public int MaxResults { get; set; }  
            /// Allows searching for objects by name or ID. Wildcards (*) are allowed. For example, "remarketing list*2015" will return objects with names like "remarketing list June 2015", "remarketing list April 2015", or simply "remarketing list 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "remarketing list" will match objects with name "my remarketing list", "remarketing list 2015", or simply "remarketing list".
            public string Name { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results, default is ASCENDING.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of remarketing lists, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/remarketingLists/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="advertiserId">Select only remarketing lists owned by this advertiser.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>RemarketingListsListResponseResponse</returns>
        public static RemarketingListsListResponse List(dfareportingService service, string profileId, string advertiserId, RemarketingListsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (advertiserId == null)
                    throw new ArgumentNullException(advertiserId);

                // Building the initial request.
                var request = service.RemarketingLists.List(profileId, advertiserId);

                // Applying optional parameters to the request.                
                request = (RemarketingListsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RemarketingLists.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing remarketing list. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/remarketingLists/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Remarketing list ID.</param>
        /// <param name="body">A valid dfareporting v2.5 body.</param>
        /// <returns>RemarketingListResponse</returns>
        public static RemarketingList Patch(dfareportingService service, string profileId, string id, RemarketingList body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.RemarketingLists.Patch(body, profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RemarketingLists.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing remarketing list. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/remarketingLists/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.5 body.</param>
        /// <returns>RemarketingListResponse</returns>
        public static RemarketingList Update(dfareportingService service, string profileId, RemarketingList body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.RemarketingLists.Update(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RemarketingLists.Update failed.", ex);
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