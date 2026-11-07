using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminGetDeviceResponse : AmazonWebServiceResponse
	{
		private DeviceType _device;

		[AWSProperty]
		public DeviceType Device
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDevice()
		{
			return false;
		}
	}
}
