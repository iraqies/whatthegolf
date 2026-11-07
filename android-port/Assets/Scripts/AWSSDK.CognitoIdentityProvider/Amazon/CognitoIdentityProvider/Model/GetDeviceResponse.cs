using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GetDeviceResponse : AmazonWebServiceResponse
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
