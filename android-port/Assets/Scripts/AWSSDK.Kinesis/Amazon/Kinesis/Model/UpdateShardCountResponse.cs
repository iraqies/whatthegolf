using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class UpdateShardCountResponse : AmazonWebServiceResponse
	{
		private int? _currentShardCount;

		private string _streamName;

		private int? _targetShardCount;

		[AWSProperty]
		public int CurrentShardCount
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

		internal bool IsSetCurrentShardCount()
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
