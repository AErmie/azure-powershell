﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Scheduler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Scheduler.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Success.
        /// </summary>
        internal static string CompletedSuccessfully {
            get {
                return ResourceManager.GetString("CompletedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling job collection &apos;{0}&apos;..
        /// </summary>
        internal static string DisableJobCollectionResourceDescription {
            get {
                return ResourceManager.GetString("DisableJobCollectionResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to disable the job collection &apos;{0}&apos; ?.
        /// </summary>
        internal static string DisableJobCollectionResourceWarning {
            get {
                return ResourceManager.GetString("DisableJobCollectionResourceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling job collection &apos;{0}&apos;..
        /// </summary>
        internal static string EnableJobCollectionResourceDescription {
            get {
                return ResourceManager.GetString("EnableJobCollectionResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get job collection..
        /// </summary>
        internal static string GetJobCollectionResourceDescription {
            get {
                return ResourceManager.GetString("GetJobCollectionResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get job history for job &apos;{0}&apos;..
        /// </summary>
        internal static string GetJobHistoryResourceDescription {
            get {
                return ResourceManager.GetString("GetJobHistoryResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get job..
        /// </summary>
        internal static string GetJobResourceDescription {
            get {
                return ResourceManager.GetString("GetJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There&apos;s no job collection for resource name &apos;{0}&apos; and job collection name &apos;{1}&apos;..
        /// </summary>
        internal static string JobCollectionDoesnotExist {
            get {
                return ResourceManager.GetString("JobCollectionDoesnotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum job count quota has a value that is too large; this quota cannot be set higher than &apos;{0}&apos; for free subscriptions(&apos;{1}&apos; was provided). To increase quota, please upgrade to the standard or premium plan..
        /// </summary>
        internal static string JobCollectionMaxJobQuotaTooLargeForFree {
            get {
                return ResourceManager.GetString("JobCollectionMaxJobQuotaTooLargeForFree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum job count quota has a value that is too large; this quota cannot be set higher then &apos;{0}&apos; (&apos;{1}&apos; was provided)..
        /// </summary>
        internal static string JobCollectionMaxJobQuotaTooLargeForPaid {
            get {
                return ResourceManager.GetString("JobCollectionMaxJobQuotaTooLargeForPaid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided MaxRecurrence for job collection Quota &apos;{0}&apos; exceeds the permissible limit for Free collections &apos;{1}&apos;..
        /// </summary>
        internal static string JobCollectionMaxRecurrenceQuotaTooLargeForFree {
            get {
                return ResourceManager.GetString("JobCollectionMaxRecurrenceQuotaTooLargeForFree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided maxRecurrence for job collection quota {0} exceeds the permissible limit ({1})..
        /// </summary>
        internal static string JobCollectionMaxRecurrenceQuotaTooLargeForPaid {
            get {
                return ResourceManager.GetString("JobCollectionMaxRecurrenceQuotaTooLargeForPaid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job collection has reached its quota of &apos;{0}&apos;. Please remove existing jobs before adding new ones..
        /// </summary>
        internal static string JobCollectionReachedQuota {
            get {
                return ResourceManager.GetString("JobCollectionReachedQuota", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There&apos;s no job for resource name &apos;{0}&apos;, job collection name &apos;{1}&apos; and job name &apos;{2}&apos;..
        /// </summary>
        internal static string JobDoesnotExist {
            get {
                return ResourceManager.GetString("JobDoesnotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new http job &apos;{0}&apos;..
        /// </summary>
        internal static string NewHttpJobResourceDescription {
            get {
                return ResourceManager.GetString("NewHttpJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new job collection &apos;{0}&apos;..
        /// </summary>
        internal static string NewJobCollectionResourceDescription {
            get {
                return ResourceManager.GetString("NewJobCollectionResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new service bus queue job &apos;{0}&apos;..
        /// </summary>
        internal static string NewServiceBusQueueJobResourceDescription {
            get {
                return ResourceManager.GetString("NewServiceBusQueueJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new service bus topic job &apos;{0}&apos;..
        /// </summary>
        internal static string NewServiceBusTopicJobResourceDescription {
            get {
                return ResourceManager.GetString("NewServiceBusTopicJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new storage queue job &apos;{0}&apos;..
        /// </summary>
        internal static string NewStorageQueueJobResourceDescription {
            get {
                return ResourceManager.GetString("NewStorageQueueJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing job collection &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveJobCollectionResourceDescription {
            get {
                return ResourceManager.GetString("RemoveJobCollectionResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the job collection &apos;{0}&apos;?.
        /// </summary>
        internal static string RemoveJobCollectionResourceWarning {
            get {
                return ResourceManager.GetString("RemoveJobCollectionResourceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing job &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveJobDescription {
            get {
                return ResourceManager.GetString("RemoveJobDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the job &apos;{0}&apos; ?.
        /// </summary>
        internal static string RemoveJobWarning {
            get {
                return ResourceManager.GetString("RemoveJobWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A job with name &apos;{0}&apos; already exists in job collection &apos;{1}&apos;. Please specify a different name..
        /// </summary>
        internal static string SchedulerExistingJob {
            get {
                return ResourceManager.GetString("SchedulerExistingJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A job collection with name &apos;{0}&apos; already exists in resource group &apos;{1}&apos;. Please specify a different name..
        /// </summary>
        internal static string SchedulerExistingJobCollection {
            get {
                return ResourceManager.GetString("SchedulerExistingJobCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for Secret, Tenant, Audience, and ClientId parameters are required for Http scheduler jobs with ActiveDirectoryOAuth authentication type..
        /// </summary>
        internal static string SchedulerInvalidActiveDirectoryOAuthRequest {
            get {
                return ResourceManager.GetString("SchedulerInvalidActiveDirectoryOAuthRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid authentication type required..
        /// </summary>
        internal static string SchedulerInvalidAuthenticationType {
            get {
                return ResourceManager.GetString("SchedulerInvalidAuthenticationType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for Username and Password parameters are required for Http scheduler jobs with Basic authentication type..
        /// </summary>
        internal static string SchedulerInvalidBasicRequest {
            get {
                return ResourceManager.GetString("SchedulerInvalidBasicRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for ClientCertificatePfx and ClientCertificatePassword parameters are required for Http scheduler jobs with ClientCertificate authentication type..
        /// </summary>
        internal static string SchedulerInvalidClientCertAuthRequest {
            get {
                return ResourceManager.GetString("SchedulerInvalidClientCertAuthRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for Method and Uri parameters are required for Http action job..
        /// </summary>
        internal static string SchedulerInvalidHttpRequest {
            get {
                return ResourceManager.GetString("SchedulerInvalidHttpRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid location entered. Pick one of the locations from Get-AzureSchedulerLocation.
        /// </summary>
        internal static string SchedulerInvalidLocation {
            get {
                return ResourceManager.GetString("SchedulerInvalidLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid resource group entered. Create new resource group or use an existing one..
        /// </summary>
        internal static string SchedulerInvalidResourceGroup {
            get {
                return ResourceManager.GetString("SchedulerInvalidResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for Namespace, Message, and TransportType parameters are required for ServiceBus job..
        /// </summary>
        internal static string SchedulerInvalidServiceBus {
            get {
                return ResourceManager.GetString("SchedulerInvalidServiceBus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for QueueName required for ServiceBus Queue action job..
        /// </summary>
        internal static string SchedulerInvalidServiceBusQueueName {
            get {
                return ResourceManager.GetString("SchedulerInvalidServiceBusQueueName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for TopicPath required for ServiceBus Topic action job..
        /// </summary>
        internal static string SchedulerInvalidServiceBusTopicPath {
            get {
                return ResourceManager.GetString("SchedulerInvalidServiceBusTopicPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value for StorageQueueAccount, StorageQueueName, SASToken, and StorageQueueMessage parameters are required for Storage queue job..
        /// </summary>
        internal static string SchedulerInvalidStorageQueue {
            get {
                return ResourceManager.GetString("SchedulerInvalidStorageQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; sheme is not supported. Supports &quot;http or https&quot; scheme..
        /// </summary>
        internal static string SchedulerInvalidUriScheme {
            get {
                return ResourceManager.GetString("SchedulerInvalidUriScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content-Type must be provided with body.
        /// </summary>
        internal static string SchedulerNoJobContentType {
            get {
                return ResourceManager.GetString("SchedulerNoJobContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The subscription already has a free job collection. Only one free job collection can be created per subscription..
        /// </summary>
        internal static string SchedulerNoMoreFreeJobCollection {
            get {
                return ResourceManager.GetString("SchedulerNoMoreFreeJobCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update existing http job &apos;{0}&apos;..
        /// </summary>
        internal static string UpdateHttpJobResourceDescription {
            get {
                return ResourceManager.GetString("UpdateHttpJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update existing job collection &apos;{0}&apos;..
        /// </summary>
        internal static string UpdateJobCollectionResourceDescription {
            get {
                return ResourceManager.GetString("UpdateJobCollectionResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update existing service bus queue job &apos;{0}&apos;..
        /// </summary>
        internal static string UpdateServiceBusQueueJobResourceDescription {
            get {
                return ResourceManager.GetString("UpdateServiceBusQueueJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update existing service bus topic job &apos;{0}&apos;..
        /// </summary>
        internal static string UpdateServiceBusTopicJobResourceDescription {
            get {
                return ResourceManager.GetString("UpdateServiceBusTopicJobResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update existing storage queue job &apos;{0}&apos;..
        /// </summary>
        internal static string UpdateStorageQueueJobResourceDescription {
            get {
                return ResourceManager.GetString("UpdateStorageQueueJobResourceDescription", resourceCulture);
            }
        }
    }
}