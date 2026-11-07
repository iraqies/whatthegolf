using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000277")]
	public static class CognitoIdentityActionIdentifiers
	{
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCognitoIdentityActions;

		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateIdentityPool;

		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DeleteIdentityPool;

		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DescribeIdentityPool;

		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier ListIdentities;

		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier ListIdentityPools;

		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier UpdateIdentityPool;
	}
}
