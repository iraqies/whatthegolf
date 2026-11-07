using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000013")]
	public class EventFilterType : ConstantClass
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EventFilterType PASSWORD_CHANGE;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x8")]
		public static readonly EventFilterType SIGN_IN;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x10")]
		public static readonly EventFilterType SIGN_UP;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1111DD0", Offset = "0x1111DD0", VA = "0x1111DD0")]
		public EventFilterType(string value)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1111E5C", Offset = "0x1111E5C", VA = "0x1111E5C")]
		public static EventFilterType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1111EEC", Offset = "0x1111EEC", VA = "0x1111EEC")]
		public static implicit operator EventFilterType(string value)
		{
			return null;
		}
	}
}
