using System;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class DisableIfNest1
	{
		public bool disable1;

		public bool disable2;

		public int disableIfAll;

		public int disableIfAny;

		public DisableIfNest2 nest2;
	}
}
