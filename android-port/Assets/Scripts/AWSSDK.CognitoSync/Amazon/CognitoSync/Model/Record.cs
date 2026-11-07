using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class Record
	{
		private DateTime? _deviceLastModifiedDate;

		private string _key;

		private string _lastModifiedBy;

		private DateTime? _lastModifiedDate;

		private long? _syncCount;

		private string _value;

		public DateTime DeviceLastModifiedDate
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
		public string Key
		{
			get
			{
				return null;
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

		public long SyncCount
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
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDeviceLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetKey()
		{
			return false;
		}

		internal bool IsSetLastModifiedBy()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetSyncCount()
		{
			return false;
		}

		internal bool IsSetValue()
		{
			return false;
		}
	}
}
