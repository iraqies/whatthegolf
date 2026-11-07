using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000274")]
	public static class CloudTrailActionIdentifiers
	{
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCloudTrailActions;

		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateTrail;

		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DeleteTrail;

		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DescribeTrails;

		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier GetTrailStatus;

		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier StartLogging;

		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier StopLogging;

		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier UpdateTrail;
	}
}
