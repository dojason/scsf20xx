﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.SmartClient.DisconnectedAgent.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.SmartClient.DisconnectedAgent.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A Request with Id {0} is already queued..
        /// </summary>
        internal static string CannotEnqueueDuplicatedRequests {
            get {
                return ResourceManager.GetString("CannotEnqueueDuplicatedRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConnectionMonitors.
        /// </summary>
        internal static string ConnectionMonitorSectionName {
            get {
                return ResourceManager.GetString("ConnectionMonitorSectionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Endpoint doesn&apos;t exist in the catalog..
        /// </summary>
        internal static string ExceptionEndpointNotInCatalog {
            get {
                return ResourceManager.GetString("ExceptionEndpointNotInCatalog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} doesnt exist for the {1} endpoint..
        /// </summary>
        internal static string ExceptionNetworkNotInEndpoint {
            get {
                return ResourceManager.GetString("ExceptionNetworkNotInEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undefined default credential for the {0} endpoint..
        /// </summary>
        internal static string ExceptionNonDefault {
            get {
                return ResourceManager.GetString("ExceptionNonDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception thrown on return callback: .
        /// </summary>
        internal static string ExceptionOnReturnCallback {
            get {
                return ResourceManager.GetString("ExceptionOnReturnCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception ocurred while calling the method {0} on the web proxy..
        /// </summary>
        internal static string ExceptionWebServiceProxyFactory {
            get {
                return ResourceManager.GetString("ExceptionWebServiceProxyFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified section is invalid.
        /// </summary>
        internal static string InvalidSection {
            get {
                return ResourceManager.GetString("InvalidSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get current connection price if the device is not connected..
        /// </summary>
        internal static string PriceNotConnection {
            get {
                return ResourceManager.GetString("PriceNotConnection", resourceCulture);
            }
        }
    }
}
