using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000024")]
	public class VerifiedAttributeType : ConstantClass
	{
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VerifiedAttributeType Email;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x8")]
		public static readonly VerifiedAttributeType Phone_number;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x117A774", Offset = "0x117A774", VA = "0x117A774")]
		public VerifiedAttributeType(string value)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x117A800", Offset = "0x117A800", VA = "0x117A800")]
		public static VerifiedAttributeType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x117A890", Offset = "0x117A890", VA = "0x117A890")]
		public static implicit operator VerifiedAttributeType(string value)
		{
			return null;
		}
	}
}
