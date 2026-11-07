using Amazon.Runtime;

namespace Amazon.CognitoSync
{
	public class Platform : ConstantClass
	{
		public static readonly Platform ADM;

		public static readonly Platform APNS;

		public static readonly Platform APNS_SANDBOX;

		public static readonly Platform GCM;

		public Platform(string value)
			: base(null)
		{
		}

		public static Platform FindValue(string value)
		{
			return null;
		}

		public static implicit operator Platform(string value)
		{
			return null;
		}
	}
}
