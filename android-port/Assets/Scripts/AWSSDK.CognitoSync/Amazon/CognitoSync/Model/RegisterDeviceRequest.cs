using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class RegisterDeviceRequest : AmazonCognitoSyncRequest
	{
		private string _identityId;

		private string _identityPoolId;

		private Platform _platform;

		private string _token;

		[AWSProperty]
		public string IdentityId
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
		public string IdentityPoolId
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
		public Platform Platform
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
		public string Token
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetPlatform()
		{
			return false;
		}

		internal bool IsSetToken()
		{
			return false;
		}
	}
}
