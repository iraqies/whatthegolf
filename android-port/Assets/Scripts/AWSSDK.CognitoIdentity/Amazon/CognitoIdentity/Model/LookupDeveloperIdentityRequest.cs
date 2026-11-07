using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class LookupDeveloperIdentityRequest : AmazonCognitoIdentityRequest
	{
		private string _developerUserIdentifier;

		private string _identityId;

		private string _identityPoolId;

		private int? _maxResults;

		private string _nextToken;

		[AWSProperty]
		public string DeveloperUserIdentifier
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

		internal bool IsSetDeveloperUserIdentifier()
		{
			return false;
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
