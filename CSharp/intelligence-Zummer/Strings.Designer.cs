﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zummer {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Zummer.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Hmm... I did not understand that. Rephrase your message and try again..
        /// </summary>
        internal static string FallbackIntentMessage {
            get {
                return ResourceManager.GetString("FallbackIntentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read Full Article.
        /// </summary>
        internal static string FullArticleString {
            get {
                return ResourceManager.GetString("FullArticleString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi! What would you like to read about? I can fetch you the best Wikipedia results on any subject..
        /// </summary>
        internal static string GreetOnDemand {
            get {
                return ResourceManager.GetString("GreetOnDemand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More on Bing.
        /// </summary>
        internal static string MoreOnBing {
            get {
                return ResourceManager.GetString("MoreOnBing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Powered by {0}.
        /// </summary>
        internal static string PowerBy {
            get {
                return ResourceManager.GetString("PowerBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here you go..
        /// </summary>
        internal static string SearchTopicTypeMessage {
            get {
                return ResourceManager.GetString("SearchTopicTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hmm, I&apos;m sorry. I could not summarize the article..
        /// </summary>
        internal static string SummaryErrorMessage {
            get {
                return ResourceManager.GetString("SummaryErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Summary.
        /// </summary>
        internal static string SummaryString {
            get {
                return ResourceManager.GetString("SummaryString", resourceCulture);
            }
        }
    }
}
