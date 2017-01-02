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
//     Build date: 01/02/2017 22:33:09
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the CloudDebugger v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Examines the call stack and variables of a running application without stopping or slowing it down.
// API Documentation Link http://cloud.google.com/debugger
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/CloudDebugger/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.CloudDebugger.v2/ 
// Install Command: PM>  Install-Package Google.Apis.CloudDebugger.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.CloudDebugger.v2;
using Google.Apis.CloudDebugger.v2.Data;
using System;

namespace GoogleSamplecSharpSample.CloudDebuggerv2.Methods
{
  
    public static class BreakpointsSample
    {

        public class BreakpointsSetOptionalParms
        {
            /// The client version making the call. Following: `domain/type/version` (e.g., `google.com/intellij/v1`).
            public string ClientVersion { get; set; }  
        
        }
 
        /// <summary>
        /// Sets the breakpoint to the debuggee. 
        /// Documentation https://developers.google.com/clouddebugger/v2/reference/breakpoints/set
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudDebugger service.</param>  
        /// <param name="debuggeeId">ID of the debuggee where the breakpoint is to be set.</param>
        /// <param name="body">A valid CloudDebugger v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>SetBreakpointResponseResponse</returns>
        public static SetBreakpointResponse Set(CloudDebuggerService service, string debuggeeId, Breakpoint body, BreakpointsSetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (debuggeeId == null)
                    throw new ArgumentNullException(debuggeeId);

                // Building the initial request.
                var request = service.Breakpoints.Set(body, debuggeeId);

                // Applying optional parameters to the request.                
                request = (BreakpointsResource.SetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Breakpoints.Set failed.", ex);
            }
        }

        public class BreakpointsGetOptionalParms
        {
            /// The client version making the call. Following: `domain/type/version` (e.g., `google.com/intellij/v1`).
            public string ClientVersion { get; set; }  
        
        }
 
        /// <summary>
        /// Gets breakpoint information. 
        /// Documentation https://developers.google.com/clouddebugger/v2/reference/breakpoints/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudDebugger service.</param>  
        /// <param name="debuggeeId">ID of the debuggee whose breakpoint to get.</param>
        /// <param name="breakpointId">ID of the breakpoint to get.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>GetBreakpointResponseResponse</returns>
        public static GetBreakpointResponse Get(CloudDebuggerService service, string debuggeeId, string breakpointId, BreakpointsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (debuggeeId == null)
                    throw new ArgumentNullException(debuggeeId);
                if (breakpointId == null)
                    throw new ArgumentNullException(breakpointId);

                // Building the initial request.
                var request = service.Breakpoints.Get(debuggeeId, breakpointId);

                // Applying optional parameters to the request.                
                request = (BreakpointsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Breakpoints.Get failed.", ex);
            }
        }

        public class BreakpointsDeleteOptionalParms
        {
            /// The client version making the call. Following: `domain/type/version` (e.g., `google.com/intellij/v1`).
            public string ClientVersion { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes the breakpoint from the debuggee. 
        /// Documentation https://developers.google.com/clouddebugger/v2/reference/breakpoints/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudDebugger service.</param>  
        /// <param name="debuggeeId">ID of the debuggee whose breakpoint to delete.</param>
        /// <param name="breakpointId">ID of the breakpoint to delete.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>EmptyResponse</returns>
        public static Empty Delete(CloudDebuggerService service, string debuggeeId, string breakpointId, BreakpointsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (debuggeeId == null)
                    throw new ArgumentNullException(debuggeeId);
                if (breakpointId == null)
                    throw new ArgumentNullException(breakpointId);

                // Building the initial request.
                var request = service.Breakpoints.Delete(debuggeeId, breakpointId);

                // Applying optional parameters to the request.                
                request = (BreakpointsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Breakpoints.Delete failed.", ex);
            }
        }

        public class BreakpointsListOptionalParms
        {
            /// When set to `true`, the response includes the list of breakpoints set by any user. Otherwise, it includes only breakpoints set by the caller.
            public bool IncludeAllUsers { get; set; }  
            /// When set to `true`, the response includes active and inactive breakpoints. Otherwise, it includes only active breakpoints.
            public bool IncludeInactive { get; set; }  
            /// Only breakpoints with the specified action will pass the filter.
            public string Action.value { get; set; }  
            /// When set to `true`, the response breakpoints are stripped of the results fields: `stack_frames`, `evaluated_expressions` and `variable_table`.
            public bool StripResults { get; set; }  
            /// A wait token that, if specified, blocks the call until the breakpoints list has changed, or a server selected timeout has expired. The value should be set from the last response. The error code `google.rpc.Code.ABORTED` (RPC) is returned on wait timeout, which should be called again with the same `wait_token`.
            public string WaitToken { get; set; }  
            /// The client version making the call. Following: `domain/type/version` (e.g., `google.com/intellij/v1`).
            public string ClientVersion { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all breakpoints for the debuggee. 
        /// Documentation https://developers.google.com/clouddebugger/v2/reference/breakpoints/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudDebugger service.</param>  
        /// <param name="debuggeeId">ID of the debuggee whose breakpoints to list.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListBreakpointsResponseResponse</returns>
        public static ListBreakpointsResponse List(CloudDebuggerService service, string debuggeeId, BreakpointsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (debuggeeId == null)
                    throw new ArgumentNullException(debuggeeId);

                // Building the initial request.
                var request = service.Breakpoints.List(debuggeeId);

                // Applying optional parameters to the request.                
                request = (BreakpointsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Breakpoints.List failed.", ex);
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