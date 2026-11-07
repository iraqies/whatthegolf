using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class UserPoolMfaType : ConstantClass
	{
		public static readonly UserPoolMfaType OFF;

		public static readonly UserPoolMfaType ON;

		public static readonly UserPoolMfaType OPTIONAL;

		public UserPoolMfaType(string value)
			: base(null)
		{
		}

		public static UserPoolMfaType FindValue(string value)
		{
			return null;
		}

		public static implicit operator UserPoolMfaType(string value)
		{
			return null;
		}
	}
}
