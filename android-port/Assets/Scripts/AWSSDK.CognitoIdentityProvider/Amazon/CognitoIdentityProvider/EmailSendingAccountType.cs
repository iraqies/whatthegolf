using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class EmailSendingAccountType : ConstantClass
	{
		public static readonly EmailSendingAccountType COGNITO_DEFAULT;

		public static readonly EmailSendingAccountType DEVELOPER;

		public EmailSendingAccountType(string value)
			: base(null)
		{
		}

		public static EmailSendingAccountType FindValue(string value)
		{
			return null;
		}

		public static implicit operator EmailSendingAccountType(string value)
		{
			return null;
		}
	}
}
