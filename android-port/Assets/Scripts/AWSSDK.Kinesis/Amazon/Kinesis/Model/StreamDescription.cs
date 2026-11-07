using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class StreamDescription
	{
		private EncryptionType _encryptionType;

		private List<EnhancedMetrics> _enhancedMonitoring;

		private bool? _hasMoreShards;

		private string _keyId;

		private int? _retentionPeriodHours;

		private List<Shard> _shards;

		private string _streamARN;

		private DateTime? _streamCreationTimestamp;

		private string _streamName;

		private StreamStatus _streamStatus;

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
		public List<EnhancedMetrics> EnhancedMonitoring
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
		public bool HasMoreShards
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
		public int RetentionPeriodHours
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
		public List<Shard> Shards
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
		public string StreamARN
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
		public DateTime StreamCreationTimestamp
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

		[AWSProperty]
		public StreamStatus StreamStatus
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

		internal bool IsSetEnhancedMonitoring()
		{
			return false;
		}

		internal bool IsSetHasMoreShards()
		{
			return false;
		}

		internal bool IsSetKeyId()
		{
			return false;
		}

		internal bool IsSetRetentionPeriodHours()
		{
			return false;
		}

		internal bool IsSetShards()
		{
			return false;
		}

		internal bool IsSetStreamARN()
		{
			return false;
		}

		internal bool IsSetStreamCreationTimestamp()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}

		internal bool IsSetStreamStatus()
		{
			return false;
		}
	}
}
