using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class StreamStatus : ConstantClass
	{
		public static readonly StreamStatus ACTIVE;

		public static readonly StreamStatus CREATING;

		public static readonly StreamStatus DELETING;

		public static readonly StreamStatus UPDATING;

		public StreamStatus(string value)
			: base(null)
		{
		}

		public static StreamStatus FindValue(string value)
		{
			return null;
		}

		public static implicit operator StreamStatus(string value)
		{
			return null;
		}
	}
}
