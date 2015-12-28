using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;

namespace MoneyTracker.Droid
{
	[Activity (Label = "MoneyTracker.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		Tracker tracker;
		Button spentButton, earnedButton;
		EditText moneyEditText;
		TextView moneyTextView;
		ListView movementsListView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			tracker = new Tracker ();

			// Get our button from the layout resource,
			// and attach an event to it
			spentButton = FindViewById<Button> (Resource.Id.spentButton);
			earnedButton = FindViewById<Button> (Resource.Id.earnedButton);
			moneyEditText = FindViewById<EditText> (Resource.Id.moneyEditText);
			moneyTextView = FindViewById<TextView> (Resource.Id.moneyTextView);
			movementsListView = FindViewById<ListView> (Resource.Id.movementsListView);

			spentButton.Click += SpentButton_Click;
			earnedButton.Click += EarnedButton_Click;
		}

		void EarnedButton_Click (object sender, System.EventArgs e)
		{
			Movement movement = new Movement ();
			movement.Amount = float.Parse(moneyEditText.Text);
			movement.Type = true;

			tracker.AddMovement (movement);

            movementsListView.Adapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleListItem1, tracker.Movements);

			moneyTextView.Text = string.Format("{0:C}", tracker.Balance);
		}

		void SpentButton_Click (object sender, System.EventArgs e)
		{
			Movement movement = new Movement ();
			movement.Amount = float.Parse(moneyEditText.Text);
			movement.Type = false;

			tracker.AddMovement (movement);

            List<string> ammounts = new List<string> ();
            foreach (var mov in tracker.Movements) 
            {
                ammounts.Add ((mov.Type) ? string.Format ("{0:C}", mov.Amount) : string.Format ("-{0:C}", mov.Amount));
            }
            movementsListView.Adapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleListItem1, tracker.Movements);

			moneyTextView.Text = string.Format("{0:C}", tracker.Balance);
		}
	}
}


