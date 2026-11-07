using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000017")]
	public class FeedbackValueType : ConstantClass
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FeedbackValueType Invalid;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x8")]
		public static readonly FeedbackValueType Valid;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x11136F0", Offset = "0x11136F0", VA = "0x11136F0")]
		public FeedbackValueType(string value)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x111377C", Offset = "0x111377C", VA = "0x111377C")]
		public static FeedbackValueType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1111C44", Offset = "0x1111C44", VA = "0x1111C44")]
		public static implicit operator FeedbackValueType(string value)
		{
			return null;
		}
	}
}
