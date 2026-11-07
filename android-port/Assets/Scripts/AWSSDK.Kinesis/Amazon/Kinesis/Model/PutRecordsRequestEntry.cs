using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class PutRecordsRequestEntry
	{
		private MemoryStream _data;

		private string _explicitHashKey;

		private string _partitionKey;

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
	}
}
