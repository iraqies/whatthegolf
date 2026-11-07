using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class RegisterDeviceResponse : AmazonWebServiceResponse
	{
		private string _deviceId;

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

		internal bool IsSetDeviceId()
		{
			return false;
		}
	}
}
