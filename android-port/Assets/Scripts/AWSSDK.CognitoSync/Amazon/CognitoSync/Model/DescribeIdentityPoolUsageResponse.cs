using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class DescribeIdentityPoolUsageResponse : AmazonWebServiceResponse
	{
		private IdentityPoolUsage _identityPoolUsage;

		public IdentityPoolUsage IdentityPoolUsage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityPoolUsage()
		{
			return false;
		}
	}
}
