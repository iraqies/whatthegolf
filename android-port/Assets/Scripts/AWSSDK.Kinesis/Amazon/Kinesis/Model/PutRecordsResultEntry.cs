using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class PutRecordsResultEntry
	{
		private string _errorCode;

		private string _errorMessage;

		private string _sequenceNumber;

		private string _shardId;

		public string ErrorCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ErrorMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SequenceNumber
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
		public string ShardId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetErrorCode()
		{
			return false;
		}

		internal bool IsSetErrorMessage()
		{
			return false;
		}

		internal bool IsSetSequenceNumber()
		{
			return false;
		}

		internal bool IsSetShardId()
		{
			return false;
		}
	}
}
