﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdaptIt2Unicode.Properties {
	using System;


	/// <summary>
	///   A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated by the StronglyTypedResourceBuilder
	// class via a tool like ResGen or Visual Studio.
	// To add or remove a member, edit your .ResX file then rerun ResGen
	// with the /str option, or rebuild your VS project.
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AdaptIt2Unicode.Properties.Resources", typeof(Resources).Assembly);
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
		///   Looks up a localized string similar to
		///The conversion of the Adapt It project configuration file and knowledge bases
		///is complete! The next time you open AdaptIt Unicode, your new Unicode project
		///&apos;{0}&apos; will be available.
		///
		///If you would like the adapted texts to be converted to Unicode as well, then
		///click the &apos;Retry&apos; button below.
		///
		///However beware: only the SFM fields that aren&apos;t filtered will be converted! If you
		///have legacy data in filtered SFM fields, that data will not be converted to Unicode
		///(and will likely be unrecoverable after [rest of string was truncated]&quot;;.
		/// </summary>
		internal static string ConversionCompleteString {
			get {
				return ResourceManager.GetString("ConversionCompleteString", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to
		///This table lists all of the filtered fields found in the current document. Check the box in the
		///&apos;Convert&apos; column for all fields that contain legacy data in the Source language. Those fields
		///will be converted to Unicode using the configured Source language converter.
		///
		///If a field contains English data (e.g. an English back translation) or arabic numeral data
		///(e.g. verse or chapter numbers), then they don&apos;t need to be checked because such Ascii data
		///are already in the proper format (aka. UTF-8).
		///        /// [rest of string was truncated]&quot;;.
		/// </summary>
		internal static string FilteredFieldConversionHelp {
			get {
				return ResourceManager.GetString("FilteredFieldConversionHelp", resourceCulture);
			}
		}
	}
}
