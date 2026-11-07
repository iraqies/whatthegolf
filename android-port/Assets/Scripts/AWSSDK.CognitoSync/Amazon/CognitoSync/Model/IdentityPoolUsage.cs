using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class IdentityPoolUsage
	{
		private long? _dataStorage;

		private string _identityPoolId;

		private DateTime? _lastModifiedDate;

		private long? _syncSessionsCount;

		public long DataStorage
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

		public DateTime LastModifiedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public long SyncSessionsCount
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal bool IsSetDataStorage()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetSyncSessionsCount()
		{
			return false;
		}
	}
}
