using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListTagsForResourceRequest : AmazonCognitoIdentityProviderRequest
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
