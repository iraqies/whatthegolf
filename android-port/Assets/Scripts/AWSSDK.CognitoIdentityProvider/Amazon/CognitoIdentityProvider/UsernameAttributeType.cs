using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class UsernameAttributeType : ConstantClass
	{
		public static readonly UsernameAttributeType Email;

		public static readonly UsernameAttributeType Phone_number;

		public UsernameAttributeType(string value)
			: base(null)
		{
		}

		public static UsernameAttributeType FindValue(string value)
		{
			return null;
		}

		public static implicit operator UsernameAttributeType(string value)
		{
			return null;
		}
	}
}
