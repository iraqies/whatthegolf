using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class ChallengeNameType : ConstantClass
	{
		public static readonly ChallengeNameType ADMIN_NO_SRP_AUTH;

		public static readonly ChallengeNameType CUSTOM_CHALLENGE;

		public static readonly ChallengeNameType DEVICE_PASSWORD_VERIFIER;

		public static readonly ChallengeNameType DEVICE_SRP_AUTH;

		public static readonly ChallengeNameType MFA_SETUP;

		public static readonly ChallengeNameType NEW_PASSWORD_REQUIRED;

		public static readonly ChallengeNameType PASSWORD_VERIFIER;

		public static readonly ChallengeNameType SELECT_MFA_TYPE;

		public static readonly ChallengeNameType SMS_MFA;

		public static readonly ChallengeNameType SOFTWARE_TOKEN_MFA;

		public ChallengeNameType(string value)
			: base(null)
		{
		}

		public static ChallengeNameType FindValue(string value)
		{
			return null;
		}

		public static implicit operator ChallengeNameType(string value)
		{
			return null;
		}
	}
}
