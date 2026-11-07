using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class VerifySoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _friendlyDeviceName;

		private string _session;

		private string _userCode;

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

		public string FriendlyDeviceName
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
		public string Session
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
		public string UserCode
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

		internal bool IsSetFriendlyDeviceName()
		{
			return false;
		}

		internal bool IsSetSession()
		{
			return false;
		}

		internal bool IsSetUserCode()
		{
			return false;
		}
	}
}
