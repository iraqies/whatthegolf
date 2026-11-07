using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetIdResponse : AmazonWebServiceResponse
	{
		private string _identityId;

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

		internal bool IsSetIdentityId()
		{
			return false;
		}
	}
}
