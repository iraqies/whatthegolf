using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000010")]
	public class DeviceRememberedStatusType : ConstantClass
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DeviceRememberedStatusType Not_remembered;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DeviceRememberedStatusType Remembered;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x110ECCC", Offset = "0x110ECCC", VA = "0x110ECCC")]
		public DeviceRememberedStatusType(string value)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x110ED58", Offset = "0x110ED58", VA = "0x110ED58")]
		public static DeviceRememberedStatusType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x110EDE8", Offset = "0x110EDE8", VA = "0x110EDE8")]
		public static implicit operator DeviceRememberedStatusType(string value)
		{
			return null;
		}
	}
}
