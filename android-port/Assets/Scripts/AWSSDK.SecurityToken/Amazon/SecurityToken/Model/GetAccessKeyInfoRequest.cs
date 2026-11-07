using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetAccessKeyInfoRequest : AmazonSecurityTokenServiceRequest
	{
		private string _accessKeyId;

		[AWSProperty]
		public string AccessKeyId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccessKeyId()
		{
			return false;
		}
	}
}
