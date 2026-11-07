using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class IdentityUsage
	{
		private int? _datasetCount;

		private long? _dataStorage;

		private string _identityId;

		private string _identityPoolId;

		private DateTime? _lastModifiedDate;

		public int DatasetCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		internal bool IsSetDatasetCount()
		{
			return false;
		}

		internal bool IsSetDataStorage()
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

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}
	}
}
