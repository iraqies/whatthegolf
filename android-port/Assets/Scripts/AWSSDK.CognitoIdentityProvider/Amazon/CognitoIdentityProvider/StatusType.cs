using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class StatusType : ConstantClass
	{
		public static readonly StatusType Disabled;

		public static readonly StatusType Enabled;

		public StatusType(string value)
			: base(null)
		{
		}

		public static StatusType FindValue(string value)
		{
			return null;
		}

		public static implicit operator StatusType(string value)
		{
			return null;
		}
	}
}
