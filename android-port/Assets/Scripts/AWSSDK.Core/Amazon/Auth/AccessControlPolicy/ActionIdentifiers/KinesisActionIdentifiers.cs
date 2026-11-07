using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000284")]
	public static class KinesisActionIdentifiers
	{
		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllKinesisActions;

		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateStream;

		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DeleteStream;

		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DescribeStream;

		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier ListStreams;

		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier PutRecord;

		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier GetShardIterator;

		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier GetRecords;

		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier MergeShards;

		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier SplitShard;
	}
}
