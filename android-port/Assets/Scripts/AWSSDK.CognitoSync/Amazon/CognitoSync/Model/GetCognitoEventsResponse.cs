using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class GetCognitoEventsResponse : AmazonWebServiceResponse
	{
		private Dictionary<string, string> _events;

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

		internal bool IsSetEvents()
		{
			return false;
		}
	}
}
