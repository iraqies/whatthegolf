using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class ChallengeResponse : ConstantClass
	{
		public static readonly ChallengeResponse Failure;

		public static readonly ChallengeResponse Success;

		public ChallengeResponse(string value)
			: base(null)
		{
		}

		public static ChallengeResponse FindValue(string value)
		{
			return null;
		}

		public static implicit operator ChallengeResponse(string value)
		{
			return null;
		}
	}
}
