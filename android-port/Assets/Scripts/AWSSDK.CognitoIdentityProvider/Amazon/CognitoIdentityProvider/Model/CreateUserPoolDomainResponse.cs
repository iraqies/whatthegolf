using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateUserPoolDomainResponse : AmazonWebServiceResponse
	{
		private string _cloudFrontDomain;

		[AWSProperty]
		public string CloudFrontDomain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCloudFrontDomain()
		{
			return false;
		}
	}
}
