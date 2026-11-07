using System.Collections.Generic;
using Rewired.Config;
using Rewired.Internal;

namespace Rewired
{
	internal static class Logger
	{
		private static List<string> __screenLog;

		private static GUIText _guiText;

		private static bool _logToScreen;

		private static List<string> screenLog => null;

		private static LogLevelFlags logLevel => LogLevelFlags.Off;

		public static bool logToScreen
		{
			set
			{
			}
		}

		public static void LogErrorEditor(object msg)
		{
		}

		public static void LogErrorEditor(object msg, bool requiredThreadSafety)
		{
		}

		public static void Log(object msg)
		{
		}

		public static void Log(object msg, bool requiredThreadSafety)
		{
		}

		public static void LogWarning(object msg)
		{
		}

		public static void LogWarning(object msg, bool requiredThreadSafety)
		{
		}

		public static void LogError(object msg)
		{
		}

		public static void LogError(object msg, bool requiredThreadSafety)
		{
		}

		private static void LogNow(object msg, bool requireThreadSafety)
		{
		}

		private static void LogWarningNow(object msg, bool requireThreadSafety)
		{
		}

		private static void LogErrorNow(object msg, bool requireThreadSafety)
		{
		}

		private static bool IsLoggingAllowed(LogLevel logLevel)
		{
			return false;
		}

		private static void LogToScreen(object msg)
		{
		}
	}
}
