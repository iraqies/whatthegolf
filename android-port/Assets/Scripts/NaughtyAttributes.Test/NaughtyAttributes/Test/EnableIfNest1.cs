using System;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class EnableIfNest1
	{
		public bool enable1;

		public bool enable2;

		public int enableIfAll;

		public int enableIfAny;

		public EnableIfNest2 nest2;
	}
}
