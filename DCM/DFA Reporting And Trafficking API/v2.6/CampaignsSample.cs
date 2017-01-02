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
//     Build date: 01/02/2017 22:32:37
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the dfareporting v2.6 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/dfareporting/v2_6/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.dfareporting.v2_6/ 
// Install Command: PM>  Install-Package Google.Apis.dfareporting.v2_6
//
//------------------------------------------------------------------------------  
using Google.Apis.dfareporting.v2_6;
using Google.Apis.dfareporting.v2_6.Data;
using System;

namespace GoogleSamplecSharpSample.dfareportingv2_6.Methods
{
  
    public static class CampaignsSample
    {


        /// <summary>
        /// Gets one campaign by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/campaigns/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Campaign ID.</param>
        /// <returns>CampaignResponse</returns>
        public static Campaign Get(dfareportingService service, string profileId, string id)
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
                return service.Campaigns.Get(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Campaigns.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts a new campaign. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/campaigns/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="defaultLandingPageName">Default landing page name for this new campaign. Must be less than 256 characters long.</param>
        /// <param name="defaultLandingPageUrl">Default landing page URL for this new campaign.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>CampaignResponse</returns>
        public static Campaign Insert(dfareportingService service, string profileId, string defaultLandingPageName, string defaultLandingPageUrl, Campaign body)
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
                if (defaultLandingPageName == null)
                    throw new ArgumentNullException(defaultLandingPageName);
                if (defaultLandingPageUrl == null)
                    throw new ArgumentNullException(defaultLandingPageUrl);

                // Make the request.
                return service.Campaigns.Insert(body, profileId, defaultLandingPageName, defaultLandingPageUrl).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Campaigns.Insert failed.", ex);
            }
        }

        public class CampaignsListOptionalParms
        {
            /// Select only campaigns whose advertisers belong to these advertiser groups.
            public string AdvertiserGroupIds { get; set; }  
            /// Select only campaigns that belong to these advertisers.
            public string AdvertiserIds { get; set; }  
            /// Select only archived campaigns. Don't set this field to select both archived and non-archived campaigns.
            public bool Archived { get; set; }  
            /// Select only campaigns that have at least one optimization activity.
            public bool AtLeastOneOptimizationActivity { get; set; }  
            /// Exclude campaigns with these IDs.
            public string ExcludedIds { get; set; }  
            /// Select only campaigns with these IDs.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int MaxResults { get; set; }  
            /// Select only campaigns that have overridden this event tag ID.
            public string OverriddenEventTagId { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for campaigns by name or ID. Wildcards (*) are allowed. For example, "campaign*2015" will return campaigns with names like "campaign June 2015", "campaign April 2015", or simply "campaign 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "campaign" will match campaigns with name "my campaign", "campaign 2015", or simply "campaign".
            public string SearchString { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results, default is ASCENDING.
            public string SortOrder { get; set; }  
            /// Select only campaigns that belong to this subaccount.
            public string SubaccountId { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of campaigns, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/campaigns/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>CampaignsListResponseResponse</returns>
        public static CampaignsListResponse List(dfareportingService service, string profileId, CampaignsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.Campaigns.List(profileId);

                // Applying optional parameters to the request.                
                request = (CampaignsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Campaigns.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing campaign. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/campaigns/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Campaign ID.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>CampaignResponse</returns>
        public static Campaign Patch(dfareportingService service, string profileId, string id, Campaign body)
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
                return service.Campaigns.Patch(body, profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Campaigns.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing campaign. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/campaigns/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>CampaignResponse</returns>
        public static Campaign Update(dfareportingService service, string profileId, Campaign body)
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
                return service.Campaigns.Update(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Campaigns.Update failed.", ex);
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