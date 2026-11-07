namespace WhatTheGolf.LevelDesigner.Events
{
	public class AudioEvent : BaseEvent<AudioEvent.AudioEventType>
	{
		public enum AudioEventType
		{
			Empty = 0,
			PlaceElement = 1,
			OnBrushStart = 2,
			OnBrushUpdate = 3,
			OnBrushStop = 4,
			OnButtonHoverAny = 5,
			OnButtonDownAny = 6,
			OnObjectHoverAny = 7,
			OnObjectSelectAny = 8,
			OnPublishLevelStart = 9,
			OnPublishLevelSuccess = 10,
			OnPublishLevelFail = 11,
			OnObjectDeleted = 12,
			OnLevelSaved = 13,
			OnLevelDeleted = 14,
			OnUndo = 15,
			OnRedo = 16,
			OnObjectDeleteByEraser = 17,
			OnFail = 18
		}

		public AudioEvent(AudioEventType eventType, object data = null)
			: base(AudioEventType.Empty, (object)null)
		{
		}
	}
}
