using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class Shard
	{
		private string _adjacentParentShardId;

		private HashKeyRange _hashKeyRange;

		private string _parentShardId;

		private SequenceNumberRange _sequenceNumberRange;

		private string _shardId;

		[AWSProperty]
		public string AdjacentParentShardId
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
		public HashKeyRange HashKeyRange
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
		public string ParentShardId
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
		public SequenceNumberRange SequenceNumberRange
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

		internal bool IsSetAdjacentParentShardId()
		{
			return false;
		}

		internal bool IsSetHashKeyRange()
		{
			return false;
		}

		internal bool IsSetParentShardId()
		{
			return false;
		}

		internal bool IsSetSequenceNumberRange()
		{
			return false;
		}

		internal bool IsSetShardId()
		{
			return false;
		}
	}
}
