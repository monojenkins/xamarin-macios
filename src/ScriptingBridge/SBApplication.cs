using System;
using System.Reflection;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge {
	public partial class SBApplication
	{
#if XAMCORE_4_0
		public static SBApplication GetApplicationFromBundleIdentifier (string ident)  => Runtime.GetNSObject<SBApplication> (_FromBundleIdentifier (ident));

		public static T GetApplicationFromBundleIdentifier<T> (string ident) where T : SBApplication => Runtime.GetINativeObject<T> (_FromBundleIdentifier (ident), forced_type: true, owns: false);

		public static SBApplication GetApplicationFromUrl (NSUrl url)  => Runtime.GetNSObject<SBApplication> (_FromURL (url) ;

		public static T GetApplicationFromUrl<T> (NSUrl url) where T : SBApplication => Runtime.GetINativeObject<T> (_FromURL (url), forced_type: true, owns: false);

		public static SBApplication GetApplicationFromProcessIdentifier (int pid)  => Runtime.GetNSObject<SBApplication> (_FromProcessIdentifier (pid));

		public static T GetApplicationFromProcessIdentifier<T> (int pid) where T : SBApplication => Runtime.GetINativeObject<T> (_FromProcessIdentifier (pid), forced_type: true, owns: false);
#else
		public static SBApplication FromBundleIdentifier (string ident)  => Runtime.GetNSObject<SBApplication> (_FromBundleIdentifier (ident));

		public static T FromBundleIdentifier<T> (string ident) where T : SBApplication => Runtime.GetINativeObject<T> (_FromBundleIdentifier (ident), forced_type: true, owns: false);

		public static SBApplication FromURL (NSUrl url)  => Runtime.GetNSObject<SBApplication> (_FromURL (url));

		public static T FromURL<T> (NSUrl url) where T : SBApplication => Runtime.GetINativeObject<T> (_FromURL (url), forced_type: true, owns: false);

		public static SBApplication FromProcessIdentifier (int pid)  => Runtime.GetNSObject<SBApplication> (_FromProcessIdentifier (pid));

		public static T FromProcessIdentifier<T> (int pid) where T : SBApplication => Runtime.GetINativeObject<T> (_FromProcessIdentifier (pid), forced_type: true, owns: false);
#endif
	}
}
