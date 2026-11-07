using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUsersRequest : AmazonCognitoIdentityProviderRequest
	{
		private List<string> _attributesToGet;

		private string _filter;

		private int? _limit;

		private string _paginationToken;

		private string _userPoolId;

		public List<string> AttributesToGet
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
		public string Filter
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

		internal bool IsSetAttributesToGet()
		{
			return false;
		}

		internal bool IsSetFilter()
		{
			return false;
		}

		internal bool IsSetLimit()
		{
			return false;
		}

		internal bool IsSetPaginationToken()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
