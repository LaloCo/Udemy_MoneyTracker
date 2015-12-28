using System;
using System.Collections.Generic;

namespace MoneyTracker
{
	public class Tracker
	{
		public float Balance { get; set; }

		public List<Movement> Movements { get; set; }

		public Tracker ()
		{
			Movements = new List<Movement> ();
		}

		public void AddMovement(Movement movement)
		{
			Movements.Add (movement);

			Balance += (movement.Type) ? movement.Amount : -movement.Amount;
		}
	}
}

