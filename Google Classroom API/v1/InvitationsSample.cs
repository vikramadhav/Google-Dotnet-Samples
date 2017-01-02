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
//     Build date: 01/02/2017 22:33:07
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the classroom v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages classes, rosters, and invitations in Google Classroom.
// API Documentation Link https://developers.google.com/classroom/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/classroom/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.classroom.v1/ 
// Install Command: PM>  Install-Package Google.Apis.classroom.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.classroom.v1;
using Google.Apis.classroom.v1.Data;
using System;

namespace GoogleSamplecSharpSample.classroomv1.Methods
{
  
    public static class InvitationsSample
    {


        /// <summary>
        /// Creates an invitation. Only one invitation for a user and course may exist at a time. Delete and re-create an invitation to make changes. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to create invitations for this course or for access errors. * `NOT_FOUND` if the course or the user does not exist. * `FAILED_PRECONDITION` if the requested user's account is disabled or if the user already has this role or a role with greater permissions. * `ALREADY_EXISTS` if an invitation for the specified user and course already exists. 
        /// Documentation https://developers.google.com/classroom/v1/reference/invitations/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated classroom service.</param>  
        /// <param name="body">A valid classroom v1 body.</param>
        /// <returns>InvitationResponse</returns>
        public static Invitation Create(classroomService service, Invitation body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Invitations.Create(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Invitations.Create failed.", ex);
            }
        }


        /// <summary>
        /// Returns an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to view the requested invitation or for access errors. * `NOT_FOUND` if no invitation exists with the requested ID. 
        /// Documentation https://developers.google.com/classroom/v1/reference/invitations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated classroom service.</param>  
        /// <param name="id">Identifier of the invitation to return.</param>
        /// <returns>InvitationResponse</returns>
        public static Invitation Get(classroomService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Invitations.Get(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Invitations.Get failed.", ex);
            }
        }


        /// <summary>
        /// Deletes an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to delete the requested invitation or for access errors. * `NOT_FOUND` if no invitation exists with the requested ID. 
        /// Documentation https://developers.google.com/classroom/v1/reference/invitations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated classroom service.</param>  
        /// <param name="id">Identifier of the invitation to delete.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(classroomService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Invitations.Delete(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Invitations.Delete failed.", ex);
            }
        }

        public class InvitationsListOptionalParms
        {
            /// Restricts returned invitations to those for a specific user. The identifier can be one of the following: * the numeric identifier for the user * the email address of the user * the string literal `"me"`, indicating the requesting user
            public string UserId { get; set; }  
            /// Restricts returned invitations to those for a course with the specified identifier.
            public string CourseId { get; set; }  
            /// Maximum number of items to return. Zero means no maximum. The server may return fewer than the specified number of results.
            public int PageSize { get; set; }  
            /// nextPageToken value returned from a previous list call, indicating that the subsequent page of results should be returned. The list request must be otherwise identical to the one that resulted in this token.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of invitations that the requesting user is permitted to view, restricted to those that match the list request. *Note:* At least one of `user_id` or `course_id` must be supplied. Both fields can be supplied. This method returns the following error codes: * `PERMISSION_DENIED` for access errors. 
        /// Documentation https://developers.google.com/classroom/v1/reference/invitations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated classroom service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListInvitationsResponseResponse</returns>
        public static ListInvitationsResponse List(classroomService service, InvitationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Invitations.List();

                // Applying optional parameters to the request.                
                request = (InvitationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Invitations.List failed.", ex);
            }
        }


        /// <summary>
        /// Accepts an invitation, removing it and adding the invited user to the teachers or students (as appropriate) of the specified course. Only the invited user may accept an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to accept the requested invitation or for access errors. * `FAILED_PRECONDITION` for the following request errors: * CourseMemberLimitReached * CourseNotModifiable * CourseTeacherLimitReached * UserGroupsMembershipLimitReached * `NOT_FOUND` if no invitation exists with the requested ID. 
        /// Documentation https://developers.google.com/classroom/v1/reference/invitations/accept
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated classroom service.</param>  
        /// <param name="id">Identifier of the invitation to accept.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Accept(classroomService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Invitations.Accept(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Invitations.Accept failed.", ex);
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