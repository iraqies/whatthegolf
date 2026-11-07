using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class VerifiedAttributeType : ConstantClass
	{
		public static readonly VerifiedAttributeType Email;

		public static readonly VerifiedAttributeType Phone_number;

		public VerifiedAttributeType(string value)
			: base(null)
		{
		}

		public static VerifiedAttributeType FindValue(string value)
		{
			return null;
		}

		public static implicit operator VerifiedAttributeType(string value)
		{
			return null;
		}
	}
}
