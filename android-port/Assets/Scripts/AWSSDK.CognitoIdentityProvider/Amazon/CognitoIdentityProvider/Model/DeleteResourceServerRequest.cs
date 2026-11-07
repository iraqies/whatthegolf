using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DeleteResourceServerRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _identifier;

		private string _userPoolId;

		[AWSProperty]
		public string Identifier
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

		internal bool IsSetIdentifier()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
