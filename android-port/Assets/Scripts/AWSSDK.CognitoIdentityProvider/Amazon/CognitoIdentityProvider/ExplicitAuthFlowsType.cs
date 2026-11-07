using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class ExplicitAuthFlowsType : ConstantClass
	{
		public static readonly ExplicitAuthFlowsType ADMIN_NO_SRP_AUTH;

		public static readonly ExplicitAuthFlowsType ALLOW_ADMIN_USER_PASSWORD_AUTH;

		public static readonly ExplicitAuthFlowsType ALLOW_CUSTOM_AUTH;

		public static readonly ExplicitAuthFlowsType ALLOW_REFRESH_TOKEN_AUTH;

		public static readonly ExplicitAuthFlowsType ALLOW_USER_PASSWORD_AUTH;

		public static readonly ExplicitAuthFlowsType ALLOW_USER_SRP_AUTH;

		public static readonly ExplicitAuthFlowsType CUSTOM_AUTH_FLOW_ONLY;

		public static readonly ExplicitAuthFlowsType USER_PASSWORD_AUTH;

		public ExplicitAuthFlowsType(string value)
			: base(null)
		{
		}

		public static ExplicitAuthFlowsType FindValue(string value)
		{
			return null;
		}

		public static implicit operator ExplicitAuthFlowsType(string value)
		{
			return null;
		}
	}
}
