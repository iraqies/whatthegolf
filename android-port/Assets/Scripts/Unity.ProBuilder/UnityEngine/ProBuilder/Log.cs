using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x200000F")]
	internal static class Log
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		private static Stack<LogLevel> s_logStack;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		private static LogLevel s_LogLevel;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xC")]
		private static LogOutput s_Output;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		private static string s_LogFilePath;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2A4A4B4", Offset = "0x2A4A4B4", VA = "0x2A4A4B4")]
		public static void Warning(string message)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2A4A554", Offset = "0x2A4A554", VA = "0x2A4A554")]
		private static void DoPrint(string message, LogType type)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A4A778", Offset = "0x2A4A778", VA = "0x2A4A778")]
		private static void PrintToFile(string message, string path)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2A4A648", Offset = "0x2A4A648", VA = "0x2A4A648")]
		private static void PrintToConsole(string message, LogType type = LogType.Log)
		{
		}
	}
}
