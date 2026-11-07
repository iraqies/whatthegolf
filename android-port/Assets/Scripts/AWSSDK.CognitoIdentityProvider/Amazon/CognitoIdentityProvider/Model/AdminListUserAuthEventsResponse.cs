using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminListUserAuthEventsResponse : AmazonWebServiceResponse
	{
		private List<AuthEventType> _authEvents;

		private string _nextToken;

		public List<AuthEventType> AuthEvents
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

		internal bool IsSetAuthEvents()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
