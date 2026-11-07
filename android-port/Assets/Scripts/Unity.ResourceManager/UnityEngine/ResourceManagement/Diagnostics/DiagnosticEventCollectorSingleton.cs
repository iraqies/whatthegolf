using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton>
	{
		private static Guid s_editorConnectionGuid;

		internal Dictionary<int, DiagnosticEvent> m_CreatedEvents;

		internal List<DiagnosticEvent> m_UnhandledEvents;

		internal DelegateList<DiagnosticEvent> s_EventHandlers;

		private float m_lastTickSent;

		private int m_lastFrame;

		private float fpsAvg;

		public static Guid PlayerConnectionGuid => default;

		protected override string GetGameObjectName()
		{
			return null;
		}

		public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create)
		{
			return false;
		}

		internal void RegisterEventHandler(Action<DiagnosticEvent> handler)
		{
		}

		public void UnregisterEventHandler(Action<DiagnosticEvent> handler)
		{
		}

		public void PostEvent(DiagnosticEvent diagnosticEvent)
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
