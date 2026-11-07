using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UntagResourceRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _resourceArn;

		private List<string> _tagKeys;

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
		public List<string> TagKeys
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

		internal bool IsSetTagKeys()
		{
			return false;
		}
	}
}
