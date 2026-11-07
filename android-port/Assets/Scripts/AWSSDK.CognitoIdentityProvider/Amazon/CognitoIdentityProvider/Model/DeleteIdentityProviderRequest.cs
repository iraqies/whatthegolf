using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DeleteIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _providerName;

		private string _userPoolId;

		[AWSProperty]
		public string ProviderName
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

		internal bool IsSetProviderName()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
