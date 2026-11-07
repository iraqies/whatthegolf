using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011CA")]
	public class GetLeaderboardRequest : PlayFabRequestCommon
	{
		[Token(Token = "0x4005F85")]
		[FieldOffset(Offset = "0x18")]
		public int? MaxResultsCount;

		[Token(Token = "0x4005F86")]
		[FieldOffset(Offset = "0x20")]
		public int StartPosition;

		[Token(Token = "0x4005F87")]
		[FieldOffset(Offset = "0x28")]
		public string StatisticName;

		[Token(Token = "0x6005145")]
		[Address(RVA = "0x1485A10", Offset = "0x1485A10", VA = "0x1485A10")]
		public GetLeaderboardRequest()
		{
		}
	}
}
