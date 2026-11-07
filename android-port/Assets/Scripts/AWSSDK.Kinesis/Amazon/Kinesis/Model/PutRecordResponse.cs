using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class PutRecordResponse : AmazonWebServiceResponse
	{
		private EncryptionType _encryptionType;

		private string _sequenceNumber;

		private string _shardId;

		public EncryptionType EncryptionType
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

		internal bool IsSetEncryptionType()
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
