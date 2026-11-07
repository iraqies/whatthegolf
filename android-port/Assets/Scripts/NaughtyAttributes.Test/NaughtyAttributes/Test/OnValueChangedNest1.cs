using System;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class OnValueChangedNest1
	{
		public int int1;

		public OnValueChangedNest2 nest2;
	}
}
