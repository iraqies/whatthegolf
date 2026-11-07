using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class UserStatusType : ConstantClass
	{
		public static readonly UserStatusType ARCHIVED;

		public static readonly UserStatusType COMPROMISED;

		public static readonly UserStatusType CONFIRMED;

		public static readonly UserStatusType FORCE_CHANGE_PASSWORD;

		public static readonly UserStatusType RESET_REQUIRED;

		public static readonly UserStatusType UNCONFIRMED;

		public static readonly UserStatusType UNKNOWN;

		public UserStatusType(string value)
			: base(null)
		{
		}

		public static UserStatusType FindValue(string value)
		{
			return null;
		}

		public static implicit operator UserStatusType(string value)
		{
			return null;
		}
	}
}
