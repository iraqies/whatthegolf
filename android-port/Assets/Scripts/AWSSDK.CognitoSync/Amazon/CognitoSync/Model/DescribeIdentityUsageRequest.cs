using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class DescribeIdentityUsageRequest : AmazonCognitoSyncRequest
	{
		private string _identityId;

		private string _identityPoolId;

		[AWSProperty]
		public string IdentityId
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
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}
	}
}
