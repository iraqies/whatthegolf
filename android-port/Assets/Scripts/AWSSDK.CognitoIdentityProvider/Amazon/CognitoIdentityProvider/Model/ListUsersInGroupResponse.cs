using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUsersInGroupResponse : AmazonWebServiceResponse
	{
		private string _nextToken;

		private List<UserType> _users;

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

		public List<UserType> Users
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

		internal bool IsSetUsers()
		{
			return false;
		}
	}
}
