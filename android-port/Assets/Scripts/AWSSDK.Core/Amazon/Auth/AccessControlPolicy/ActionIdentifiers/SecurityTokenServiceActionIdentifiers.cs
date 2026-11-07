using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200028D")]
	public static class SecurityTokenServiceActionIdentifiers
	{
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllSecurityTokenServiceActions;

		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier GetFederationToken;

		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier AssumeRole;
	}
}
