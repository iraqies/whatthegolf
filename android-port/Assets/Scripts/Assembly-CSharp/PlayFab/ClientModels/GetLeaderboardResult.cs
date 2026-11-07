using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011CB")]
	public class GetLeaderboardResult : PlayFabResultCommon
	{
		[Token(Token = "0x4005F88")]
		[FieldOffset(Offset = "0x20")]
		public List<PlayerLeaderboardEntry> Leaderboard;

		[Token(Token = "0x6005146")]
		[Address(RVA = "0x1485A18", Offset = "0x1485A18", VA = "0x1485A18")]
		public GetLeaderboardResult()
		{
		}
	}
}
