using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DescribeUserPoolDomainResponse : AmazonWebServiceResponse
	{
		private DomainDescriptionType _domainDescription;

		public DomainDescriptionType DomainDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDomainDescription()
		{
			return false;
		}
	}
}
