using System;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class ShowIfNest1
	{
		public bool show1;

		public bool show2;

		public int showIfAll;

		public int showIfAny;

		public ShowIfNest2 nest2;
	}
}
