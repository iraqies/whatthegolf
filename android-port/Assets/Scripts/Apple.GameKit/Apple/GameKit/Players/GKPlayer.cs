using Il2CppDummyDll;

namespace Apple.GameKit.Players
{
	[Token(Token = "0x2000008")]
	public struct GKPlayer
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		public string Alias;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x8")]
		public string DisplayName;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x10")]
		public string GamePlayerId;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x18")]
		public string TeamPlayerId;
	}
}
