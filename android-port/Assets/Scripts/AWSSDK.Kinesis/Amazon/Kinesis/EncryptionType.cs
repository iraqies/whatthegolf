using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000006")]
	public class EncryptionType : ConstantClass
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EncryptionType KMS;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x8")]
		public static readonly EncryptionType NONE;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x12AF934", Offset = "0x12AF934", VA = "0x12AF934")]
		public EncryptionType(string value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x12AF9C0", Offset = "0x12AF9C0", VA = "0x12AF9C0")]
		public static EncryptionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12AFA50", Offset = "0x12AFA50", VA = "0x12AFA50")]
		public static implicit operator EncryptionType(string value)
		{
			return null;
		}
	}
}
