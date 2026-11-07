using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000023")]
	public class UserStatusType : ConstantClass
	{
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UserStatusType ARCHIVED;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UserStatusType COMPROMISED;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x10")]
		public static readonly UserStatusType CONFIRMED;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x18")]
		public static readonly UserStatusType FORCE_CHANGE_PASSWORD;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		public static readonly UserStatusType RESET_REQUIRED;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		public static readonly UserStatusType UNCONFIRMED;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x30")]
		public static readonly UserStatusType UNKNOWN;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x117811C", Offset = "0x117811C", VA = "0x117811C")]
		public UserStatusType(string value)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x11781A8", Offset = "0x11781A8", VA = "0x11781A8")]
		public static UserStatusType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1178238", Offset = "0x1178238", VA = "0x1178238")]
		public static implicit operator UserStatusType(string value)
		{
			return null;
		}
	}
}
