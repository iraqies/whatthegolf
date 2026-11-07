namespace WhatTheGolf.LevelDesigner.Events
{
	public class PlayEvent : BaseEvent<PlayEvent.PlayEventType>
	{
		public enum PlayEventType
		{
			Empty = 0,
			Reset = 1,
			HitFlag = 2
		}

		public PlayEvent(PlayEventType eventType, object data = null)
			: base(PlayEventType.Empty, (object)null)
		{
		}
	}
}
