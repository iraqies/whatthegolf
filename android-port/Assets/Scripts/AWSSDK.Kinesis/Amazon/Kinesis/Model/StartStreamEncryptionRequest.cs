using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class StartStreamEncryptionRequest : AmazonKinesisRequest
	{
		private EncryptionType _encryptionType;

		private string _keyId;

		private string _streamName;

		[AWSProperty]
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
		public string KeyId
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

		internal bool IsSetEncryptionType()
		{
			return false;
		}

		internal bool IsSetKeyId()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
