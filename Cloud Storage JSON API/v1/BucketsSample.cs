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
//     Build date: 01/02/2017 22:34:37
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the storage v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Stores and retrieves potentially large, immutable data objects.
// API Documentation Link https://developers.google.com/storage/docs/json_api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/storage/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.storage.v1/ 
// Install Command: PM>  Install-Package Google.Apis.storage.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.storage.v1;
using Google.Apis.storage.v1.Data;
using System;

namespace GoogleSamplecSharpSample.storagev1.Methods
{
  
    public static class BucketsSample
    {

        public class BucketsDeleteOptionalParms
        {
            /// If set, only deletes the bucket if its metageneration matches this value.
            public string IfMetagenerationMatch { get; set; }  
            /// If set, only deletes the bucket if its metageneration does not match this value.
            public string IfMetagenerationNotMatch { get; set; }  
        
        }
 
        /// <summary>
        /// Permanently deletes an empty bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/buckets/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="optional">Optional paramaters.</param>        public static void Delete(storageService service, string bucket, BucketsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Buckets.Delete(bucket);

                // Applying optional parameters to the request.                
                request = (BucketsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Buckets.Delete failed.", ex);
            }
        }

        public class BucketsGetOptionalParms
        {
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Set of properties to return. Defaults to noAcl.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Returns metadata for the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/buckets/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>BucketResponse</returns>
        public static Bucket Get(storageService service, string bucket, BucketsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Buckets.Get(bucket);

                // Applying optional parameters to the request.                
                request = (BucketsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Buckets.Get failed.", ex);
            }
        }

        public class BucketsInsertOptionalParms
        {
            /// Apply a predefined set of access controls to this bucket.
            public string PredefinedAcl { get; set; }  
            /// Apply a predefined set of default object access controls to this bucket.
            public string PredefinedDefaultObjectAcl { get; set; }  
            /// Set of properties to return. Defaults to noAcl, unless the bucket resource specifies acl or defaultObjectAcl properties, when it defaults to full.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a new bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/buckets/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storage service.</param>  
        /// <param name="project">A valid API project identifier.</param>
        /// <param name="body">A valid storage v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>BucketResponse</returns>
        public static Bucket Insert(storageService service, string project, Bucket body, BucketsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Buckets.Insert(body, project);

                // Applying optional parameters to the request.                
                request = (BucketsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Buckets.Insert failed.", ex);
            }
        }

        public class BucketsListOptionalParms
        {
            /// Maximum number of buckets to return.
            public int MaxResults { get; set; }  
            /// A previously-returned page token representing part of the larger set of results to view.
            public string PageToken { get; set; }  
            /// Filter results to buckets whose names begin with this prefix.
            public string Prefix { get; set; }  
            /// Set of properties to return. Defaults to noAcl.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of buckets for a given project. 
        /// Documentation https://developers.google.com/storage/v1/reference/buckets/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storage service.</param>  
        /// <param name="project">A valid API project identifier.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>BucketsResponse</returns>
        public static Buckets List(storageService service, string project, BucketsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Buckets.List(project);

                // Applying optional parameters to the request.                
                request = (BucketsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Buckets.List failed.", ex);
            }
        }

        public class BucketsPatchOptionalParms
        {
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Apply a predefined set of access controls to this bucket.
            public string PredefinedAcl { get; set; }  
            /// Apply a predefined set of default object access controls to this bucket.
            public string PredefinedDefaultObjectAcl { get; set; }  
            /// Set of properties to return. Defaults to full.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a bucket. Changes to the bucket will be readable immediately after writing, but configuration changes may take time to propagate. This method supports patch semantics. 
        /// Documentation https://developers.google.com/storage/v1/reference/buckets/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="body">A valid storage v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>BucketResponse</returns>
        public static Bucket Patch(storageService service, string bucket, Bucket body, BucketsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Buckets.Patch(body, bucket);

                // Applying optional parameters to the request.                
                request = (BucketsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Buckets.Patch failed.", ex);
            }
        }

        public class BucketsUpdateOptionalParms
        {
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Apply a predefined set of access controls to this bucket.
            public string PredefinedAcl { get; set; }  
            /// Apply a predefined set of default object access controls to this bucket.
            public string PredefinedDefaultObjectAcl { get; set; }  
            /// Set of properties to return. Defaults to full.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a bucket. Changes to the bucket will be readable immediately after writing, but configuration changes may take time to propagate. 
        /// Documentation https://developers.google.com/storage/v1/reference/buckets/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="body">A valid storage v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>BucketResponse</returns>
        public static Bucket Update(storageService service, string bucket, Bucket body, BucketsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Buckets.Update(body, bucket);

                // Applying optional parameters to the request.                
                request = (BucketsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Buckets.Update failed.", ex);
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