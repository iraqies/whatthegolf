using System;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListStreamConsumersRequest : AmazonKinesisRequest
	{
		private int? _maxResults;

		private string _nextToken;

		private string _streamARN;

		private DateTime? _streamCreationTimestamp;

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

		internal bool IsSetMaxResults()
		{
			return false;
		}

		internal bool IsSetNextToken()
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
	}
}
