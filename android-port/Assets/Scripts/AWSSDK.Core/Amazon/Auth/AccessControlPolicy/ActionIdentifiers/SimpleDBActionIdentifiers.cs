using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200028F")]
	public static class SimpleDBActionIdentifiers
	{
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllSimpleDBActions;

		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier BatchDeleteAttributes;

		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier BatchPutAttributes;

		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreateDomain;

		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteAttributes;

		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteDomain;

		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DomainMetadata;

		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier GetAttributes;

		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier ListDomains;

		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier PutAttributes;

		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier Select;
	}
}
