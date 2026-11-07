using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000015")]
	public class EventType : ConstantClass
	{
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EventType ForgotPassword;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly EventType SignIn;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly EventType SignUp;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1112B68", Offset = "0x1112B68", VA = "0x1112B68")]
		public EventType(string value)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1112BF4", Offset = "0x1112BF4", VA = "0x1112BF4")]
		public static EventType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1112C84", Offset = "0x1112C84", VA = "0x1112C84")]
		public static implicit operator EventType(string value)
		{
			return null;
		}
	}
}
