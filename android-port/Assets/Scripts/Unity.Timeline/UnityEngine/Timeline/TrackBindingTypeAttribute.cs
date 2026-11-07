using System;

namespace UnityEngine.Timeline
{
	public class TrackBindingTypeAttribute : Attribute
	{
		public readonly Type type;

		public readonly TrackBindingFlags flags;

		public TrackBindingTypeAttribute(Type type)
		{
		}

		public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags)
		{
		}
	}
}
