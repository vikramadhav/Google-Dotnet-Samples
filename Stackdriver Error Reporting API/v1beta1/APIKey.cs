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
//     Template File Name:  APIKey.tt
//     Build date: 01/02/2017 22:32:06
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the Clouderrorreporting v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Stackdriver Error Reporting groups and counts similar errors from cloud services. The Stackdriver Error Reporting API provides a way to report new errors and read access to error groups and their associated errors.

// API Documentation Link https://cloud.google.com/error-reporting/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Clouderrorreporting/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Clouderrorreporting.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Clouderrorreporting.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Clouderrorreporting.v1beta1;
using Google.Apis.Services;
using System;

namespace GoogleSamplecSharpSample.Clouderrorreportingv1beta1.Auth
{
    public static class ApiKeyExample
    {
        public static ClouderrorreportingService GetService(string apiKey)
        {
            try
            {
                if (string.IsNullOrEmpty(apiKey))
                    throw new ArgumentNullException("api Key");

                return new ClouderrorreportingService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,
                    ApplicationName = "Clouderrorreporting API key example",
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create new Clouderrorreporting Service", ex);
            }
        }
    }
}
