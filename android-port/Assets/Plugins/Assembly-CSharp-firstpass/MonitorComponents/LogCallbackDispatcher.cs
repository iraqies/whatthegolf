using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x2000262")]
	public class LogCallbackDispatcher
	{
		[Token(Token = "0x2000263")]
		public delegate void LogCallback(string logString, string stackTrace, LogType type);

		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x0")]
		private static LogCallbackDispatcher instance;

		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<LogCallback> callbacks;

		[Token(Token = "0x170001EB")]
		public static LogCallbackDispatcher Instance
		{
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x13A8D18", Offset = "0x13A8D18", VA = "0x13A8D18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x13A8AD8", Offset = "0x13A8AD8", VA = "0x13A8AD8")]
		public void Add(LogCallback callback)
		{
		}

		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x13A8BA8", Offset = "0x13A8BA8", VA = "0x13A8BA8")]
		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x13A8DF8", Offset = "0x13A8DF8", VA = "0x13A8DF8")]
		public LogCallbackDispatcher()
		{
		}
	}
}
