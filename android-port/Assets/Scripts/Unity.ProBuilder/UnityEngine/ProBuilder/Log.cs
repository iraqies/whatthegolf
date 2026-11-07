using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	internal static class Log
	{
		private static Stack<LogLevel> s_logStack;

		private static LogLevel s_LogLevel;

		private static LogOutput s_Output;

		private static string s_LogFilePath;

		public static void Warning(string message)
		{
		}

		private static void DoPrint(string message, LogType type)
		{
		}

		private static void PrintToFile(string message, string path)
		{
		}

		private static void PrintToConsole(string message, LogType type = LogType.Log)
		{
		}
	}
}
