using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class EncryptionType : ConstantClass
	{
		public static readonly EncryptionType KMS;

		public static readonly EncryptionType NONE;

		public EncryptionType(string value)
			: base(null)
		{
		}

		public static EncryptionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator EncryptionType(string value)
		{
			return null;
		}
	}
}
