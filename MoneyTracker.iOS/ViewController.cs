using System;

using UIKit;

namespace MoneyTracker.iOS
{
	public partial class ViewController : UIViewController
	{
		Tracker tracker;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			tracker = new Tracker ();

			earnedButton.TouchUpInside += EarnedButton_TouchUpInside;
			spentButton.TouchUpInside += SpentButton_TouchUpInside;

			movementsTableView.Source = new TableSource (tracker.Movements);
		}

		void SpentButton_TouchUpInside (object sender, EventArgs e)
		{
			Movement movement = new Movement ();
			movement.Amount = float.Parse(moneyTextField.Text);
			movement.Type = false;

			tracker.AddMovement (movement);
			movementsTableView.Source = new TableSource (tracker.Movements);
			movementsTableView.ReloadData ();

			moneyLabel.Text = string.Format("{0:C}", tracker.Balance);
		}

		void EarnedButton_TouchUpInside (object sender, EventArgs e)
		{
			Movement movement = new Movement ();
			movement.Amount = float.Parse(moneyTextField.Text);
			movement.Type = true;

			tracker.AddMovement (movement);
			movementsTableView.Source = new TableSource (tracker.Movements);
			movementsTableView.ReloadData ();

			moneyLabel.Text = string.Format("{0:C}", tracker.Balance);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

