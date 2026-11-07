using Amazon.Runtime;

namespace Amazon.CognitoSync
{
	public class BulkPublishStatus : ConstantClass
	{
		public static readonly BulkPublishStatus FAILED;

		public static readonly BulkPublishStatus IN_PROGRESS;

		public static readonly BulkPublishStatus NOT_STARTED;

		public static readonly BulkPublishStatus SUCCEEDED;

		public BulkPublishStatus(string value)
			: base(null)
		{
		}

		public static BulkPublishStatus FindValue(string value)
		{
			return null;
		}

		public static implicit operator BulkPublishStatus(string value)
		{
			return null;
		}
	}
}
