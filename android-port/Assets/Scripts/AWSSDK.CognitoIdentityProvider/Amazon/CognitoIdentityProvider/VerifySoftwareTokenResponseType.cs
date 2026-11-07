using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class VerifySoftwareTokenResponseType : ConstantClass
	{
		public static readonly VerifySoftwareTokenResponseType ERROR;

		public static readonly VerifySoftwareTokenResponseType SUCCESS;

		public VerifySoftwareTokenResponseType(string value)
			: base(null)
		{
		}

		public static VerifySoftwareTokenResponseType FindValue(string value)
		{
			return null;
		}

		public static implicit operator VerifySoftwareTokenResponseType(string value)
		{
			return null;
		}
	}
}
