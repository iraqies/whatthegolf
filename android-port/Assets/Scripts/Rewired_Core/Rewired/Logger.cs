using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Config;
using Rewired.Internal;

namespace Rewired
{
	[Token(Token = "0x2000092")]
	internal static class Logger
	{
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> __screenLog;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x8")]
		private static GUIText _guiText;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x10")]
		private static bool _logToScreen;

		[Token(Token = "0x17000186")]
		private static List<string> screenLog
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x23E99F8", Offset = "0x23E99F8", VA = "0x23E99F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000187")]
		private static LogLevelFlags logLevel
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x23E9A94", Offset = "0x23E9A94", VA = "0x23E9A94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000188")]
		public static bool logToScreen
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x23E9BFC", Offset = "0x23E9BFC", VA = "0x23E9BFC")]
			set
			{
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x23E039C", Offset = "0x23E039C", VA = "0x23E039C")]
		public static void LogErrorEditor(object msg)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x23E9D84", Offset = "0x23E9D84", VA = "0x23E9D84")]
		public static void LogErrorEditor(object msg, bool requiredThreadSafety)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x23E9E80", Offset = "0x23E9E80", VA = "0x23E9E80")]
		public static void Log(object msg)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x23E9F20", Offset = "0x23E9F20", VA = "0x23E9F20")]
		public static void Log(object msg, bool requiredThreadSafety)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x23E1CAC", Offset = "0x23E1CAC", VA = "0x23E1CAC")]
		public static void LogWarning(object msg)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x23EA8F4", Offset = "0x23EA8F4", VA = "0x23EA8F4")]
		public static void LogWarning(object msg, bool requiredThreadSafety)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x23DD56C", Offset = "0x23DD56C", VA = "0x23DD56C")]
		public static void LogError(object msg)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x23E4F7C", Offset = "0x23E4F7C", VA = "0x23E4F7C")]
		public static void LogError(object msg, bool requiredThreadSafety)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x23EA07C", Offset = "0x23EA07C", VA = "0x23EA07C")]
		private static void LogNow(object msg, bool requireThreadSafety)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x23EAA9C", Offset = "0x23EAA9C", VA = "0x23EAA9C")]
		private static void LogWarningNow(object msg, bool requireThreadSafety)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x23EACA4", Offset = "0x23EACA4", VA = "0x23EACA4")]
		private static void LogErrorNow(object msg, bool requireThreadSafety)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x23E9FD0", Offset = "0x23E9FD0", VA = "0x23E9FD0")]
		private static bool IsLoggingAllowed(LogLevel logLevel)
		{
			return default;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x23EA284", Offset = "0x23EA284", VA = "0x23EA284")]
		private static void LogToScreen(object msg)
		{
		}
	}
}
