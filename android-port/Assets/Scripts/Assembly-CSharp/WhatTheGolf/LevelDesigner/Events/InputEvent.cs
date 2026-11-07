namespace WhatTheGolf.LevelDesigner.Events
{
	public class InputEvent : BaseEvent<InputEvent.InputEventType>
	{
		public enum InputEventType
		{
			Empty = 0,
			CtrlHotkey = 1
		}

		public InputEvent(InputEventType eventType, object data = null)
			: base(InputEventType.Empty, (object)null)
		{
		}
	}
}
