using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListIdentityProvidersResponse : AmazonWebServiceResponse
	{
		private string _nextToken;

		private List<ProviderDescription> _providers;

		[AWSProperty]
		public string NextToken
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
		public List<ProviderDescription> Providers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetNextToken()
		{
			return false;
		}

		internal bool IsSetProviders()
		{
			return false;
		}
	}
}
