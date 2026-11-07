using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class DomainStatusType : ConstantClass
	{
		public static readonly DomainStatusType ACTIVE;

		public static readonly DomainStatusType CREATING;

		public static readonly DomainStatusType DELETING;

		public static readonly DomainStatusType FAILED;

		public static readonly DomainStatusType UPDATING;

		public DomainStatusType(string value)
			: base(null)
		{
		}

		public static DomainStatusType FindValue(string value)
		{
			return null;
		}

		public static implicit operator DomainStatusType(string value)
		{
			return null;
		}
	}
}
