using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class SetCognitoEventsRequest : AmazonCognitoSyncRequest
	{
		private Dictionary<string, string> _events;

		private string _identityPoolId;

		[AWSProperty]
		public Dictionary<string, string> Events
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
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEvents()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}
	}
}
