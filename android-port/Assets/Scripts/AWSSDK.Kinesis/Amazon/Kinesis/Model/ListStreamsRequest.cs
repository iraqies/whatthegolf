using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListStreamsRequest : AmazonKinesisRequest
	{
		private string _exclusiveStartStreamName;

		private int? _limit;

		[AWSProperty]
		public string ExclusiveStartStreamName
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

		internal bool IsSetExclusiveStartStreamName()
		{
			return false;
		}

		internal bool IsSetLimit()
		{
			return false;
		}
	}
}
