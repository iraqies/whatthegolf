using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000011")]
	public class DomainStatusType : ConstantClass
	{
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DomainStatusType ACTIVE;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DomainStatusType CREATING;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DomainStatusType DELETING;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DomainStatusType FAILED;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DomainStatusType UPDATING;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x110FF94", Offset = "0x110FF94", VA = "0x110FF94")]
		public DomainStatusType(string value)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1110020", Offset = "0x1110020", VA = "0x1110020")]
		public static DomainStatusType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x110FE08", Offset = "0x110FE08", VA = "0x110FE08")]
		public static implicit operator DomainStatusType(string value)
		{
			return null;
		}
	}
}
