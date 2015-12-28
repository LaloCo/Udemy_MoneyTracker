// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MoneyTracker.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton earnedButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel moneyLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField moneyTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView movementsTableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton spentButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (earnedButton != null) {
				earnedButton.Dispose ();
				earnedButton = null;
			}
			if (moneyLabel != null) {
				moneyLabel.Dispose ();
				moneyLabel = null;
			}
			if (moneyTextField != null) {
				moneyTextField.Dispose ();
				moneyTextField = null;
			}
			if (movementsTableView != null) {
				movementsTableView.Dispose ();
				movementsTableView = null;
			}
			if (spentButton != null) {
				spentButton.Dispose ();
				spentButton = null;
			}
		}
	}
}
