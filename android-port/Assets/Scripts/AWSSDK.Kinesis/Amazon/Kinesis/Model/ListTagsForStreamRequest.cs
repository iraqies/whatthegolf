using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListTagsForStreamRequest : AmazonKinesisRequest
	{
		private string _exclusiveStartTagKey;

		private int? _limit;

		private string _streamName;

		[AWSProperty]
		public string ExclusiveStartTagKey
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

		internal bool IsSetExclusiveStartTagKey()
		{
			return false;
		}

		internal bool IsSetLimit()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
