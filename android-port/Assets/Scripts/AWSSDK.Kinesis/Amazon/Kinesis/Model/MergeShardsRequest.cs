using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class MergeShardsRequest : AmazonKinesisRequest
	{
		private string _adjacentShardToMerge;

		private string _shardToMerge;

		private string _streamName;

		[AWSProperty]
		public string AdjacentShardToMerge
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
		public string ShardToMerge
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

		internal bool IsSetAdjacentShardToMerge()
		{
			return false;
		}

		internal bool IsSetShardToMerge()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
