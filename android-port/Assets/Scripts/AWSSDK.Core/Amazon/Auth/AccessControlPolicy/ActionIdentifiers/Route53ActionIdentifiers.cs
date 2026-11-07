using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200028B")]
	public static class Route53ActionIdentifiers
	{
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllRoute53Actions;

		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier ChangeResourceRecordSets;

		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CreateHostedZone;

		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DeleteHostedZone;

		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier GetChange;

		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier GetHostedZone;

		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier ListHostedZones;

		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier ListResourceRecordSets;
	}
}
