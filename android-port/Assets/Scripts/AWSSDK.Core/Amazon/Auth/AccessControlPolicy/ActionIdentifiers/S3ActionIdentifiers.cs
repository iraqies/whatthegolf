using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200028C")]
	public static class S3ActionIdentifiers
	{
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllS3Actions;

		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier AbortMultipartUpload;

		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CreateBucket;

		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DeleteBucket;

		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteBucketPolicy;

		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteBucketWebsite;

		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeleteObject;

		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DeleteObjectVersion;

		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier GetBucketAcl;

		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier GetBucketCORS;

		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier GetBucketLocation;

		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier GetBucketLogging;

		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier GetBucketNotification;

		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier GetBucketPolicy;

		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier GetBucketRequestPayment;

		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier GetBucketTagging;

		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier GetBucketVersioning;

		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier GetBucketWebsite;

		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier GetLifecycleConfiguration;

		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x98")]
		public static readonly ActionIdentifier GetObject;

		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly ActionIdentifier GetObjectAcl;

		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly ActionIdentifier GetObjectTorrent;

		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly ActionIdentifier GetObjectVersion;

		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly ActionIdentifier GetObjectVersionAcl;

		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly ActionIdentifier GetObjectVersionTorrent;

		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly ActionIdentifier ListAllMyBuckets;

		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly ActionIdentifier ListBucket;

		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly ActionIdentifier ListBucketMultipartUploads;

		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly ActionIdentifier ListBucketVersions;

		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly ActionIdentifier ListMultipartUploadParts;

		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly ActionIdentifier PutBucketAcl;

		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly ActionIdentifier PutBucketCORS;

		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x100")]
		public static readonly ActionIdentifier PutBucketLogging;

		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x108")]
		public static readonly ActionIdentifier PutBucketNotification;

		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x110")]
		public static readonly ActionIdentifier PutBucketPolicy;

		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x118")]
		public static readonly ActionIdentifier PutBucketRequestPayment;

		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x120")]
		public static readonly ActionIdentifier PutBucketTagging;

		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x128")]
		public static readonly ActionIdentifier PutBucketVersioning;

		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x130")]
		public static readonly ActionIdentifier PutBucketWebsite;

		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x138")]
		public static readonly ActionIdentifier PutLifecycleConfiguration;

		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x140")]
		public static readonly ActionIdentifier PutObject;

		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x148")]
		public static readonly ActionIdentifier PutObjectAcl;

		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x150")]
		public static readonly ActionIdentifier PutObjectVersionAcl;

		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x158")]
		public static readonly ActionIdentifier RestoreObject;
	}
}
