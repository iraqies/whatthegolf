using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class ListDatasetsRequest : AmazonCognitoSyncRequest
	{
		private string _identityId;

		private string _identityPoolId;

		private int? _maxResults;

		private string _nextToken;

		[AWSProperty]
		public string IdentityId
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
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
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
