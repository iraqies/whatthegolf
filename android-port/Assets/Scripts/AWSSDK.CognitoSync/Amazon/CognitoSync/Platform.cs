using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000007")]
	public class Platform : ConstantClass
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Platform ADM;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Platform APNS;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Platform APNS_SANDBOX;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Platform GCM;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x11A3FE4", Offset = "0x11A3FE4", VA = "0x11A3FE4")]
		public Platform(string value)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x11A4070", Offset = "0x11A4070", VA = "0x11A4070")]
		public static Platform FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x11A4100", Offset = "0x11A4100", VA = "0x11A4100")]
		public static implicit operator Platform(string value)
		{
			return null;
		}
	}
}
