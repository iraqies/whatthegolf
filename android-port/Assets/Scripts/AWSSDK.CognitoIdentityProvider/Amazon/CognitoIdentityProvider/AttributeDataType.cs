using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class AttributeDataType : ConstantClass
	{
		public static readonly AttributeDataType Boolean;

		public static readonly AttributeDataType DateTime;

		public static readonly AttributeDataType Number;

		public static readonly AttributeDataType String;

		public AttributeDataType(string value)
			: base(null)
		{
		}

		public static AttributeDataType FindValue(string value)
		{
			return null;
		}

		public static implicit operator AttributeDataType(string value)
		{
			return null;
		}
	}
}
