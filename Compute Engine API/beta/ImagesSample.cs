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
//     Build date: 01/02/2017 22:32:19
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the compute beta API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and runs virtual machines on Google Cloud Platform.
// API Documentation Link https://developers.google.com/compute/docs/reference/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/compute/beta/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.compute.beta/ 
// Install Command: PM>  Install-Package Google.Apis.compute.beta
//
//------------------------------------------------------------------------------  
using Google.Apis.compute.beta;
using Google.Apis.compute.beta.Data;
using System;

namespace GoogleSamplecSharpSample.computebeta.Methods
{
  
    public static class ImagesSample
    {


        /// <summary>
        /// Deletes the specified image. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="image">Name of the image resource to delete.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(computeService service, string project, string image)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (image == null)
                    throw new ArgumentNullException(image);

                // Make the request.
                return service.Images.Delete(project, image).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Sets the deprecation status of an image.

If an empty request body is given, clears the deprecation status instead. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/deprecate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="image">Image name.</param>
        /// <param name="body">A valid compute beta body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Deprecate(computeService service, string project, string image, DeprecationStatus body)
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
                if (image == null)
                    throw new ArgumentNullException(image);

                // Make the request.
                return service.Images.Deprecate(body, project, image).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.Deprecate failed.", ex);
            }
        }


        /// <summary>
        /// Returns the specified image. Get a list of available images by making a list() request. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="image">Name of the image resource to return.</param>
        /// <returns>ImageResponse</returns>
        public static Image Get(computeService service, string project, string image)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (image == null)
                    throw new ArgumentNullException(image);

                // Make the request.
                return service.Images.Get(project, image).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.Get failed.", ex);
            }
        }


        /// <summary>
        /// Returns the latest image that is part of an image family and is not deprecated. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/getFromFamily
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="family">Name of the image family to search for.</param>
        /// <returns>ImageResponse</returns>
        public static Image GetFromFamily(computeService service, string project, string family)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (family == null)
                    throw new ArgumentNullException(family);

                // Make the request.
                return service.Images.GetFromFamily(project, family).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.GetFromFamily failed.", ex);
            }
        }


        /// <summary>
        /// Creates an image in the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid compute beta body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(computeService service, string project, Image body)
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

                // Make the request.
                return service.Images.Insert(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.Insert failed.", ex);
            }
        }

        public class ImagesListOptionalParms
        {
            /// Sets a filter expression for filtering listed resources, in the form filter={expression}. Your {expression} must be in the format: field_name comparison_string literal_string.

The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.

For example, to filter for instances that do not have a name of example-instance, you would use filter=name ne example-instance.

You can filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. Use filtering on nested fields to take advantage of labels to organize and search for results based on label values.

To filter on multiple expressions, provide each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests.
            public int MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.

You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.

Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the list of private images available to the specified project. Private images are images you create that belong to your project. This method does not get any images that belong to other projects, including publicly-available images, like Debian 8. If you want to get a list of publicly-available images, use this method to make a request to the respective image project, such as debian-cloud or windows-cloud. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ImageListResponse</returns>
        public static ImageList List(computeService service, string project, ImagesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Images.List(project);

                // Applying optional parameters to the request.                
                request = (ImagesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.List failed.", ex);
            }
        }


        /// <summary>
        /// Sets the labels on an image. To learn more about labels, read the Labeling or Tagging Resources documentation. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/setLabels
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid compute beta body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetLabels(computeService service, string project, string resource, GlobalSetLabelsRequest body)
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
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Images.SetLabels(body, project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.SetLabels failed.", ex);
            }
        }


        /// <summary>
        /// Returns permissions that a caller has on the specified resource. 
        /// Documentation https://developers.google.com/compute/beta/reference/images/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid compute beta body.</param>
        /// <returns>TestPermissionsResponseResponse</returns>
        public static TestPermissionsResponse TestIamPermissions(computeService service, string project, string resource, TestPermissionsRequest body)
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
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Images.TestIamPermissions(body, project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Images.TestIamPermissions failed.", ex);
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