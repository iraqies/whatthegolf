using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DescribeStreamSummaryRequest : AmazonKinesisRequest
	{
		private string _streamName;

		[AWSProperty]
		public string StreamName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
