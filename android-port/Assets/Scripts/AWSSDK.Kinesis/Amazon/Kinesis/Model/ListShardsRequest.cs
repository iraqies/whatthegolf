using System;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListShardsRequest : AmazonKinesisRequest
	{
		private string _exclusiveStartShardId;

		private int? _maxResults;

		private string _nextToken;

		private DateTime? _streamCreationTimestamp;

		private string _streamName;

		[AWSProperty]
		public string ExclusiveStartShardId
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
		public int MaxResults
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
		public string NextToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		internal bool IsSetExclusiveStartShardId()
		{
			return false;
		}

		internal bool IsSetMaxResults()
		{
			return false;
		}

		internal bool IsSetNextToken()
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
	}
}
