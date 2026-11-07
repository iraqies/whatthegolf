using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class EventType : ConstantClass
	{
		public static readonly EventType ForgotPassword;

		public static readonly EventType SignIn;

		public static readonly EventType SignUp;

		public EventType(string value)
			: base(null)
		{
		}

		public static EventType FindValue(string value)
		{
			return null;
		}

		public static implicit operator EventType(string value)
		{
			return null;
		}
	}
}
