using Amazon.Runtime;

namespace Amazon.CognitoSync
{
	public class Operation : ConstantClass
	{
		public static readonly Operation Remove;

		public static readonly Operation Replace;

		public Operation(string value)
			: base(null)
		{
		}

		public static Operation FindValue(string value)
		{
			return null;
		}

		public static implicit operator Operation(string value)
		{
			return null;
		}
	}
}
