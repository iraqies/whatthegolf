using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000009")]
	public class AuthFlowType : ConstantClass
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AuthFlowType ADMIN_NO_SRP_AUTH;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AuthFlowType ADMIN_USER_PASSWORD_AUTH;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AuthFlowType CUSTOM_AUTH;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		public static readonly AuthFlowType REFRESH_TOKEN;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		public static readonly AuthFlowType REFRESH_TOKEN_AUTH;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		public static readonly AuthFlowType USER_PASSWORD_AUTH;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AuthFlowType USER_SRP_AUTH;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x10DF730", Offset = "0x10DF730", VA = "0x10DF730")]
		public AuthFlowType(string value)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x10DF7BC", Offset = "0x10DF7BC", VA = "0x10DF7BC")]
		public static AuthFlowType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x10DF84C", Offset = "0x10DF84C", VA = "0x10DF84C")]
		public static implicit operator AuthFlowType(string value)
		{
			return null;
		}
	}
}
