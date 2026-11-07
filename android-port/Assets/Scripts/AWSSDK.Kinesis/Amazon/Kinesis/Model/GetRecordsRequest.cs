using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class GetRecordsRequest : AmazonKinesisRequest
	{
		private int? _limit;

		private string _shardIterator;

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
		public string ShardIterator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetLimit()
		{
			return false;
		}

		internal bool IsSetShardIterator()
		{
			return false;
		}
	}
}
