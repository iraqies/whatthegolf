using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000025")]
	public class VerifySoftwareTokenResponseType : ConstantClass
	{
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VerifySoftwareTokenResponseType ERROR;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x8")]
		public static readonly VerifySoftwareTokenResponseType SUCCESS;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x117B778", Offset = "0x117B778", VA = "0x117B778")]
		public VerifySoftwareTokenResponseType(string value)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x117B804", Offset = "0x117B804", VA = "0x117B804")]
		public static VerifySoftwareTokenResponseType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x117B894", Offset = "0x117B894", VA = "0x117B894")]
		public static implicit operator VerifySoftwareTokenResponseType(string value)
		{
			return null;
		}
	}
}
