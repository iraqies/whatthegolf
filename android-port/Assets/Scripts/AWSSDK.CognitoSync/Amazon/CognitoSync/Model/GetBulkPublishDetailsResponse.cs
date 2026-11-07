using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class GetBulkPublishDetailsResponse : AmazonWebServiceResponse
	{
		private DateTime? _bulkPublishCompleteTime;

		private DateTime? _bulkPublishStartTime;

		private BulkPublishStatus _bulkPublishStatus;

		private string _failureMessage;

		private string _identityPoolId;

		public DateTime BulkPublishCompleteTime
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public DateTime BulkPublishStartTime
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public BulkPublishStatus BulkPublishStatus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FailureMessage
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
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetBulkPublishCompleteTime()
		{
			return false;
		}

		internal bool IsSetBulkPublishStartTime()
		{
			return false;
		}

		internal bool IsSetBulkPublishStatus()
		{
			return false;
		}

		internal bool IsSetFailureMessage()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}
	}
}
