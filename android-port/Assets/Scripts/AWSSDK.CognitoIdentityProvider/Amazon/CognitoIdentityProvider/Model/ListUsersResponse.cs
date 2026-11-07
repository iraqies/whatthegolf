using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUsersResponse : AmazonWebServiceResponse
	{
		private string _paginationToken;

		private List<UserType> _users;

		[AWSProperty]
		public string PaginationToken
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

		internal bool IsSetPaginationToken()
		{
			return false;
		}

		internal bool IsSetUsers()
		{
			return false;
		}
	}
}
