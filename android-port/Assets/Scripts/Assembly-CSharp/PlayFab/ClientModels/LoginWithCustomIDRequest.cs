using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011CF")]
	public class LoginWithCustomIDRequest : PlayFabRequestCommon
	{
		[Token(Token = "0x4005F8D")]
		[FieldOffset(Offset = "0x18")]
		public bool? CreateAccount;

		[Token(Token = "0x4005F8E")]
		[FieldOffset(Offset = "0x20")]
		public string CustomId;

		[Token(Token = "0x4005F8F")]
		[FieldOffset(Offset = "0x28")]
		public string TitleId;

		[Token(Token = "0x600514A")]
		[Address(RVA = "0x154B374", Offset = "0x154B374", VA = "0x154B374")]
		public LoginWithCustomIDRequest()
		{
		}
	}
}
