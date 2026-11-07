using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class RecoveryOptionNameType : ConstantClass
	{
		public static readonly RecoveryOptionNameType Admin_only;

		public static readonly RecoveryOptionNameType Verified_email;

		public static readonly RecoveryOptionNameType Verified_phone_number;

		public RecoveryOptionNameType(string value)
			: base(null)
		{
		}

		public static RecoveryOptionNameType FindValue(string value)
		{
			return null;
		}

		public static implicit operator RecoveryOptionNameType(string value)
		{
			return null;
		}
	}
}
