using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminLinkProviderForUserRequest : AmazonCognitoIdentityProviderRequest
	{
		private ProviderUserIdentifierType _destinationUser;

		private ProviderUserIdentifierType _sourceUser;

		private string _userPoolId;

		[AWSProperty]
		public ProviderUserIdentifierType DestinationUser
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
		public ProviderUserIdentifierType SourceUser
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

		internal bool IsSetDestinationUser()
		{
			return false;
		}

		internal bool IsSetSourceUser()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
