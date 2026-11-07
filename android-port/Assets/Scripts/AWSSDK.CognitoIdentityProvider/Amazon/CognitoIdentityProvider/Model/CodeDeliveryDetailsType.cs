using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CodeDeliveryDetailsType
	{
		private string _attributeName;

		private DeliveryMediumType _deliveryMedium;

		private string _destination;

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

		public string Destination
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

		internal bool IsSetDestination()
		{
			return false;
		}
	}
}
