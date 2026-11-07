using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000283")]
	public static class ImportExportActionIdentifiers
	{
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllImportExportActions;

		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateJob;

		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier UpdateJob;

		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CancelJob;

		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier ListJobs;

		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier GetStatus;
	}
}
