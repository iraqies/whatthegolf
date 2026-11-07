using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DescribeUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _domain;

		[AWSProperty]
		public string Domain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDomain()
		{
			return false;
		}
	}
}
