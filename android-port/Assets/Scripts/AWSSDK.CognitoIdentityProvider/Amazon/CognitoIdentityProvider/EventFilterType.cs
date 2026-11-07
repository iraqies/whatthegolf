using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class EventFilterType : ConstantClass
	{
		public static readonly EventFilterType PASSWORD_CHANGE;

		public static readonly EventFilterType SIGN_IN;

		public static readonly EventFilterType SIGN_UP;

		public EventFilterType(string value)
			: base(null)
		{
		}

		public static EventFilterType FindValue(string value)
		{
			return null;
		}

		public static implicit operator EventFilterType(string value)
		{
			return null;
		}
	}
}
