using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AssociateSoftwareTokenResponse : AmazonWebServiceResponse
	{
		private string _secretCode;

		private string _session;

		[AWSProperty]
		public string SecretCode
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
		public string Session
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetSecretCode()
		{
			return false;
		}

		internal bool IsSetSession()
		{
			return false;
		}
	}
}
