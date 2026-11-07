using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class DescribeIdentityPoolRequest : AmazonCognitoIdentityRequest
	{
		private string _identityPoolId;

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

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}
	}
}
