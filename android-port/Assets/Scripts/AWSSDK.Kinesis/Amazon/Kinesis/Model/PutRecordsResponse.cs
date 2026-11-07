using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class PutRecordsResponse : AmazonWebServiceResponse
	{
		private EncryptionType _encryptionType;

		private int? _failedRecordCount;

		private List<PutRecordsResultEntry> _records;

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
		public int FailedRecordCount
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
		public List<PutRecordsResultEntry> Records
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

		internal bool IsSetFailedRecordCount()
		{
			return false;
		}

		internal bool IsSetRecords()
		{
			return false;
		}
	}
}
