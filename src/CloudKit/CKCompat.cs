// Copyright 2016, Xamarin Inc. All rights reserved.

#if !COREBUILD

using System;
using System.Threading.Tasks;

#if MONOMAC || IOS
using Contacts;
#endif
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace CloudKit {

#if !XAMCORE_4_0 && !WATCH
	public partial class CKOperation {

		[Obsoleted (PlatformName.iOS, 9,3, message: "Do not use; this API was removed and will always return 0.")]
		public virtual ulong ActivityStart ()
		{
			return 0;
		}

		[Deprecated (PlatformName.iOS, 9,0, message: "Empty stub (rejected by Apple). Use 'QualityOfService' property.")]
		[Deprecated (PlatformName.MacOSX, 10,11, message: "Empty stub (rejected by Apple). Use 'QualityOfService' property.")]
		public virtual bool UsesBackgroundSession { get; set; }
	}

	public partial class CKNotificationID {

		[Obsolete ("This type is not meant to be created by user code.")]
		public CKNotificationID ()
		{
		}
	}

	public partial class CKContainer {

		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Use 'DiscoverAllIdentities' instead. NotSupportedException'")]
		public virtual void DiscoverAllContactUserInfos (Action<CKDiscoveredUserInfo[], NSError> completionHandler) 
			=> throw new NotSupportedException ();

		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Use 'DiscoverAllIdentities' instead. Always throw a 'NotSupportedException'")]
		public virtual Task<CKDiscoveredUserInfo[]> DiscoverAllContactUserInfosAsync ()
			=> Task.FromException<CKDiscoveredUserInfo[]> (new NotSupportedException ());

		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Use 'DiscoverUserIdentityWithEmailAddress' instead. Always throw a 'NotSupportedException'")]
		public virtual void DiscoverUserInfo (string email, Action<CKDiscoveredUserInfo, NSError> completionHandler)
			=> throw new NotSupportedException ();

		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Use 'DiscoverUserIdentityWithEmailAddress' instead. Always throw a 'NotSupportedException'")]
		public virtual Task<CKDiscoveredUserInfo> DiscoverUserInfoAsync (string email)
			=> Task.FromException<CKDiscoveredUserInfo> (new NotSupportedException ());

		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Use 'DiscoverUserIdentity' instead. Always throw a 'NotSupportedException'")]
		public virtual void DiscoverUserInfo (CKRecordID userRecordId, Action<CKDiscoveredUserInfo, NSError> completionHandler)
			=> throw new NotSupportedException ();

		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Use 'DiscoverUserIdentity' instead. Always throw a 'NotSupportedException'")]
		public virtual Task<CKDiscoveredUserInfo> DiscoverUserInfoAsync (CKRecordID userRecordId)
			=> Task.FromException<CKDiscoveredUserInfo> (new NotSupportedException ());
	}

	public partial class CKDiscoverAllContactsOperation {

		[Obsolete ("Empty stub (not a public API).")]
		public virtual Action<CKDiscoveredUserInfo[], NSError> DiscoverAllContactsHandler { get; set; }

	}

	[iOS (8,0), Mac (10,10)]
	public delegate void CKDiscoverUserInfosCompletionHandler (NSDictionary emailsToUserInfos, NSDictionary userRecordIdsToUserInfos, NSError operationError);
	
	public partial class CKDiscoverUserInfosOperation { 

		[iOS (8,0), Mac (10,10)]
		[Obsolete ("Empty stub (not a public API).")]
		public virtual CKDiscoverUserInfosCompletionHandler Completed { get; set; }
	}

	public partial class CKDiscoverUserInfosOperation {
		[Obsolete ("Always throws NotSupportedException (). (not a public API).")]
		public CKDiscoverUserInfosOperation (string [] emailAddresses, CKRecordID [] userRecordIDs)
			=> throw new NotSupportedException ();

		[Obsolete ("Empty stub (not a public API).")]
		public virtual CKRecordID [] UserRecordIds { get; set; }
	}

	public partial class CKSubscription {
		[Obsolete ("Always throws NotSupportedException (). Use 'CKRecordZoneSubscription'.")]
		public CKSubscription (CKRecordZoneID zoneId, CKSubscriptionOptions subscriptionOptions)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws NotSupportedException (). Use 'CKRecordZoneSubscription'.")]
		public CKSubscription (CKRecordZoneID zoneId, string subscriptionId, CKSubscriptionOptions subscriptionOptions)
			=> throw new NotSupportedException ();
#if !WATCH
		[Obsolete ("Empty stub (not a public API). Use 'CKRecordZoneSubscription'.")]
		public virtual CKSubscriptionOptions SubscriptionOptions { get; }
#endif
	}

	public partial class CKQueryNotification {
		[iOS (8, 0), Mac (10, 10)]
		[Obsolete ("Empty stub (not public API). Use 'DatabaseScope' instead.")]
		public virtual bool IsPublicDatabase { get; }
	}

#if MONOMAC || IOS
	public partial class CKDiscoveredUserInfo {
		[iOS (9,0)][Mac (10,11)]
		[Obsolete ("Empty stub (not public API).")]
		public virtual CNContact DisplayContact { get; }
	}
#endif

#endif

#if WATCH

	public partial class CKModifyBadgeOperation {

		// `init` does not work on watchOS but we can keep compatibility with a different init
		public CKModifyBadgeOperation () : this (0)
		{
		}
	}

	public partial class CKModifyRecordZonesOperation {

		// `init` does not work on watchOS but we can keep compatibility with a different init
		public CKModifyRecordZonesOperation () : this (null, null)
		{
		}
	}

	public partial class CKModifyRecordsOperation {

		// `init` does not work on watchOS but we can keep compatibility with a different init
		public CKModifyRecordsOperation () : this (null, null)
		{
		}
	}
#endif
}

#endif
