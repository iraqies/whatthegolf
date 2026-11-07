using System;

namespace WhatTheGolf.LevelDesigner.Events
{
	public abstract class BaseEvent<T> : IEvent where T : Enum
	{
		public T EventType { get; }

		public virtual object Data { get; set; }

		Enum IEvent.EventType => null;

		public BaseEvent(T eventType, object data = null)
		{
		}
	}
}
