using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000F2")]
	public static class Warning
	{
		[Token(Token = "0x20000F3")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x132BFA4", Offset = "0x132BFA4", VA = "0x132BFA4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
