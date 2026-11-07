using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class EnhancedMetrics
	{
		private List<string> _shardLevelMetrics;

		[AWSProperty]
		public List<string> ShardLevelMetrics
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetShardLevelMetrics()
		{
			return false;
		}
	}
}
