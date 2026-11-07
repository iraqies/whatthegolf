using System;

namespace UnityEngine.Timeline
{
	internal class SupportsChildTracksAttribute : Attribute
	{
		public readonly Type childType;

		public readonly int levels;

		public SupportsChildTracksAttribute(Type childType = null, int levels = int.MaxValue)
		{
		}
	}
}
