// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtp {

	using System;

	public delegate void AddExtensionHandler(object o, AddExtensionArgs args);

	public class AddExtensionArgs : GLib.SignalArgs {
		public Gst.Rtp.RTPHeaderExtension Ext{
			get {
				return (Gst.Rtp.RTPHeaderExtension) Args [0];
			}
		}

	}
}
