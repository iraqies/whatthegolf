using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListUserPoolClientsResponse : AmazonWebServiceResponse
	{
		private string _nextToken;

		private List<UserPoolClientDescription> _userPoolClients;

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

		public List<UserPoolClientDescription> UserPoolClients
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

		internal bool IsSetUserPoolClients()
		{
			return false;
		}
	}
}
