using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetOpenIdTokenForDeveloperIdentityResponse : AmazonWebServiceResponse
	{
		private string _identityId;

		private string _token;

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

		public string Token
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

		internal bool IsSetToken()
		{
			return false;
		}
	}
}
