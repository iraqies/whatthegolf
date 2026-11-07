using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class ListRecordsRequest : AmazonCognitoSyncRequest
	{
		private string _datasetName;

		private string _identityId;

		private string _identityPoolId;

		private long? _lastSyncCount;

		private int? _maxResults;

		private string _nextToken;

		private string _syncSessionToken;

		[AWSProperty]
		public string DatasetName
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
		public string IdentityId
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
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long LastSyncCount
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

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

		internal bool IsSetDatasetName()
		{
			return false;
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetLastSyncCount()
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

		internal bool IsSetSyncSessionToken()
		{
			return false;
		}
	}
}
