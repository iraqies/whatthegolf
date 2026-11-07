using System;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	public class DiagnosticEventCollector : MonoBehaviour
	{
		private static DiagnosticEventCollector s_Collector;

		public static Guid PlayerConnectionGuid => default;

		public static DiagnosticEventCollector FindOrCreateGlobalInstance()
		{
			return null;
		}

		public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create)
		{
			return false;
		}

		public void UnregisterEventHandler(Action<DiagnosticEvent> handler)
		{
		}

		public void PostEvent(DiagnosticEvent diagnosticEvent)
		{
		}
	}
}
