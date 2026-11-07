using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class AccountTakeoverEventActionType : ConstantClass
	{
		public static readonly AccountTakeoverEventActionType BLOCK;

		public static readonly AccountTakeoverEventActionType MFA_IF_CONFIGURED;

		public static readonly AccountTakeoverEventActionType MFA_REQUIRED;

		public static readonly AccountTakeoverEventActionType NO_ACTION;

		public AccountTakeoverEventActionType(string value)
			: base(null)
		{
		}

		public static AccountTakeoverEventActionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator AccountTakeoverEventActionType(string value)
		{
			return null;
		}
	}
}
