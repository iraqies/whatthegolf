using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class VerifySoftwareTokenResponse : AmazonWebServiceResponse
	{
		private string _session;

		private VerifySoftwareTokenResponseType _status;

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

		public VerifySoftwareTokenResponseType Status
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetSession()
		{
			return false;
		}

		internal bool IsSetStatus()
		{
			return false;
		}
	}
}
