using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetCredentialsForIdentityResponse : AmazonWebServiceResponse
	{
		private Credentials _credentials;

		private string _identityId;

		public Credentials Credentials
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

		internal bool IsSetCredentials()
		{
			return false;
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}
	}
}
