using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class Dataset
	{
		private DateTime? _creationDate;

		private string _datasetName;

		private long? _dataStorage;

		private string _identityId;

		private string _lastModifiedBy;

		private DateTime? _lastModifiedDate;

		private long? _numRecords;

		public DateTime CreationDate
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

		public long NumRecords
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetDatasetName()
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

		internal bool IsSetLastModifiedBy()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetNumRecords()
		{
			return false;
		}
	}
}
