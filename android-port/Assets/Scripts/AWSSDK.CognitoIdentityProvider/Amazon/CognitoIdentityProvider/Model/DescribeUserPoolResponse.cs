using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DescribeUserPoolResponse : AmazonWebServiceResponse
	{
		private UserPoolType _userPool;

		public UserPoolType UserPool
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetUserPool()
		{
			return false;
		}
	}
}
