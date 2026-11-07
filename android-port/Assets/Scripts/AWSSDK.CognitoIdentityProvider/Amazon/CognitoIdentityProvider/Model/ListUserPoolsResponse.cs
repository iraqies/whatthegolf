using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUserPoolsResponse : AmazonWebServiceResponse
	{
		private string _nextToken;

		private List<UserPoolDescriptionType> _userPools;

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

		public List<UserPoolDescriptionType> UserPools
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

		internal bool IsSetUserPools()
		{
			return false;
		}
	}
}
