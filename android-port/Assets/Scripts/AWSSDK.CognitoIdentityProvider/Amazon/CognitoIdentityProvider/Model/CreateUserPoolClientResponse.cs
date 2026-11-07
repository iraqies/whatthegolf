using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateUserPoolClientResponse : AmazonWebServiceResponse
	{
		private UserPoolClientType _userPoolClient;

		public UserPoolClientType UserPoolClient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetUserPoolClient()
		{
			return false;
		}
	}
}
