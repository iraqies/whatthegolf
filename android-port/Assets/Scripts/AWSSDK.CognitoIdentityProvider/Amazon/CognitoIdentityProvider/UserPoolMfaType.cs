using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000022")]
	public class UserPoolMfaType : ConstantClass
	{
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UserPoolMfaType OFF;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UserPoolMfaType ON;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly UserPoolMfaType OPTIONAL;

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1175334", Offset = "0x1175334", VA = "0x1175334")]
		public UserPoolMfaType(string value)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x11753C0", Offset = "0x11753C0", VA = "0x11753C0")]
		public static UserPoolMfaType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1175450", Offset = "0x1175450", VA = "0x1175450")]
		public static implicit operator UserPoolMfaType(string value)
		{
			return null;
		}
	}
}
