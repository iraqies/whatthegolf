using System;
using Il2CppDummyDll;

namespace Apple.GameKit.Leaderboards
{
	[Token(Token = "0x200000F")]
	public struct GKLoadLeaderboardScoresResponse
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		public GKLeaderboardScore LocalScore;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		public IntPtr ScoreEntriesData;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x48")]
		public int ScoreEntriesLength;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x12E9498", Offset = "0x12E9498", VA = "0x12E9498")]
		public GKLeaderboardScore[] GetScoreEntries()
		{
			return null;
		}
	}
}
