﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParserTest {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ParserTest.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to IF (NOT EXISTS (SELECT * 
        ///                 FROM INFORMATION_SCHEMA.TABLES 
        ///                 WHERE TABLE_SCHEMA = &apos;dbo&apos; 
        ///                 AND  TABLE_NAME = &apos;DbRunEvidences&apos;))
        ///BEGIN
        ///	SET ANSI_NULLS ON
        ///	SET QUOTED_IDENTIFIER ON
        ///	CREATE TABLE [dbo].[DbRunEvidences](
        ///		[Id] [bigint] IDENTITY(1,1) NOT NULL,
        ///		[FileName] [nvarchar](1024) NOT NULL,
        ///		[FileHash] [varbinary](max) NOT NULL,
        ///		[DateRun] [datetime] NOT NULL,
        ///		[Author] [nvarchar](1024) NOT NULL,
        ///		[Location] [nvarchar](max) NOT NULL,
        ///	 CON [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateEvicenceDbScript {
            get {
                return ResourceManager.GetString("CreateEvicenceDbScript", resourceCulture);
            }
        }
    }
}
