using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class GetRecordsResponse : AmazonWebServiceResponse
	{
		private long? _millisBehindLatest;

		private string _nextShardIterator;

		private List<Record> _records;

		[AWSProperty]
		public long MillisBehindLatest
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string NextShardIterator
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
		public List<Record> Records
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetMillisBehindLatest()
		{
			return false;
		}

		internal bool IsSetNextShardIterator()
		{
			return false;
		}

		internal bool IsSetRecords()
		{
			return false;
		}
	}
}
