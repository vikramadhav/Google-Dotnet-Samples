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
//     Build date: 01/02/2017 22:32:21
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the compute v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and runs virtual machines on Google Cloud Platform.
// API Documentation Link https://developers.google.com/compute/docs/reference/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/compute/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.compute.v1/ 
// Install Command: PM>  Install-Package Google.Apis.compute.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.compute.v1;
using Google.Apis.compute.v1.Data;
using System;

namespace GoogleSamplecSharpSample.computev1.Methods
{
  
    public static class ProjectsSample
    {


        /// <summary>
        /// Returns the specified Project resource. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <returns>ProjectResponse</returns>
        public static Project Get(computeService service, string project)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.Get(project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Get failed.", ex);
            }
        }


        /// <summary>
        /// Moves a persistent disk from one zone to another. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/moveDisk
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation MoveDisk(computeService service, string project, DiskMoveRequest body)
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
                return service.Projects.MoveDisk(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.MoveDisk failed.", ex);
            }
        }


        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/moveInstance
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation MoveInstance(computeService service, string project, InstanceMoveRequest body)
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
                return service.Projects.MoveInstance(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.MoveInstance failed.", ex);
            }
        }


        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/setCommonInstanceMetadata
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetCommonInstanceMetadata(computeService service, string project, Metadata body)
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
                return service.Projects.SetCommonInstanceMetadata(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.SetCommonInstanceMetadata failed.", ex);
            }
        }


        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/setUsageExportBucket
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetUsageExportBucket(computeService service, string project, UsageExportLocation body)
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
                return service.Projects.SetUsageExportBucket(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.SetUsageExportBucket failed.", ex);
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