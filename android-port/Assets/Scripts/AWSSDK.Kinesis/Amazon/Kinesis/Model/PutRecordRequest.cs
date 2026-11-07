using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class PutRecordRequest : AmazonKinesisRequest
	{
		private MemoryStream _data;

		private string _explicitHashKey;

		private string _partitionKey;

		private string _sequenceNumberForOrdering;

		private string _streamName;

		[AWSProperty]
		public MemoryStream Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ExplicitHashKey
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
		public string PartitionKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SequenceNumberForOrdering
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

		internal bool IsSetData()
		{
			return false;
		}

		internal bool IsSetExplicitHashKey()
		{
			return false;
		}

		internal bool IsSetPartitionKey()
		{
			return false;
		}

		internal bool IsSetSequenceNumberForOrdering()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
