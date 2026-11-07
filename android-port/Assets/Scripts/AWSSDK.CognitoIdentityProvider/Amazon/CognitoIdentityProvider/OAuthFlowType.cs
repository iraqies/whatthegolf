using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200001A")]
	public class OAuthFlowType : ConstantClass
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly OAuthFlowType Client_credentials;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x8")]
		public static readonly OAuthFlowType Code;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		public static readonly OAuthFlowType Implicit;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x113F720", Offset = "0x113F720", VA = "0x113F720")]
		public OAuthFlowType(string value)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x113F7AC", Offset = "0x113F7AC", VA = "0x113F7AC")]
		public static OAuthFlowType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x113F83C", Offset = "0x113F83C", VA = "0x113F83C")]
		public static implicit operator OAuthFlowType(string value)
		{
			return null;
		}
	}
}
