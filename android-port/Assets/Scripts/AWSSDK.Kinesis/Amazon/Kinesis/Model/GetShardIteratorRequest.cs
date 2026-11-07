using System;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class GetShardIteratorRequest : AmazonKinesisRequest
	{
		private string _shardId;

		private ShardIteratorType _shardIteratorType;

		private string _startingSequenceNumber;

		private string _streamName;

		private DateTime? _timestamp;

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

		[AWSProperty]
		public ShardIteratorType ShardIteratorType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StartingSequenceNumber
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

		public DateTime Timestamp
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		internal bool IsSetShardId()
		{
			return false;
		}

		internal bool IsSetShardIteratorType()
		{
			return false;
		}

		internal bool IsSetStartingSequenceNumber()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}

		internal bool IsSetTimestamp()
		{
			return false;
		}
	}
}
