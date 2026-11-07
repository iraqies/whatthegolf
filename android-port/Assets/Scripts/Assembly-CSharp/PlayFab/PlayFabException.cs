using System;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001184")]
	public class PlayFabException : Exception
	{
		[Token(Token = "0x4005EB4")]
		[FieldOffset(Offset = "0x88")]
		public readonly PlayFabExceptionCode Code;

		[Token(Token = "0x6005019")]
		[Address(RVA = "0x15EBA58", Offset = "0x15EBA58", VA = "0x15EBA58")]
		public PlayFabException(PlayFabExceptionCode code, string message)
		{
		}
	}
}
