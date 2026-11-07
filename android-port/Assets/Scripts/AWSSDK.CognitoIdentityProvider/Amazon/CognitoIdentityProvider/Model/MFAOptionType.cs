using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class MFAOptionType
	{
		private string _attributeName;

		private DeliveryMediumType _deliveryMedium;

		[AWSProperty]
		public string AttributeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeliveryMediumType DeliveryMedium
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAttributeName()
		{
			return false;
		}

		internal bool IsSetDeliveryMedium()
		{
			return false;
		}
	}
}
