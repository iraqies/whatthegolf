using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GetIdentityProviderByIdentifierRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _idpIdentifier;

		private string _userPoolId;

		[AWSProperty]
		public string IdpIdentifier
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

		internal bool IsSetIdpIdentifier()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
