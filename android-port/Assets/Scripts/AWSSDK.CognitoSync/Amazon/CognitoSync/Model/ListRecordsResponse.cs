using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class ListRecordsResponse : AmazonWebServiceResponse
	{
		private int? _count;

		private bool? _datasetDeletedAfterRequestedSyncCount;

		private bool? _datasetExists;

		private long? _datasetSyncCount;

		private string _lastModifiedBy;

		private List<string> _mergedDatasetNames;

		private string _nextToken;

		private List<Record> _records;

		private string _syncSessionToken;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool DatasetDeletedAfterRequestedSyncCount
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DatasetExists
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long DatasetSyncCount
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string LastModifiedBy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> MergedDatasetNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public string SyncSessionToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCount()
		{
			return false;
		}

		internal bool IsSetDatasetDeletedAfterRequestedSyncCount()
		{
			return false;
		}

		internal bool IsSetDatasetExists()
		{
			return false;
		}

		internal bool IsSetDatasetSyncCount()
		{
			return false;
		}

		internal bool IsSetLastModifiedBy()
		{
			return false;
		}

		internal bool IsSetMergedDatasetNames()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}

		internal bool IsSetRecords()
		{
			return false;
		}

		internal bool IsSetSyncSessionToken()
		{
			return false;
		}
	}
}
