using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUserImportJobsResponse : AmazonWebServiceResponse
	{
		private string _paginationToken;

		private List<UserImportJobType> _userImportJobs;

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
		public List<UserImportJobType> UserImportJobs
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

		internal bool IsSetUserImportJobs()
		{
			return false;
		}
	}
}
