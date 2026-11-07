using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
	[Serializable]
	[Token(Token = "0x20011D7")]
	public class GetEntityTokenResponse : PlayFabResultCommon
	{
		[Token(Token = "0x4005F9B")]
		[FieldOffset(Offset = "0x20")]
		public string EntityToken;

		[Token(Token = "0x6005152")]
		[Address(RVA = "0x14859F8", Offset = "0x14859F8", VA = "0x14859F8")]
		public GetEntityTokenResponse()
		{
		}
	}
}
