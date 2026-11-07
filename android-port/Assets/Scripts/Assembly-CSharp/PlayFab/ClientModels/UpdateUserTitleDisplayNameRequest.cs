using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011D5")]
	public class UpdateUserTitleDisplayNameRequest : PlayFabRequestCommon
	{
		[Token(Token = "0x4005F9A")]
		[FieldOffset(Offset = "0x18")]
		public string DisplayName;

		[Token(Token = "0x6005150")]
		[Address(RVA = "0x173D950", Offset = "0x173D950", VA = "0x173D950")]
		public UpdateUserTitleDisplayNameRequest()
		{
		}
	}
}
