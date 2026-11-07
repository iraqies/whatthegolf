using System;
using Il2CppDummyDll;

namespace Apple.GameKit.Leaderboards
{
	[Token(Token = "0x2000009")]
	public struct GKLeaderboard
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		public string Identifier;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x8")]
		public string GroupIdentifier;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		public string Title;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x18")]
		public GKLeaderboardType Type;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		public double StartTimeUnixSeconds;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x28")]
		public double NextStartStartUnixSeconds;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x30")]
		public double DurationSeconds;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x38")]
		public GKLeaderboardScore LocalPlayerScore;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x12E8374", Offset = "0x12E8374", VA = "0x12E8374")]
		public DateTimeOffset GetStartTime()
		{
			return default;
		}
	}
}
