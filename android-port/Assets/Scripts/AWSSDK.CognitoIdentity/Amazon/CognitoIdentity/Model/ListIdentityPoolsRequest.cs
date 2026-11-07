using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class ListIdentityPoolsRequest : AmazonCognitoIdentityRequest
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
