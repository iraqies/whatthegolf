using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class ConsumerStatus : ConstantClass
	{
		public static readonly ConsumerStatus ACTIVE;

		public static readonly ConsumerStatus CREATING;

		public static readonly ConsumerStatus DELETING;

		public ConsumerStatus(string value)
			: base(null)
		{
		}

		public static ConsumerStatus FindValue(string value)
		{
			return null;
		}

		public static implicit operator ConsumerStatus(string value)
		{
			return null;
		}
	}
}
