using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000014")]
	public class EventResponseType : ConstantClass
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EventResponseType Failure;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		public static readonly EventResponseType Success;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x111215C", Offset = "0x111215C", VA = "0x111215C")]
		public EventResponseType(string value)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x11121E8", Offset = "0x11121E8", VA = "0x11121E8")]
		public static EventResponseType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1112278", Offset = "0x1112278", VA = "0x1112278")]
		public static implicit operator EventResponseType(string value)
		{
			return null;
		}
	}
}
