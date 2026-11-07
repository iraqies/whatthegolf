using System.Collections.Generic;
using UnityEngine;

namespace MonitorComponents
{
	public class LogCallbackDispatcher
	{
		public delegate void LogCallback(string logString, string stackTrace, LogType type);

		private static LogCallbackDispatcher instance;

		private HashSet<LogCallback> callbacks;

		public static LogCallbackDispatcher Instance => null;

		public void Add(LogCallback callback)
		{
		}

		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}
	}
}
