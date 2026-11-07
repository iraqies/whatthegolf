using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class DecodeAuthorizationMessageRequest : AmazonSecurityTokenServiceRequest
	{
		private string _encodedMessage;

		[AWSProperty]
		public string EncodedMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEncodedMessage()
		{
			return false;
		}
	}
}
