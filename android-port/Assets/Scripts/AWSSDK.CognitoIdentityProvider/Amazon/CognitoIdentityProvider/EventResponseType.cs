using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class EventResponseType : ConstantClass
	{
		public static readonly EventResponseType Failure;

		public static readonly EventResponseType Success;

		public EventResponseType(string value)
			: base(null)
		{
		}

		public static EventResponseType FindValue(string value)
		{
			return null;
		}

		public static implicit operator EventResponseType(string value)
		{
			return null;
		}
	}
}
