using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200027A")]
	public static class DynamoDBActionIdentifiers
	{
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllDynamoDBActions;

		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier BatchGetItem;

		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier BatchWriteItem;

		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreateTable;

		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteItem;

		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteTable;

		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DescribeTable;

		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier GetItem;

		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier ListTables;

		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier PutItem;

		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier Query;

		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier Scan;

		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier UpdateItem;

		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier UpdateTable;
	}
}
