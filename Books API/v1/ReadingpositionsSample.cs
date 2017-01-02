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
  
    public static class ReadingpositionsSample
    {

        public class ReadingpositionsGetOptionalParms
        {
            /// Volume content version for which this reading position is requested.
            public string ContentVersion { get; set; }  
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves my reading position information for a volume. 
        /// Documentation https://developers.google.com/books/v1/reference/readingpositions/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated books service.</param>  
        /// <param name="volumeId">ID of volume for which to retrieve a reading position.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ReadingPositionResponse</returns>
        public static ReadingPosition Get(booksService service, string volumeId, ReadingpositionsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (volumeId == null)
                    throw new ArgumentNullException(volumeId);

                // Building the initial request.
                var request = service.Readingpositions.Get(volumeId);

                // Applying optional parameters to the request.                
                request = (ReadingpositionsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Readingpositions.Get failed.", ex);
            }
        }

        public class ReadingpositionsSetPositionOptionalParms
        {
            /// Action that caused this reading position to be set.
            public string Action { get; set; }  
            /// Volume content version for which this reading position applies.
            public string ContentVersion { get; set; }  
            /// Random persistent device cookie optional on set position.
            public string DeviceCookie { get; set; }  
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Sets my reading position information for a volume. 
        /// Documentation https://developers.google.com/books/v1/reference/readingpositions/setPosition
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated books service.</param>  
        /// <param name="volumeId">ID of volume for which to update the reading position.</param>
        /// <param name="timestamp">RFC 3339 UTC format timestamp associated with this reading position.</param>
        /// <param name="position">Position string for the new volume reading position.</param>
        /// <param name="optional">Optional paramaters.</param>        public static void SetPosition(booksService service, string volumeId, string timestamp, string position, ReadingpositionsSetPositionOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (volumeId == null)
                    throw new ArgumentNullException(volumeId);
                if (timestamp == null)
                    throw new ArgumentNullException(timestamp);
                if (position == null)
                    throw new ArgumentNullException(position);

                // Building the initial request.
                var request = service.Readingpositions.SetPosition(volumeId, timestamp, position);

                // Applying optional parameters to the request.                
                request = (ReadingpositionsResource.SetPositionRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Readingpositions.SetPosition failed.", ex);
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