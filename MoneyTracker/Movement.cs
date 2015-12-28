using System;

namespace MoneyTracker
{
	public class Movement
	{
		public bool Type {
			get;
			set;
		}

		public float Amount {
			get;
			set;
		}

		public Movement ()
		{
		}

        public override string ToString()
        {
            if (Type)
            {
                return string.Format("{0:C}", Amount);
            }
            else
            {
                return string.Format("-{0:C}", Amount);
            }
        }
	}
}

