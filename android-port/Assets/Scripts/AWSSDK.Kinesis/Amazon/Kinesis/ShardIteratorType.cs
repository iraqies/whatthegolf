using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class ShardIteratorType : ConstantClass
	{
		public static readonly ShardIteratorType AFTER_SEQUENCE_NUMBER;

		public static readonly ShardIteratorType AT_SEQUENCE_NUMBER;

		public static readonly ShardIteratorType AT_TIMESTAMP;

		public static readonly ShardIteratorType LATEST;

		public static readonly ShardIteratorType TRIM_HORIZON;

		public ShardIteratorType(string value)
			: base(null)
		{
		}

		public static ShardIteratorType FindValue(string value)
		{
			return null;
		}

		public static implicit operator ShardIteratorType(string value)
		{
			return null;
		}
	}
}
