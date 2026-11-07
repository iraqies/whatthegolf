using System;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class ReadOnlyNest1
	{
		public float readOnlyFloat;

		public ReadOnlyNest2 nest2;
	}
}
