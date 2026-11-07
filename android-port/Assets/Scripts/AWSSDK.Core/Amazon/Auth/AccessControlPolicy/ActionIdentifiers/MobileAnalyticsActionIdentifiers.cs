using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000287")]
	public static class MobileAnalyticsActionIdentifiers
	{
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllMobileAnalyticsActions;

		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier PutEvents;

		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier GetReports;

		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier GetFinancialReports;
	}
}
