using System;
using System.Collections.Generic;

namespace WhatTheGolf.LevelDesigner.Events
{
	public abstract class RequireEventHandler
	{
		public abstract void Register(IRequireEvents obj);

		public abstract void Unregister(IRequireEvents obj);

		public abstract void ProcessEvent(IEvent evt);
	}
	public class RequireEventHandler<T> : RequireEventHandler, IDisposable where T : IEvent
	{
		private List<IRequireEvents<T>> m_RequireEvents;

		public override void ProcessEvent(IEvent evt)
		{
		}

		public override void Register(IRequireEvents obj)
		{
		}

		public override void Unregister(IRequireEvents obj)
		{
		}

		public void Dispose()
		{
		}
	}
}
