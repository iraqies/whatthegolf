using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000014")]
	public class ErrorCode : ConstantClass
	{
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ErrorCode AccessDenied;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ErrorCode InternalServerError;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1083BC4", Offset = "0x1083BC4", VA = "0x1083BC4")]
		public ErrorCode(string value)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1083C50", Offset = "0x1083C50", VA = "0x1083C50")]
		public static ErrorCode FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1083CE0", Offset = "0x1083CE0", VA = "0x1083CE0")]
		public static implicit operator ErrorCode(string value)
		{
			return null;
		}
	}
}
