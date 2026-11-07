using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GetDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _deviceKey;

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

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetDeviceKey()
		{
			return false;
		}
	}
}
