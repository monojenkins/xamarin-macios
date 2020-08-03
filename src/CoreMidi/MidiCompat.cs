#if !XAMCORE_4_0

using System;

using Foundation;
using ObjCRuntime;

namespace CoreMidi {
#if !COREBUILD
	public delegate void MidiCIPropertyChangedHandler (MidiCISession session, byte channel, NSData data);
	public delegate void MidiCIPropertyResponseHandler (MidiCISession session, byte channel, NSData response, NSError error);

	public partial class MidiCISession {

		[Obsolete ("Always throws NotSupportedException (). (not a public API).")]
		public virtual void GetProperty (NSData inquiry, byte channel, MidiCIPropertyResponseHandler handler)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws NotSupportedException (). (not a public API).")]
		public virtual void HasProperty (NSData inquiry, byte channel, MidiCIPropertyResponseHandler handler)
			=> throw new NotSupportedException ();

		[Obsolete ("Empty stub. (not a public API).")]
		public virtual MidiCIPropertyChangedHandler PropertyChangedCallback { get; set; }

		[Obsolete ("Always throws NotSupportedException (). (not a public API).")]
		public virtual void SetProperty (NSData inquiry, byte channel, MidiCIPropertyResponseHandler handler)
			=> throw new NotSupportedException ();
	} 
#endif

}
#endif
