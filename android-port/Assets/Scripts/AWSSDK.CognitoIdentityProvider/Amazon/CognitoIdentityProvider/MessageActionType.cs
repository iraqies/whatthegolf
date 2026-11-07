using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class MessageActionType : ConstantClass
	{
		public static readonly MessageActionType RESEND;

		public static readonly MessageActionType SUPPRESS;

		public MessageActionType(string value)
			: base(null)
		{
		}

		public static MessageActionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator MessageActionType(string value)
		{
			return null;
		}
	}
}
