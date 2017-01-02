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
//     Build date: 01/02/2017 22:31:35
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AdExchangeBuyer v1.4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses your bidding-account information, submits creatives for validation, finds available direct deals, and retrieves performance reports.
// API Documentation Link https://developers.google.com/ad-exchange/buyer-rest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AdExchangeBuyer/v1_4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AdExchangeBuyer.v1_4/ 
// Install Command: PM>  Install-Package Google.Apis.AdExchangeBuyer.v1_4
//
//------------------------------------------------------------------------------  
using Google.Apis.AdExchangeBuyer.v1_4;
using Google.Apis.AdExchangeBuyer.v1_4.Data;
using System;

namespace GoogleSamplecSharpSample.AdExchangeBuyerv1_4.Methods
{
  
    public static class CreativesSample
    {


        /// <summary>
        /// Add a deal id association for the creative. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.4/reference/creatives/addDeal
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <param name="dealId">The id of the deal id to associate with this creative.</param>
        public static void AddDeal(AdExchangeBuyerService service, int accountId, string buyerCreativeId, string dealId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (buyerCreativeId == null)
                    throw new ArgumentNullException(buyerCreativeId);
                if (dealId == null)
                    throw new ArgumentNullException(dealId);

                // Make the request.
                return service.Creatives.AddDeal(accountId, buyerCreativeId, dealId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.AddDeal failed.", ex);
            }
        }


        /// <summary>
        /// Gets the status for a single creative. A creative will be available 30-40 minutes after submission. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.4/reference/creatives/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <returns>CreativeResponse</returns>
        public static Creative Get(AdExchangeBuyerService service, int accountId, string buyerCreativeId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (buyerCreativeId == null)
                    throw new ArgumentNullException(buyerCreativeId);

                // Make the request.
                return service.Creatives.Get(accountId, buyerCreativeId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.Get failed.", ex);
            }
        }


        /// <summary>
        /// Submit a new creative. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.4/reference/creatives/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="body">A valid AdExchangeBuyer v1.4 body.</param>
        /// <returns>CreativeResponse</returns>
        public static Creative Insert(AdExchangeBuyerService service, Creative body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Creatives.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.Insert failed.", ex);
            }
        }

        public class CreativesListOptionalParms
        {
            /// When specified, only creatives for the given account ids are returned.
            public int AccountId { get; set; }  
            /// When specified, only creatives for the given buyer creative ids are returned.
            public string BuyerCreativeId { get; set; }  
            /// When specified, only creatives having the given deals status are returned.
            public string DealsStatusFilter { get; set; }  
            /// Maximum number of entries returned on one result page. If not set, the default is 100. Optional.
            public int MaxResults { get; set; }  
            /// When specified, only creatives having the given open auction status are returned.
            public string OpenAuctionStatusFilter { get; set; }  
            /// A continuation token, used to page through ad clients. To retrieve the next page, set this parameter to the value of "nextPageToken" from the previous response. Optional.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40 minutes after submission. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.4/reference/creatives/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>CreativesListResponse</returns>
        public static CreativesList List(AdExchangeBuyerService service, CreativesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Creatives.List();

                // Applying optional parameters to the request.                
                request = (CreativesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.List failed.", ex);
            }
        }


        /// <summary>
        /// Lists the external deal ids associated with the creative. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.4/reference/creatives/listDeals
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <returns>CreativeDealIdsResponse</returns>
        public static CreativeDealIds ListDeals(AdExchangeBuyerService service, int accountId, string buyerCreativeId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (buyerCreativeId == null)
                    throw new ArgumentNullException(buyerCreativeId);

                // Make the request.
                return service.Creatives.ListDeals(accountId, buyerCreativeId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.ListDeals failed.", ex);
            }
        }


        /// <summary>
        /// Remove a deal id associated with the creative. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.4/reference/creatives/removeDeal
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <param name="dealId">The id of the deal id to disassociate with this creative.</param>
        public static void RemoveDeal(AdExchangeBuyerService service, int accountId, string buyerCreativeId, string dealId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (buyerCreativeId == null)
                    throw new ArgumentNullException(buyerCreativeId);
                if (dealId == null)
                    throw new ArgumentNullException(dealId);

                // Make the request.
                return service.Creatives.RemoveDeal(accountId, buyerCreativeId, dealId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.RemoveDeal failed.", ex);
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