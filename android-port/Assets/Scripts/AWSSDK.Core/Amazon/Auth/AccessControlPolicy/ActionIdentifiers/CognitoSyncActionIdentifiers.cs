using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000278")]
	public static class CognitoSyncActionIdentifiers
	{
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCognitoSyncActions;

		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier DeleteDataset;

		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DescribeDataset;

		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DescribeIdentityUsage;

		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DescribeIdentityPoolUsage;

		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier ListDatasets;

		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier ListIdentityPoolUsage;

		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier ListRecords;

		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier UpdateRecords;
	}
}
