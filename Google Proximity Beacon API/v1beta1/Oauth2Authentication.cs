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
//     Template File Name:  Oauth.tt
//     Build date: 01/02/2017 22:33:27
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// About 
// 
// Unoffical sample for the Proximitybeacon v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Registers, manages, indexes, and searches beacons.
// API Documentation Link https://developers.google.com/beacons/proximity/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Proximitybeacon/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Proximitybeacon.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Proximitybeacon.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;

namespace GoogleSamplecSharpSample.Proximitybeaconv1beta1.Auth
{  
    public static class Oauth2Example 
    {

        /// <summary>
        /// This method requests Authentcation from a user using Oauth2.  
        /// Credentials are stored in System.Environment.SpecialFolder.Personal
        /// Documentation https://developers.google.com/accounts/docs/OAuth2
        /// </summary>
        /// <param name="clientSecretJson">Path to the client secret json file from Google Developers console.</param>
        /// <param name="userName">Identifying string for the user who is being authentcated.</param>
        /// <returns>DriveService used to make requests against the Drive API</returns>
        public static ProximitybeaconService AuthenticateOauth(string clientSecretJson, string userName)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("userName");
                if (string.IsNullOrEmpty(clientSecretJson))
                    throw new ArgumentNullException("clientSecretJson");
                if (!File.Exists(clientSecretJson))
                    throw new Exception("clientSecretJson file does not exist.");
                
                // These are the scopes of permissions you need. It is best to request only what you need and not all of them
                string[] scopes = new string[] { ProximitybeaconService.Scope.UserlocationBeaconRegistry};	//View and modify your beacons
                UserCredential credential;
                using (var stream = new FileStream(clientSecretJson, FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);

                    // Requesting Authentication or loading previously stored authentication for userName
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                             scopes,
                                                                             userName,
                                                                             CancellationToken.None,
                                                                             new FileDataStore(credPath, true)).Result;
                }

                // Create Drive API service.
                return new ProximitybeaconService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Proximitybeacon Oauth2 Authentication Sample"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Oauth2 account ProximitybeaconService failed" + ex.Message);
                throw new Exception("CreateServiceAccountProximitybeaconFailed", ex);
			}
        }

        /// <summary>
        /// Authenticate to Google Using Oauth2
        /// Documentation https://developers.google.com/accounts/docs/OAuth2
        /// Credentials are stored in System.Environment.SpecialFolder.Personal
        /// </summary>
        /// <param name="clientId">From Google Developer console https://console.developers.google.com</param>
        /// <param name="clientSecret">From Google Developer console https://console.developers.google.com</param>
        /// <param name="userName">Identifying string for the user who is being authentcated.</param>
        /// <returns>SheetsService used to make requests against the Sheets API</returns>
        public static ProximitybeaconService AuthenticateOauth(string clientId, string clientSecret, string userName)
        {
            try
            {

                if (string.IsNullOrEmpty(clientId))
                    throw new ArgumentNullException("clientId");
                if (string.IsNullOrEmpty(clientSecret))
                    throw new ArgumentNullException("clientSecret");
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("userName");

                // These are the scopes of permissions you need. It is best to request only what you need and not all of them                
                string[] scopes = new string[] { ProximitybeaconService.Scope.UserlocationBeaconRegistry};	//View and modify your beacons
								
				var credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = System.IO.Path.Combine(credPath, ".credentials/apiName");

                // Requesting Authentication or loading previously stored authentication for userName
                var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets { ClientId = clientId, ClientSecret = clientSecret }
                                                                                             , scopes
                                                                                             , userName
                                                                                             , CancellationToken.None
                                                                                             , new FileDataStore(credPath, true)).Result;
                // Returning the SheetsService
                return new ProximitybeaconService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Proximitybeacon Oauth2 Authentication Sample"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Oauth2 account ProximitybeaconService failed" + ex.Message);
                throw new Exception("CreateServiceAccountProximitybeaconFailed", ex);
			}
        }
    }
}