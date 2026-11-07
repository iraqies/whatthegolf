using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class OAuthFlowType : ConstantClass
	{
		public static readonly OAuthFlowType Client_credentials;

		public static readonly OAuthFlowType Code;

		public static readonly OAuthFlowType Implicit;

		public OAuthFlowType(string value)
			: base(null)
		{
		}

		public static OAuthFlowType FindValue(string value)
		{
			return null;
		}

		public static implicit operator OAuthFlowType(string value)
		{
			return null;
		}
	}
}
