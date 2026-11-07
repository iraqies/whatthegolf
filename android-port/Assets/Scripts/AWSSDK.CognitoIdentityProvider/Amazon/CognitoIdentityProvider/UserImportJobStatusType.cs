using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000020")]
	public class UserImportJobStatusType : ConstantClass
	{
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UserImportJobStatusType Created;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UserImportJobStatusType Expired;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		public static readonly UserImportJobStatusType Failed;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		public static readonly UserImportJobStatusType InProgress;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x20")]
		public static readonly UserImportJobStatusType Pending;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		public static readonly UserImportJobStatusType Stopped;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x30")]
		public static readonly UserImportJobStatusType Stopping;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x38")]
		public static readonly UserImportJobStatusType Succeeded;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1172360", Offset = "0x1172360", VA = "0x1172360")]
		public UserImportJobStatusType(string value)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x11723EC", Offset = "0x11723EC", VA = "0x11723EC")]
		public static UserImportJobStatusType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x117247C", Offset = "0x117247C", VA = "0x117247C")]
		public static implicit operator UserImportJobStatusType(string value)
		{
			return null;
		}
	}
}
