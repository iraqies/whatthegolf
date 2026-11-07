using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000005")]
	public class AccountTakeoverEventActionType : ConstantClass
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AccountTakeoverEventActionType BLOCK;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AccountTakeoverEventActionType MFA_IF_CONFIGURED;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AccountTakeoverEventActionType MFA_REQUIRED;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		public static readonly AccountTakeoverEventActionType NO_ACTION;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1098C90", Offset = "0x1098C90", VA = "0x1098C90")]
		public AccountTakeoverEventActionType(string value)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1098D1C", Offset = "0x1098D1C", VA = "0x1098D1C")]
		public static AccountTakeoverEventActionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1098444", Offset = "0x1098444", VA = "0x1098444")]
		public static implicit operator AccountTakeoverEventActionType(string value)
		{
			return null;
		}
	}
}
