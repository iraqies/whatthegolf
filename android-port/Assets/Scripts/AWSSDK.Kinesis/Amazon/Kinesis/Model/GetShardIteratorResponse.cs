using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class GetShardIteratorResponse : AmazonWebServiceResponse
	{
		private string _shardIterator;

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

		internal bool IsSetShardIterator()
		{
			return false;
		}
	}
}
