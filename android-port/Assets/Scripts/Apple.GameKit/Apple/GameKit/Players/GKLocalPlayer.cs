using Il2CppDummyDll;

namespace Apple.GameKit.Players
{
	[Token(Token = "0x2000007")]
	public struct GKLocalPlayer
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		public string Alias;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		public string DisplayName;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		public string GamePlayerId;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public string TeamPlayerId;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		public bool IsUnderage;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x21")]
		public bool IsMultiplayerGamingRestricted;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x22")]
		public bool IsPersonalizedCommunicationRestricted;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x23")]
		public bool IsAuthenticated;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x12E9644", Offset = "0x12E9644", VA = "0x12E9644")]
		public static implicit operator GKPlayer(GKLocalPlayer localPlayer)
		{
			return default;
		}
	}
}
