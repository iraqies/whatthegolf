using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000018")]
	public class IdentityProviderTypeType : ConstantClass
	{
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IdentityProviderTypeType Facebook;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x8")]
		public static readonly IdentityProviderTypeType Google;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x10")]
		public static readonly IdentityProviderTypeType LoginWithAmazon;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly IdentityProviderTypeType OIDC;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly IdentityProviderTypeType SAML;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly IdentityProviderTypeType SignInWithApple;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1128118", Offset = "0x1128118", VA = "0x1128118")]
		public IdentityProviderTypeType(string value)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x11281A4", Offset = "0x11281A4", VA = "0x11281A4")]
		public static IdentityProviderTypeType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1128234", Offset = "0x1128234", VA = "0x1128234")]
		public static implicit operator IdentityProviderTypeType(string value)
		{
			return null;
		}
	}
}
