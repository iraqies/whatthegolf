using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GlobalSignOutRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

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

		internal bool IsSetAccessToken()
		{
			return false;
		}
	}
}
