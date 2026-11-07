using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class UpdateRecordsRequest : AmazonCognitoSyncRequest
	{
		private string _clientContext;

		private string _datasetName;

		private string _deviceId;

		private string _identityId;

		private string _identityPoolId;

		private List<RecordPatch> _recordPatches;

		private string _syncSessionToken;

		public string ClientContext
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
		public string DeviceId
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

		public List<RecordPatch> RecordPatches
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

		internal bool IsSetClientContext()
		{
			return false;
		}

		internal bool IsSetDatasetName()
		{
			return false;
		}

		internal bool IsSetDeviceId()
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

		internal bool IsSetRecordPatches()
		{
			return false;
		}

		internal bool IsSetSyncSessionToken()
		{
			return false;
		}
	}
}
