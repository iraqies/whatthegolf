using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000270")]
	public static class BillingActionIdentifiers
	{
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllBillingActions;

		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier ModifyAccount;

		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier ModifyBilling;

		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier ModifyPaymentMethods;

		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier ViewAccount;

		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier ViewBilling;

		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier ViewPaymentMethods;

		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier ViewUsage;
	}
}
