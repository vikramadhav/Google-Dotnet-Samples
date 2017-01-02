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
  
    public static class RegionInstanceGroupManagersSample
    {


        /// <summary>
        /// Schedules a group action to remove the specified instances from the managed instance group. Abandoning an instance does not delete the instance, but it does remove the instance from any target pools that are applied by the managed instance group. This method reduces the targetSize of the managed instance group by the number of instances that you abandon. This operation is marked as DONE when the action is scheduled even if the instances have not yet been removed from the group. You must separately verify the status of the abandoning action with the listmanagedinstances method. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/abandonInstances
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation AbandonInstances(computeService service, string project, string region, string instanceGroupManager, RegionInstanceGroupManagersAbandonInstancesRequest body)
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
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.AbandonInstances(body, project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.AbandonInstances failed.", ex);
            }
        }


        /// <summary>
        /// Deletes the specified managed instance group and all of the instances in that group. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group to delete.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(computeService service, string project, string region, string instanceGroupManager)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.Delete(project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Schedules a group action to delete the specified instances in the managed instance group. The instances are also removed from any target pools of which they were a member. This method reduces the targetSize of the managed instance group by the number of instances that you delete. This operation is marked as DONE when the action is scheduled even if the instances are still being deleted. You must separately verify the status of the deleting action with the listmanagedinstances method. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/deleteInstances
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation DeleteInstances(computeService service, string project, string region, string instanceGroupManager, RegionInstanceGroupManagersDeleteInstancesRequest body)
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
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.DeleteInstances(body, project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.DeleteInstances failed.", ex);
            }
        }


        /// <summary>
        /// Returns all of the details about the specified managed instance group. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group to return.</param>
        /// <returns>InstanceGroupManagerResponse</returns>
        public static InstanceGroupManager Get(computeService service, string project, string region, string instanceGroupManager)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.Get(project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.Get failed.", ex);
            }
        }


        /// <summary>
        /// Creates a managed instance group using the information that you specify in the request. After the group is created, it schedules an action to create instances in the group using the specified instance template. This operation is marked as DONE when the group is created even if the instances in the group have not yet been created. You must separately verify the status of the individual instances with the listmanagedinstances method. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(computeService service, string project, string region, InstanceGroupManager body)
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
                if (region == null)
                    throw new ArgumentNullException(region);

                // Make the request.
                return service.RegionInstanceGroupManagers.Insert(body, project, region).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.Insert failed.", ex);
            }
        }

        public class RegionInstanceGroupManagersListOptionalParms
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
        /// Retrieves the list of managed instance groups that are contained within the specified region. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>RegionInstanceGroupManagerListResponse</returns>
        public static RegionInstanceGroupManagerList List(computeService service, string project, string region, RegionInstanceGroupManagersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.RegionInstanceGroupManagers.List(project, region);

                // Applying optional parameters to the request.                
                request = (RegionInstanceGroupManagersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.List failed.", ex);
            }
        }

        public class RegionInstanceGroupManagersListManagedInstancesOptionalParms
        {
            /// NA
            public string Filter { get; set; }  
            /// NA
            public int MaxResults { get; set; }  
            /// NA
            public string Order_by { get; set; }  
            /// NA
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the instances in the managed instance group and instances that are scheduled to be created. The list includes any current actions that the group has scheduled for its instances. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/listManagedInstances
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">The name of the managed instance group.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>RegionInstanceGroupManagersListInstancesResponseResponse</returns>
        public static RegionInstanceGroupManagersListInstancesResponse ListManagedInstances(computeService service, string project, string region, string instanceGroupManager, RegionInstanceGroupManagersListManagedInstancesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Building the initial request.
                var request = service.RegionInstanceGroupManagers.ListManagedInstances(project, region, instanceGroupManager);

                // Applying optional parameters to the request.                
                request = (RegionInstanceGroupManagersResource.ListManagedInstancesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.ListManagedInstances failed.", ex);
            }
        }


        /// <summary>
        /// Schedules a group action to recreate the specified instances in the managed instance group. The instances are deleted and recreated using the current instance template for the managed instance group. This operation is marked as DONE when the action is scheduled even if the instances have not yet been recreated. You must separately verify the status of the recreating action with the listmanagedinstances method. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/recreateInstances
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation RecreateInstances(computeService service, string project, string region, string instanceGroupManager, RegionInstanceGroupManagersRecreateRequest body)
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
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.RecreateInstances(body, project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.RecreateInstances failed.", ex);
            }
        }


        /// <summary>
        /// Changes the intended size for the managed instance group. If you increase the size, the group schedules actions to create new instances using the current instance template. If you decrease the size, the group schedules delete actions on one or more instances. The resize operation is marked DONE when the resize actions are scheduled even if the group has not yet added or deleted any instances. You must separately verify the status of the creating or deleting actions with the listmanagedinstances method. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/resize
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group.</param>
        /// <param name="size">Number of instances that should exist in this instance group manager.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Resize(computeService service, string project, string region, string instanceGroupManager, int size)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.Resize(project, region, instanceGroupManager, size).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.Resize failed.", ex);
            }
        }


        /// <summary>
        /// Sets the instance template to use when creating new instances or recreating instances in this group. Existing instances are not affected. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/setInstanceTemplate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">The name of the managed instance group.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetInstanceTemplate(computeService service, string project, string region, string instanceGroupManager, RegionInstanceGroupManagersSetTemplateRequest body)
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
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.SetInstanceTemplate(body, project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.SetInstanceTemplate failed.", ex);
            }
        }


        /// <summary>
        /// Modifies the target pools to which all new instances in this group are assigned. Existing instances in the group are not affected. 
        /// Documentation https://developers.google.com/compute/v1/reference/regionInstanceGroupManagers/setTargetPools
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="instanceGroupManager">Name of the managed instance group.</param>
        /// <param name="body">A valid compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetTargetPools(computeService service, string project, string region, string instanceGroupManager, RegionInstanceGroupManagersSetTargetPoolsRequest body)
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
                if (region == null)
                    throw new ArgumentNullException(region);
                if (instanceGroupManager == null)
                    throw new ArgumentNullException(instanceGroupManager);

                // Make the request.
                return service.RegionInstanceGroupManagers.SetTargetPools(body, project, region, instanceGroupManager).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionInstanceGroupManagers.SetTargetPools failed.", ex);
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