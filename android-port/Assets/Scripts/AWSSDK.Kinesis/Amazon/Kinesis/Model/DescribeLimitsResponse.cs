using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DescribeLimitsResponse : AmazonWebServiceResponse
	{
		private int? _openShardCount;

		private int? _shardLimit;

		[AWSProperty]
		public int OpenShardCount
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
		public int ShardLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool IsSetOpenShardCount()
		{
			return false;
		}

		internal bool IsSetShardLimit()
		{
			return false;
		}
	}
}
