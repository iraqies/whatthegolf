using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DisableEnhancedMonitoringRequest : AmazonKinesisRequest
	{
		private List<string> _shardLevelMetrics;

		private string _streamName;

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

		internal bool IsSetShardLevelMetrics()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
