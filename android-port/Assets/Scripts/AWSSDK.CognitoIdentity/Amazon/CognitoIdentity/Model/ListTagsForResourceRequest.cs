using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class ListTagsForResourceRequest : AmazonCognitoIdentityRequest
	{
		private string _resourceArn;

		[AWSProperty]
		public string ResourceArn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetResourceArn()
		{
			return false;
		}
	}
}
