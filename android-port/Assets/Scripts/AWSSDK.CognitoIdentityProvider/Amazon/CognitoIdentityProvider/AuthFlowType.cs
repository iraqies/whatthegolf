using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class AuthFlowType : ConstantClass
	{
		public static readonly AuthFlowType ADMIN_NO_SRP_AUTH;

		public static readonly AuthFlowType ADMIN_USER_PASSWORD_AUTH;

		public static readonly AuthFlowType CUSTOM_AUTH;

		public static readonly AuthFlowType REFRESH_TOKEN;

		public static readonly AuthFlowType REFRESH_TOKEN_AUTH;

		public static readonly AuthFlowType USER_PASSWORD_AUTH;

		public static readonly AuthFlowType USER_SRP_AUTH;

		public AuthFlowType(string value)
			: base(null)
		{
		}

		public static AuthFlowType FindValue(string value)
		{
			return null;
		}

		public static implicit operator AuthFlowType(string value)
		{
			return null;
		}
	}
}
