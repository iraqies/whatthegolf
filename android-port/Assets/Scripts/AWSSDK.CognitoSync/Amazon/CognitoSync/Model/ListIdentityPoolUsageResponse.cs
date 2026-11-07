using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class ListIdentityPoolUsageResponse : AmazonWebServiceResponse
	{
		private int? _count;

		private List<IdentityPoolUsage> _identityPoolUsages;

		private int? _maxResults;

		private string _nextToken;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<IdentityPoolUsage> IdentityPoolUsages
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

		internal bool IsSetCount()
		{
			return false;
		}

		internal bool IsSetIdentityPoolUsages()
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
