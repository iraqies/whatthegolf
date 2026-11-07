using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class LookupDeveloperIdentityResponse : AmazonWebServiceResponse
	{
		private List<string> _developerUserIdentifierList;

		private string _identityId;

		private string _nextToken;

		public List<string> DeveloperUserIdentifierList
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

		internal bool IsSetDeveloperUserIdentifierList()
		{
			return false;
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
