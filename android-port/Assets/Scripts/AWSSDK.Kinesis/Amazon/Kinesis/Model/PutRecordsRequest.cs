using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class PutRecordsRequest : AmazonKinesisRequest
	{
		private List<PutRecordsRequestEntry> _records;

		private string _streamName;

		[AWSProperty]
		public List<PutRecordsRequestEntry> Records
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

		internal bool IsSetRecords()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
