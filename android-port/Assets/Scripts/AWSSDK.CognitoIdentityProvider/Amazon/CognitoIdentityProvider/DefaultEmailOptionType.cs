using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class DefaultEmailOptionType : ConstantClass
	{
		public static readonly DefaultEmailOptionType CONFIRM_WITH_CODE;

		public static readonly DefaultEmailOptionType CONFIRM_WITH_LINK;

		public DefaultEmailOptionType(string value)
			: base(null)
		{
		}

		public static DefaultEmailOptionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator DefaultEmailOptionType(string value)
		{
			return null;
		}
	}
}
