using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class ListIdentityPoolsResponse : AmazonWebServiceResponse
	{
		private List<IdentityPoolShortDescription> _identityPools;

		private string _nextToken;

		public List<IdentityPoolShortDescription> IdentityPools
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

		internal bool IsSetIdentityPools()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
