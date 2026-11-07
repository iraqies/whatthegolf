using System;

namespace WhatTheGolf.LevelDesigner.Events
{
	public interface IEvent
	{
		object Data { get; }

		Enum EventType { get; }
	}
}
