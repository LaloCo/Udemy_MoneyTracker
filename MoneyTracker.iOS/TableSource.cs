using System;
using UIKit;
using System.Collections.Generic;

namespace MoneyTracker.iOS
{
	public class TableSource : UITableViewSource
	{
		private string cellIdentifier = "movementCellIdentifier";
		private List<Movement> movements;

		public TableSource (List<Movement> movements, string cellIdentifier = "movementCellIdentifier")
		{
			this.movements = movements;
			this.cellIdentifier = cellIdentifier;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return movements.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);

			var movement = movements [indexPath.Row];

			string movementAmount = (movement.Type) ? string.Format ("{0:C}", movement.Amount) : string.Format ("-{0:C}", movement.Amount);

			if (cell == null) 
			{
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = movementAmount;

			return cell;
		}
	}
}

