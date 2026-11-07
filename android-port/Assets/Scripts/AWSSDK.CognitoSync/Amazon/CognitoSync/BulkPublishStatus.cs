using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000005")]
	public class BulkPublishStatus : ConstantClass
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BulkPublishStatus FAILED;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BulkPublishStatus IN_PROGRESS;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		public static readonly BulkPublishStatus NOT_STARTED;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		public static readonly BulkPublishStatus SUCCEEDED;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1191E20", Offset = "0x1191E20", VA = "0x1191E20")]
		public BulkPublishStatus(string value)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1191EAC", Offset = "0x1191EAC", VA = "0x1191EAC")]
		public static BulkPublishStatus FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1191F3C", Offset = "0x1191F3C", VA = "0x1191F3C")]
		public static implicit operator BulkPublishStatus(string value)
		{
			return null;
		}
	}
}
