using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class ChallengeName : ConstantClass
	{
		public static readonly ChallengeName Mfa;

		public static readonly ChallengeName Password;

		public ChallengeName(string value)
			: base(null)
		{
		}

		public static ChallengeName FindValue(string value)
		{
			return null;
		}

		public static implicit operator ChallengeName(string value)
		{
			return null;
		}
	}
}
