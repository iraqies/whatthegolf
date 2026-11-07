using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListTagsForResourceResponse : AmazonWebServiceResponse
	{
		private Dictionary<string, string> _tags;

		public Dictionary<string, string> Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetTags()
		{
			return false;
		}
	}
}
