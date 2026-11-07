using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class SubscribeToDatasetRequest : AmazonCognitoSyncRequest
	{
		private string _datasetName;

		private string _deviceId;

		private string _identityId;

		private string _identityPoolId;

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
	}
}
