using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class RegisterStreamConsumerRequest : AmazonKinesisRequest
	{
		private string _consumerName;

		private string _streamARN;

		[AWSProperty]
		public string ConsumerName
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
		public string StreamARN
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetConsumerName()
		{
			return false;
		}

		internal bool IsSetStreamARN()
		{
			return false;
		}
	}
}
