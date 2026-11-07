using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class CreateStreamRequest : AmazonKinesisRequest
	{
		private int? _shardCount;

		private string _streamName;

		[AWSProperty]
		public int ShardCount
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

		internal bool IsSetShardCount()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
