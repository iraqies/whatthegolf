using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateResourceServerResponse : AmazonWebServiceResponse
	{
		private ResourceServerType _resourceServer;

		[AWSProperty]
		public ResourceServerType ResourceServer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetResourceServer()
		{
			return false;
		}
	}
}
