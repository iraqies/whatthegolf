using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class BulkPublishResponse : AmazonWebServiceResponse
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
