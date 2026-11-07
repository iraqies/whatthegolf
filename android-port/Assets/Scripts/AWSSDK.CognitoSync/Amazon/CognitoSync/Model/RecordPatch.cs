using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class RecordPatch
	{
		private DateTime? _deviceLastModifiedDate;

		private string _key;

		private Operation _op;

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

		[AWSProperty]
		public Operation Op
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

		internal bool IsSetOp()
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
