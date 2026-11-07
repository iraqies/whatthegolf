using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000292")]
	public static class SQSActionIdentifiers
	{
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllSQSActions;

		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier AddPermission;

		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier ChangeMessageVisibility;

		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreateQueue;

		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteMessage;

		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteQueue;

		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier GetQueueAttributes;

		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier GetQueueUrl;

		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier ListQueues;

		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier ReceiveMessage;

		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier RemovePermission;

		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier SendMessage;

		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier SetQueueAttributes;
	}
}
