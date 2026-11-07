using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class MetricsName : ConstantClass
	{
		public static readonly MetricsName ALL;

		public static readonly MetricsName IncomingBytes;

		public static readonly MetricsName IncomingRecords;

		public static readonly MetricsName IteratorAgeMilliseconds;

		public static readonly MetricsName OutgoingBytes;

		public static readonly MetricsName OutgoingRecords;

		public static readonly MetricsName ReadProvisionedThroughputExceeded;

		public static readonly MetricsName WriteProvisionedThroughputExceeded;

		public MetricsName(string value)
			: base(null)
		{
		}

		public static MetricsName FindValue(string value)
		{
			return null;
		}

		public static implicit operator MetricsName(string value)
		{
			return null;
		}
	}
}
