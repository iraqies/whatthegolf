using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011C8")]
	public class GetLeaderboardAroundPlayerRequest : PlayFabRequestCommon
	{
		[Token(Token = "0x4005F82")]
		[FieldOffset(Offset = "0x18")]
		public int? MaxResultsCount;

		[Token(Token = "0x4005F83")]
		[FieldOffset(Offset = "0x20")]
		public string StatisticName;

		[Token(Token = "0x6005143")]
		[Address(RVA = "0x1485A00", Offset = "0x1485A00", VA = "0x1485A00")]
		public GetLeaderboardAroundPlayerRequest()
		{
		}
	}
}
