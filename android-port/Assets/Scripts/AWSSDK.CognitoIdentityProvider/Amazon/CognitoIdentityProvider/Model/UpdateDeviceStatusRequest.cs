using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateDeviceStatusRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _deviceKey;

		private DeviceRememberedStatusType _deviceRememberedStatus;

		[AWSProperty]
		public string AccessToken
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

		public DeviceRememberedStatusType DeviceRememberedStatus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetDeviceKey()
		{
			return false;
		}

		internal bool IsSetDeviceRememberedStatus()
		{
			return false;
		}
	}
}
