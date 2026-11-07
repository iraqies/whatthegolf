using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class DeliveryMediumType : ConstantClass
	{
		public static readonly DeliveryMediumType EMAIL;

		public static readonly DeliveryMediumType SMS;

		public DeliveryMediumType(string value)
			: base(null)
		{
		}

		public static DeliveryMediumType FindValue(string value)
		{
			return null;
		}

		public static implicit operator DeliveryMediumType(string value)
		{
			return null;
		}
	}
}
