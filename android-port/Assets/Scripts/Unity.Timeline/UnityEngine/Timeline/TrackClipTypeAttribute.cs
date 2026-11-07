using System;

namespace UnityEngine.Timeline
{
	public class TrackClipTypeAttribute : Attribute
	{
		public readonly Type inspectedType;

		public readonly bool allowAutoCreate;

		public TrackClipTypeAttribute(Type clipClass)
		{
		}

		public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
		{
		}
	}
}
