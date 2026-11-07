using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminUpdateDeviceStatusRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _deviceKey;

		private DeviceRememberedStatusType _deviceRememberedStatus;

		private string _username;

		private string _userPoolId;

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

		[AWSProperty]
		public string Username
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
		public string UserPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDeviceKey()
		{
			return false;
		}

		internal bool IsSetDeviceRememberedStatus()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
