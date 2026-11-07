using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000281")]
	public static class GlacierActionIdentifiers
	{
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllGlacierActions;

		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier AbortMultipartUpload;

		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CompleteMultipartUpload;

		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreateVault;

		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteArchive;

		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteVault;

		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeleteVaultNotifications;

		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DescribeJob;

		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier DescribeVault;

		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier GetJobOutput;

		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier GetVaultNotifications;

		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier InitiateMultipartUpload;

		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier InitiateJob;

		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier ListJobs;

		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier ListMultipartUploads;

		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier ListParts;

		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier ListVaults;

		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier SetVaultNotifications;

		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier UploadArchive;

		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x98")]
		public static readonly ActionIdentifier UploadMultipartPart;
	}
}
