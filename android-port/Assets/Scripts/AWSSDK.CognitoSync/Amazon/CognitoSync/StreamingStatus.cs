using Amazon.Runtime;

namespace Amazon.CognitoSync
{
	public class StreamingStatus : ConstantClass
	{
		public static readonly StreamingStatus DISABLED;

		public static readonly StreamingStatus ENABLED;

		public StreamingStatus(string value)
			: base(null)
		{
		}

		public static StreamingStatus FindValue(string value)
		{
			return null;
		}

		public static implicit operator StreamingStatus(string value)
		{
			return null;
		}
	}
}
