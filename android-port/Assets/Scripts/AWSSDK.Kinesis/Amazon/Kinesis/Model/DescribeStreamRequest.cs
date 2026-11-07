using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DescribeStreamRequest : AmazonKinesisRequest
	{
		private string _exclusiveStartShardId;

		private int? _limit;

		private string _streamName;

		[AWSProperty]
		public string ExclusiveStartShardId
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
		public int Limit
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

		internal bool IsSetExclusiveStartShardId()
		{
			return false;
		}

		internal bool IsSetLimit()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
