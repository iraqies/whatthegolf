using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DescribeUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _userPoolId;

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

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
