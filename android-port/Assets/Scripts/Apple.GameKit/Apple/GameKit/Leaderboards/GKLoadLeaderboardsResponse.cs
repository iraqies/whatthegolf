using System;
using Il2CppDummyDll;

namespace Apple.GameKit.Leaderboards
{
	[Token(Token = "0x2000010")]
	public struct GKLoadLeaderboardsResponse
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr Leaderboards;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x8")]
		public int LeaderboardsLength;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x12E8FDC", Offset = "0x12E8FDC", VA = "0x12E8FDC")]
		public GKLeaderboard[] GetLeaderboards()
		{
			return null;
		}
	}
}
