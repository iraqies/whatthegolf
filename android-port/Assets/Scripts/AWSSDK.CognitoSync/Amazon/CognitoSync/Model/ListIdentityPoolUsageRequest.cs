namespace Amazon.CognitoSync.Model
{
	public class ListIdentityPoolUsageRequest : AmazonCognitoSyncRequest
	{
		private int? _maxResults;

		private string _nextToken;

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
