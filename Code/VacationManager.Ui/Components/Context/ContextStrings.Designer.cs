﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VacationManager.Ui.Components.Context {
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
    public class ContextStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ContextStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VacationManager.Ui.Components.Context.ContextStrings", typeof(ContextStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executive.
        /// </summary>
        public static string ExecutiveRole {
            get {
                return ResourceManager.GetString("ExecutiveRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hr.
        /// </summary>
        public static string HrRole {
            get {
                return ResourceManager.GetString("HrRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manager.
        /// </summary>
        public static string ManagerRole {
            get {
                return ResourceManager.GetString("ManagerRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your roles are: {0}.
        /// </summary>
        public static string RolesMessageFormat {
            get {
                return ResourceManager.GetString("RolesMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi, {0} {1}..
        /// </summary>
        public static string WelcomeMessageFormat {
            get {
                return ResourceManager.GetString("WelcomeMessageFormat", resourceCulture);
            }
        }
    }
}