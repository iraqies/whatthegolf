using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class RegisterStreamConsumerResponse : AmazonWebServiceResponse
	{
		private Consumer _consumer;

		[AWSProperty]
		public Consumer Consumer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetConsumer()
		{
			return false;
		}
	}
}
