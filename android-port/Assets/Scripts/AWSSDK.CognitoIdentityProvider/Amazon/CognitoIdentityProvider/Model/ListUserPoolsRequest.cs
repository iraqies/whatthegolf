using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUserPoolsRequest : AmazonCognitoIdentityProviderRequest
	{
		private int? _maxResults;

		private string _nextToken;

		[AWSProperty]
		public int MaxResults
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		internal bool IsSetMaxResults()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
