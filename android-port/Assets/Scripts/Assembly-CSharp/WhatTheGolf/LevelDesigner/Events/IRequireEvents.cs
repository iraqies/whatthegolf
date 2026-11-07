namespace WhatTheGolf.LevelDesigner.Events
{
	public interface IRequireEvents
	{
	}
	public interface IRequireEvents<T> : IRequireEvents where T : IEvent
	{
		void OnEvent(T evt);
	}
}
