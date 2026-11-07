using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminListGroupsForUserResponse : AmazonWebServiceResponse
	{
		private List<GroupType> _groups;

		private string _nextToken;

		public List<GroupType> Groups
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

		internal bool IsSetGroups()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
