using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class UpdateShardCountRequest : AmazonKinesisRequest
	{
		private ScalingType _scalingType;

		private string _streamName;

		private int? _targetShardCount;

		[AWSProperty]
		public ScalingType ScalingType
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

		[AWSProperty]
		public int TargetShardCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool IsSetScalingType()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}

		internal bool IsSetTargetShardCount()
		{
			return false;
		}
	}
}
