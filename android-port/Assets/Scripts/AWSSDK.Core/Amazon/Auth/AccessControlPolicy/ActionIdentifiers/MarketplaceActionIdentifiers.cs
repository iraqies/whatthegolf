using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000285")]
	public static class MarketplaceActionIdentifiers
	{
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllMarketplaceActions;

		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier Subscribe;

		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier Unsubscribe;

		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier ViewSubscriptions;
	}
}
