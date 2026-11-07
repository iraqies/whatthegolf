using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class EnableEnhancedMonitoringResponse : AmazonWebServiceResponse
	{
		private List<string> _currentShardLevelMetrics;

		private List<string> _desiredShardLevelMetrics;

		private string _streamName;

		[AWSProperty]
		public List<string> CurrentShardLevelMetrics
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
		public List<string> DesiredShardLevelMetrics
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

		internal bool IsSetCurrentShardLevelMetrics()
		{
			return false;
		}

		internal bool IsSetDesiredShardLevelMetrics()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
