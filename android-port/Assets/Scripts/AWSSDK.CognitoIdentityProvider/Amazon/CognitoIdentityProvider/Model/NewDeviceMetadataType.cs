using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class NewDeviceMetadataType
	{
		private string _deviceGroupKey;

		private string _deviceKey;

		public string DeviceGroupKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string DeviceKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDeviceGroupKey()
		{
			return false;
		}

		internal bool IsSetDeviceKey()
		{
			return false;
		}
	}
}
