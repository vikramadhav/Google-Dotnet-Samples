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
//     Build date: 01/02/2017 22:32:27
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the datastore v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses the schemaless NoSQL database to provide fully managed, robust, scalable storage for your application.

// API Documentation Link https://cloud.google.com/datastore/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/datastore/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.datastore.v1/ 
// Install Command: PM>  Install-Package Google.Apis.datastore.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.datastore.v1;
using Google.Apis.datastore.v1.Data;
using System;

namespace GoogleSamplecSharpSample.datastorev1.Methods
{
  
    public static class ProjectsSample
    {


        /// <summary>
        /// Queries for entities. 
        /// Documentation https://developers.google.com/datastore/v1/reference/projects/runQuery
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated datastore service.</param>  
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="body">A valid datastore v1 body.</param>
        /// <returns>RunQueryResponseResponse</returns>
        public static RunQueryResponse RunQuery(datastoreService service, string projectId, RunQueryRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.RunQuery(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.RunQuery failed.", ex);
            }
        }


        /// <summary>
        /// Begins a new transaction. 
        /// Documentation https://developers.google.com/datastore/v1/reference/projects/beginTransaction
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated datastore service.</param>  
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="body">A valid datastore v1 body.</param>
        /// <returns>BeginTransactionResponseResponse</returns>
        public static BeginTransactionResponse BeginTransaction(datastoreService service, string projectId, BeginTransactionRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.BeginTransaction(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.BeginTransaction failed.", ex);
            }
        }


        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
before it is inserted. 
        /// Documentation https://developers.google.com/datastore/v1/reference/projects/allocateIds
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated datastore service.</param>  
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="body">A valid datastore v1 body.</param>
        /// <returns>AllocateIdsResponseResponse</returns>
        public static AllocateIdsResponse AllocateIds(datastoreService service, string projectId, AllocateIdsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.AllocateIds(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.AllocateIds failed.", ex);
            }
        }


        /// <summary>
        /// Looks up entities by key. 
        /// Documentation https://developers.google.com/datastore/v1/reference/projects/lookup
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated datastore service.</param>  
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="body">A valid datastore v1 body.</param>
        /// <returns>LookupResponseResponse</returns>
        public static LookupResponse Lookup(datastoreService service, string projectId, LookupRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Lookup(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Lookup failed.", ex);
            }
        }


        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
entities. 
        /// Documentation https://developers.google.com/datastore/v1/reference/projects/commit
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated datastore service.</param>  
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="body">A valid datastore v1 body.</param>
        /// <returns>CommitResponseResponse</returns>
        public static CommitResponse Commit(datastoreService service, string projectId, CommitRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Commit(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Commit failed.", ex);
            }
        }


        /// <summary>
        /// Rolls back a transaction. 
        /// Documentation https://developers.google.com/datastore/v1/reference/projects/rollback
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated datastore service.</param>  
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="body">A valid datastore v1 body.</param>
        /// <returns>RollbackResponseResponse</returns>
        public static RollbackResponse Rollback(datastoreService service, string projectId, RollbackRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Rollback(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Rollback failed.", ex);
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