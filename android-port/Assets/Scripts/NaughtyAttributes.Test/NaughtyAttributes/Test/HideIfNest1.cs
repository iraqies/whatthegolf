using System;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class HideIfNest1
	{
		public bool hide1;

		public bool hide2;

		public int hideIfAll;

		public int hideIfAny;

		public HideIfNest2 nest2;
	}
}
