using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class SplitShardRequest : AmazonKinesisRequest
	{
		private string _newStartingHashKey;

		private string _shardToSplit;

		private string _streamName;

		[AWSProperty]
		public string NewStartingHashKey
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
		public string ShardToSplit
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

		internal bool IsSetNewStartingHashKey()
		{
			return false;
		}

		internal bool IsSetShardToSplit()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
