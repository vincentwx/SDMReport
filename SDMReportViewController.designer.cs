// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SDMReport
{
	[Register ("SDMReportViewController")]
	partial class SDMReportViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField c_password { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField c_userName { get; set; }

		[Action ("OnUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OnSign (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (c_password != null) {
				c_password.Dispose ();
				c_password = null;
			}
			if (c_userName != null) {
				c_userName.Dispose ();
				c_userName = null;
			}
		}
	}
}
