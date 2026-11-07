using System;
using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class Record
	{
		private DateTime? _approximateArrivalTimestamp;

		private MemoryStream _data;

		private EncryptionType _encryptionType;

		private string _partitionKey;

		private string _sequenceNumber;

		public DateTime ApproximateArrivalTimestamp
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

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

		internal bool IsSetApproximateArrivalTimestamp()
		{
			return false;
		}

		internal bool IsSetData()
		{
			return false;
		}

		internal bool IsSetEncryptionType()
		{
			return false;
		}

		internal bool IsSetPartitionKey()
		{
			return false;
		}

		internal bool IsSetSequenceNumber()
		{
			return false;
		}
	}
}
