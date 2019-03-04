// Copyright 2019 Microsoft Corporation

#if !COREBUILD

using System;
using System.Runtime.InteropServices;

using Foundation;
using ObjCRuntime;

namespace CoreFoundation {
	
	public class CFMutableString : CFString {

		public CFMutableString (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		protected CFMutableString (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		static extern unsafe /* CFMutableStringRef* */ IntPtr CFStringCreateMutable (/* CFAllocatorRef* */ IntPtr alloc, nint maxLength);

		public CFMutableString (string @string = "", nint maxLength = default (nint))
		{
			// not really needed - but it's consistant with other .ctor
			if (@string == null)
				throw new ArgumentNullException (nameof (@string));
			Handle = CFStringCreateMutable (IntPtr.Zero, maxLength);
			if (@string != null)
				CFStringAppendCharacters (Handle, @string, @string.Length);
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		static extern unsafe /* CFMutableStringRef* */ IntPtr CFStringCreateMutableCopy (/* CFAllocatorRef* */ IntPtr alloc, nint maxLength, /* CFStringRef* */ IntPtr theString);

		public CFMutableString (CFString theString, nint maxLength = default (nint))
		{
			if (theString == null)
				throw new ArgumentNullException (nameof (theString));
			Handle = CFStringCreateMutableCopy (IntPtr.Zero, maxLength, theString.GetHandle ());
		}

		[DllImport (Constants.CoreFoundationLibrary, CharSet=CharSet.Unicode)]
		static extern unsafe void CFStringAppendCharacters (/* CFMutableStringRef* */ IntPtr theString, string chars, nint numChars);

		public void Append (string @string)
		{
			if (@string == null)
				throw new ArgumentNullException (nameof (@string));
			str = null; // destroy any cached value
			CFStringAppendCharacters (Handle, @string, @string.Length);
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		static extern internal bool /* Boolean */ CFStringTransform (/* CFMutableStringRef* */ IntPtr @string, /* CFRange* */ ref CFRange range, /* CFStringRef* */ IntPtr transform, [MarshalAs (UnmanagedType.I1)] /* Boolean */ bool reverse);

		public bool Transform (ref CFRange range, CFStringTransform transform, bool reverse)
		{
			return Transform (ref range, transform.GetConstant ().GetHandle (), reverse);
		}

		// constant documentation mention it also accept any ICT transform
		public bool Transform (ref CFRange range, CFString transform, bool reverse)
		{
			return Transform (ref range, transform.GetHandle (), reverse);
		}

		public bool Transform (ref CFRange range, NSString transform, bool reverse)
		{
			return Transform (ref range, transform.GetHandle (), reverse);
		}

		public bool Transform (ref CFRange range, string transform, bool reverse)
		{
			var t = NSString.CreateNative (transform);
			var ret = Transform (ref range, t, reverse);
			NSString.ReleaseNative (t);
			return ret;
		}

		bool Transform (ref CFRange range, IntPtr transform, bool reverse)
		{
			if (transform == IntPtr.Zero)
				throw new ArgumentNullException (nameof (transform));
			str = null; // destroy any cached value
			return CFStringTransform (Handle, ref range, transform, reverse);
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		static extern internal bool /* Boolean */ CFStringTransform (/* CFMutableStringRef* */ IntPtr @string, /* CFRange* */ IntPtr range, /* CFStringRef* */ IntPtr transform, [MarshalAs (UnmanagedType.I1)] /* Boolean */ bool reverse);

		public bool Transform (CFStringTransform transform, bool reverse)
		{
			return Transform (transform.GetConstant ().GetHandle (), reverse);
		}

		// constant documentation mention it also accept any ICT transform
		public bool Transform (CFString transform, bool reverse)
		{
			return Transform (transform.GetHandle (), reverse);
		}

		public bool Transform (NSString transform, bool reverse)
		{
			return Transform (transform.GetHandle (), reverse);
		}

		public bool Transform (string transform, bool reverse)
		{
			var t = NSString.CreateNative (transform);
			var ret = Transform (t, reverse);
			NSString.ReleaseNative (t);
			return ret;
		}

		bool Transform (IntPtr transform, bool reverse)
		{
			if (transform == IntPtr.Zero)
				throw new ArgumentNullException (nameof (transform));
			str = null; // destroy any cached value
			return CFStringTransform (Handle, IntPtr.Zero, transform, reverse);
		}
	}
}

#endif // !COREBUILD
