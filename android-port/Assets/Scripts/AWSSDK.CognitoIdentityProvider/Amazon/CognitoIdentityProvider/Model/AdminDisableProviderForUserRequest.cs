using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminDisableProviderForUserRequest : AmazonCognitoIdentityProviderRequest
	{
		private ProviderUserIdentifierType _user;

		private string _userPoolId;

		[AWSProperty]
		public ProviderUserIdentifierType User
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

		internal bool IsSetUser()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
