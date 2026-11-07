using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class IdentityProviderTypeType : ConstantClass
	{
		public static readonly IdentityProviderTypeType Facebook;

		public static readonly IdentityProviderTypeType Google;

		public static readonly IdentityProviderTypeType LoginWithAmazon;

		public static readonly IdentityProviderTypeType OIDC;

		public static readonly IdentityProviderTypeType SAML;

		public static readonly IdentityProviderTypeType SignInWithApple;

		public IdentityProviderTypeType(string value)
			: base(null)
		{
		}

		public static IdentityProviderTypeType FindValue(string value)
		{
			return null;
		}

		public static implicit operator IdentityProviderTypeType(string value)
		{
			return null;
		}
	}
}
