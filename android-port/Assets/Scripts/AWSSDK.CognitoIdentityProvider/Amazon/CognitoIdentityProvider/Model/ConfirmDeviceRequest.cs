using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ConfirmDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _deviceKey;

		private string _deviceName;

		private DeviceSecretVerifierConfigType _deviceSecretVerifierConfig;

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

		[AWSProperty]
		public string DeviceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeviceSecretVerifierConfigType DeviceSecretVerifierConfig
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

		internal bool IsSetDeviceName()
		{
			return false;
		}

		internal bool IsSetDeviceSecretVerifierConfig()
		{
			return false;
		}
	}
}
