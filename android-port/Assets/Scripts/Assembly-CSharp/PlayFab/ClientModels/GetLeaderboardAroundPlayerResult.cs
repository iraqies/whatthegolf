using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011C9")]
	public class GetLeaderboardAroundPlayerResult : PlayFabResultCommon
	{
		[Token(Token = "0x4005F84")]
		[FieldOffset(Offset = "0x20")]
		public List<PlayerLeaderboardEntry> Leaderboard;

		[Token(Token = "0x6005144")]
		[Address(RVA = "0x1485A08", Offset = "0x1485A08", VA = "0x1485A08")]
		public GetLeaderboardAroundPlayerResult()
		{
		}
	}
}
