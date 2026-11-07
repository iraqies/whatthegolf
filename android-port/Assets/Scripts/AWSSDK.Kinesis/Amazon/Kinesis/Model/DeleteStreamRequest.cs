using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DeleteStreamRequest : AmazonKinesisRequest
	{
		private bool? _enforceConsumerDeletion;

		private string _streamName;

		public bool EnforceConsumerDeletion
		{
			get
			{
				return false;
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

		internal bool IsSetEnforceConsumerDeletion()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
