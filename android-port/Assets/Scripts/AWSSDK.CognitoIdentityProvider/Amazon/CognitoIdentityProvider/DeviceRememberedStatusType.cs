using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class DeviceRememberedStatusType : ConstantClass
	{
		public static readonly DeviceRememberedStatusType Not_remembered;

		public static readonly DeviceRememberedStatusType Remembered;

		public DeviceRememberedStatusType(string value)
			: base(null)
		{
		}

		public static DeviceRememberedStatusType FindValue(string value)
		{
			return null;
		}

		public static implicit operator DeviceRememberedStatusType(string value)
		{
			return null;
		}
	}
}
