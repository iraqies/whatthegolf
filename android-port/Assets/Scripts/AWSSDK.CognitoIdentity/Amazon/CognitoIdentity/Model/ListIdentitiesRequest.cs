using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class ListIdentitiesRequest : AmazonCognitoIdentityRequest
	{
		private bool? _hideDisabled;

		private string _identityPoolId;

		private int? _maxResults;

		private string _nextToken;

		public bool HideDisabled
		{
			get
			{
				return false;
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

		internal bool IsSetHideDisabled()
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
