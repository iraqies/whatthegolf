using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class AliasAttributeType : ConstantClass
	{
		public static readonly AliasAttributeType Email;

		public static readonly AliasAttributeType Phone_number;

		public static readonly AliasAttributeType Preferred_username;

		public AliasAttributeType(string value)
			: base(null)
		{
		}

		public static AliasAttributeType FindValue(string value)
		{
			return null;
		}

		public static implicit operator AliasAttributeType(string value)
		{
			return null;
		}
	}
}
