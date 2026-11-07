using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class DecodeAuthorizationMessageResponse : AmazonWebServiceResponse
	{
		private string _decodedMessage;

		public string DecodedMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDecodedMessage()
		{
			return false;
		}
	}
}
