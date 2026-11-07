using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200001C")]
	public class RecoveryOptionNameType : ConstantClass
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RecoveryOptionNameType Admin_only;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RecoveryOptionNameType Verified_email;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RecoveryOptionNameType Verified_phone_number;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1141DC4", Offset = "0x1141DC4", VA = "0x1141DC4")]
		public RecoveryOptionNameType(string value)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1141E50", Offset = "0x1141E50", VA = "0x1141E50")]
		public static RecoveryOptionNameType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1141EE0", Offset = "0x1141EE0", VA = "0x1141EE0")]
		public static implicit operator RecoveryOptionNameType(string value)
		{
			return null;
		}
	}
}
