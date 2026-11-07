using System;
using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	internal sealed class EventsSystem : BaseSystem
	{
		private const int kMaxProcessEventsPerFrame = 5;

		private static Dictionary<Enum, Type> s_EventArgumentMap;

		private static Dictionary<Type, RequireEventHandler> m_EventHandlers;

		private static List<IEvent> m_Events;

		[RuntimeInitializeOnLoadMethod]
		private static void InitOnLoad()
		{
		}

		public static void QueueEvent(IEvent evt)
		{
		}

		public override void Init()
		{
		}

		public override void Update()
		{
		}

		public override void Dispose()
		{
		}

		public static void Register(IRequireEvents consumer)
		{
		}

		public static void Unregister(IRequireEvents consumer)
		{
		}

		private static void ProcessEvent<T>(T evt) where T : IEvent
		{
		}

		private static bool Validate(IEvent evt)
		{
			return false;
		}
	}
}
