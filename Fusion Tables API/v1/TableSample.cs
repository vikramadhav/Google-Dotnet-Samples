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
//     Build date: 01/02/2017 22:32:53
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the fusiontables v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for working with Fusion Tables data.
// API Documentation Link https://developers.google.com/fusiontables
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/fusiontables/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.fusiontables.v1/ 
// Install Command: PM>  Install-Package Google.Apis.fusiontables.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.fusiontables.v1;
using Google.Apis.fusiontables.v1.Data;
using System;

namespace GoogleSamplecSharpSample.fusiontablesv1.Methods
{
  
    public static class TableSample
    {

        public class TableCopyOptionalParms
        {
            /// Whether to also copy tabs, styles, and templates. Default is false.
            public bool CopyPresentation { get; set; }  
        
        }
 
        /// <summary>
        /// Copies a table. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/copy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being copied.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>TableResponse</returns>
        public static Table Copy(fusiontablesService service, string tableId, TableCopyOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.Copy(tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.CopyRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Copy failed.", ex);
            }
        }


        /// <summary>
        /// Deletes a table. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being deleted.</param>
        public static void Delete(fusiontablesService service, string tableId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Make the request.
                return service.Table.Delete(tableId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves a specific table by its id. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="tableId">Identifier(ID) for the table being requested.</param>
        /// <returns>TableResponse</returns>
        public static Table Get(fusiontablesService service, string tableId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Make the request.
                return service.Table.Get(tableId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Get failed.", ex);
            }
        }

        public class TableImportRowsOptionalParms
        {
            /// The delimiter used to separate cell values. This can only consist of a single character. Default is ','.
            public string Delimiter { get; set; }  
            /// The encoding of the content. Default is UTF-8. Use 'auto-detect' if you are unsure of the encoding.
            public string Encoding { get; set; }  
            /// The index of the last line from which to start importing, exclusive. Thus, the number of imported lines is endLine - startLine. If this parameter is not provided, the file will be imported until the last line of the file. If endLine is negative, then the imported content will exclude the last endLine lines. That is, if endline is negative, no line will be imported whose index is greater than N + endLine where N is the number of lines in the file, and the number of imported lines will be N + endLine - startLine.
            public int EndLine { get; set; }  
            /// Whether the CSV must have the same number of values for each row. If false, rows with fewer values will be padded with empty values. Default is true.
            public bool IsStrict { get; set; }  
            /// The index of the first line from which to start importing, inclusive. Default is 0.
            public int StartLine { get; set; }  
        
        }
 
        /// <summary>
        /// Import more rows into a table. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/importRows
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="tableId">The table into which new rows are being imported.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ImportResponse</returns>
        public static Import ImportRows(fusiontablesService service, string tableId, TableImportRowsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.ImportRows(tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.ImportRowsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.ImportRows failed.", ex);
            }
        }

        public class TableImportTableOptionalParms
        {
            /// The delimiter used to separate cell values. This can only consist of a single character. Default is ','.
            public string Delimiter { get; set; }  
            /// The encoding of the content. Default is UTF-8. Use 'auto-detect' if you are unsure of the encoding.
            public string Encoding { get; set; }  
        
        }
 
        /// <summary>
        /// Import a new table. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/importTable
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="name">The name to be assigned to the new table.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>TableResponse</returns>
        public static Table ImportTable(fusiontablesService service, string name, TableImportTableOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Table.ImportTable(name);

                // Applying optional parameters to the request.                
                request = (TableResource.ImportTableRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.ImportTable failed.", ex);
            }
        }


        /// <summary>
        /// Creates a new table. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="body">A valid fusiontables v1 body.</param>
        /// <returns>TableResponse</returns>
        public static Table Insert(fusiontablesService service, Table body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Table.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Insert failed.", ex);
            }
        }

        public class TableListOptionalParms
        {
            /// Maximum number of styles to return. Optional. Default is 5.
            public int MaxResults { get; set; }  
            /// Continuation token specifying which result page to return. Optional.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of tables a user owns. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>TableListResponse</returns>
        public static TableList List(fusiontablesService service, TableListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Table.List();

                // Applying optional parameters to the request.                
                request = (TableResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.List failed.", ex);
            }
        }

        public class TablePatchOptionalParms
        {
            /// Should the view definition also be updated? The specified view definition replaces the existing one. Only a view can be updated with a new definition.
            public bool ReplaceViewDefinition { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an existing table. Unless explicitly requested, only the name, description, and attribution will be updated. This method supports patch semantics. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being updated.</param>
        /// <param name="body">A valid fusiontables v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>TableResponse</returns>
        public static Table Patch(fusiontablesService service, string tableId, Table body, TablePatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.Patch(body, tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Patch failed.", ex);
            }
        }

        public class TableUpdateOptionalParms
        {
            /// Should the view definition also be updated? The specified view definition replaces the existing one. Only a view can be updated with a new definition.
            public bool ReplaceViewDefinition { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an existing table. Unless explicitly requested, only the name, description, and attribution will be updated. 
        /// Documentation https://developers.google.com/fusiontables/v1/reference/table/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being updated.</param>
        /// <param name="body">A valid fusiontables v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>TableResponse</returns>
        public static Table Update(fusiontablesService service, string tableId, Table body, TableUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.Update(body, tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Update failed.", ex);
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