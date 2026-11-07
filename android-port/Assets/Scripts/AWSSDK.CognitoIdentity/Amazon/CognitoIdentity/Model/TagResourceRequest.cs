using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class TagResourceRequest : AmazonCognitoIdentityRequest
	{
		private string _resourceArn;

		private Dictionary<string, string> _tags;

		[AWSProperty]
		public string ResourceArn
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

		internal bool IsSetResourceArn()
		{
			return false;
		}

		internal bool IsSetTags()
		{
			return false;
		}
	}
}
