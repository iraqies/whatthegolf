using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011D1")]
	public class RegisterPlayFabUserResult : PlayFabLoginResultCommon
	{
		[Token(Token = "0x4005F94")]
		[FieldOffset(Offset = "0x28")]
		public EntityTokenResponse EntityToken;

		[Token(Token = "0x4005F95")]
		[FieldOffset(Offset = "0x30")]
		public string PlayFabId;

		[Token(Token = "0x4005F96")]
		[FieldOffset(Offset = "0x38")]
		public string SessionTicket;

		[Token(Token = "0x600514C")]
		[Address(RVA = "0x1648450", Offset = "0x1648450", VA = "0x1648450")]
		public RegisterPlayFabUserResult()
		{
		}
	}
}
