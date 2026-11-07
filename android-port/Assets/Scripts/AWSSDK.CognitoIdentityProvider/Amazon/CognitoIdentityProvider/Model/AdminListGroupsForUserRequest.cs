using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminListGroupsForUserRequest : AmazonCognitoIdentityProviderRequest
	{
		private int? _limit;

		private string _nextToken;

		private string _username;

		private string _userPoolId;

		[AWSProperty]
		public int Limit
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

		[AWSProperty]
		public string Username
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
		public string UserPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetLimit()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
