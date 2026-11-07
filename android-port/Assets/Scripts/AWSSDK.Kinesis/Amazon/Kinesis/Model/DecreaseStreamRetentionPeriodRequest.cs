using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DecreaseStreamRetentionPeriodRequest : AmazonKinesisRequest
	{
		private int? _retentionPeriodHours;

		private string _streamName;

		[AWSProperty]
		public int RetentionPeriodHours
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		internal bool IsSetRetentionPeriodHours()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
