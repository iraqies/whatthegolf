using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011CE")]
	public class LoginResult : PlayFabLoginResultCommon
	{
		[Token(Token = "0x4005F8A")]
		[FieldOffset(Offset = "0x28")]
		public EntityTokenResponse EntityToken;

		[Token(Token = "0x4005F8B")]
		[FieldOffset(Offset = "0x30")]
		public string PlayFabId;

		[Token(Token = "0x4005F8C")]
		[FieldOffset(Offset = "0x38")]
		public string SessionTicket;

		[Token(Token = "0x6005149")]
		[Address(RVA = "0x154B36C", Offset = "0x154B36C", VA = "0x154B36C")]
		public LoginResult()
		{
		}
	}
}
