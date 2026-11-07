using Apple.GameKit.Players;
using Il2CppDummyDll;

namespace Apple.GameKit.Leaderboards
{
	[Token(Token = "0x200000C")]
	public struct GKLeaderboardScore
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		public long Rank;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x8")]
		public long Value;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		public long Context;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		public double UnixSeconds;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public GKPlayer Player;
	}
}
