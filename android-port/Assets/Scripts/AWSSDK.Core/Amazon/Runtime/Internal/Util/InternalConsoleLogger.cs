using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001CF")]
	internal class InternalConsoleLogger : InternalLogger
	{
		[Token(Token = "0x20001D0")]
		private enum LogLevel
		{
			[Token(Token = "0x40006F9")]
			Verbose = 2,
			[Token(Token = "0x40006FA")]
			Debug = 3,
			[Token(Token = "0x40006FB")]
			Info = 4,
			[Token(Token = "0x40006FC")]
			Warn = 5,
			[Token(Token = "0x40006FD")]
			Error = 6,
			[Token(Token = "0x40006FE")]
			Assert = 7
		}

		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x0")]
		public static long _sequanceId;

		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x1219A18", Offset = "0x1219A18", VA = "0x1219A18")]
		public InternalConsoleLogger(Type declaringType)
		{
		}

		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x1219A20", Offset = "0x1219A20", VA = "0x1219A20", Slot = "4")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x1219A24", Offset = "0x1219A24", VA = "0x1219A24", Slot = "8")]
		public override void Error(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x1219F6C", Offset = "0x1219F6C", VA = "0x1219F6C", Slot = "9")]
		public override void Debug(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x121A00C", Offset = "0x121A00C", VA = "0x121A00C", Slot = "10")]
		public override void DebugFormat(string message, params object[] arguments)
		{
		}

		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x121A0A8", Offset = "0x121A0A8", VA = "0x121A0A8", Slot = "11")]
		public override void InfoFormat(string message, params object[] arguments)
		{
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x1219AC4", Offset = "0x1219AC4", VA = "0x1219AC4")]
		private void Log(LogLevel logLevel, string message, Exception ex)
		{
		}
	}
}
