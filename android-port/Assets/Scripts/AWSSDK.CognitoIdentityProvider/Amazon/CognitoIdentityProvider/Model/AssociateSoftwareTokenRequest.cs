using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AssociateSoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _session;

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

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetSession()
		{
			return false;
		}
	}
}
