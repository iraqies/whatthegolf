using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateIdentityProviderResponse : AmazonWebServiceResponse
	{
		private IdentityProviderType _identityProvider;

		[AWSProperty]
		public IdentityProviderType IdentityProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityProvider()
		{
			return false;
		}
	}
}
