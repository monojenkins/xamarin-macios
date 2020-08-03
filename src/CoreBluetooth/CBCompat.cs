#if !XAMCORE_4_0
using ObjCRuntime;
using Foundation;
using System;
using CoreFoundation;

namespace CoreBluetooth {

#if IOS || MONOMAC

#pragma warning disable CS0809

	public partial class CBMutableCharacteristic {
		[Obsolete ("The setter is an empty stub (not mutable)")]
		public override CBUUID UUID { 
			get { return base.UUID; }
			set {  }
		}
	}

	public partial class CBMutableService  {

		[Obsolete ("The setter is an empty stub (not mutable)")]
		public override bool Primary { 
			get { return base.Primary; }
			set {  }
		}

		[Obsolete ("The setter is an empty stub (not mutable)")]
		public override CBUUID UUID { 
			get { return base.UUID; }
			set {  }
		}
	}

	public partial class CBCentralManager {

		[Obsolete ("Empty stub. (not a public API).")]
		public virtual void RetrieveConnectedPeripherals () {}
	}

#pragma warning restore CS0809

#endif
}
#endif
