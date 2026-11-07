using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000016")]
	public class ExplicitAuthFlowsType : ConstantClass
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ExplicitAuthFlowsType ADMIN_NO_SRP_AUTH;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ExplicitAuthFlowsType ALLOW_ADMIN_USER_PASSWORD_AUTH;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ExplicitAuthFlowsType ALLOW_CUSTOM_AUTH;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ExplicitAuthFlowsType ALLOW_REFRESH_TOKEN_AUTH;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ExplicitAuthFlowsType ALLOW_USER_PASSWORD_AUTH;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ExplicitAuthFlowsType ALLOW_USER_SRP_AUTH;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ExplicitAuthFlowsType CUSTOM_AUTH_FLOW_ONLY;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ExplicitAuthFlowsType USER_PASSWORD_AUTH;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1113134", Offset = "0x1113134", VA = "0x1113134")]
		public ExplicitAuthFlowsType(string value)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x11131C0", Offset = "0x11131C0", VA = "0x11131C0")]
		public static ExplicitAuthFlowsType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1113250", Offset = "0x1113250", VA = "0x1113250")]
		public static implicit operator ExplicitAuthFlowsType(string value)
		{
			return null;
		}
	}
}
