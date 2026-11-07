using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DescribeStreamConsumerResponse : AmazonWebServiceResponse
	{
		private ConsumerDescription _consumerDescription;

		[AWSProperty]
		public ConsumerDescription ConsumerDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetConsumerDescription()
		{
			return false;
		}
	}
}
