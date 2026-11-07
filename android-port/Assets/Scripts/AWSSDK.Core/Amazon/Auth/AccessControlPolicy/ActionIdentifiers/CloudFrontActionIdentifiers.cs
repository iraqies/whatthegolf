using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000272")]
	public static class CloudFrontActionIdentifiers
	{
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCloudFrontActions;

		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateCloudFrontOriginAccessIdentity;

		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CreateDistribution;

		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreateInvalidation;

		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier CreateStreamingDistribution;

		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteCloudFrontOriginAccessIdentity;

		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeleteDistribution;

		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DeleteStreamingDistribution;

		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier GetCloudFrontOriginAccessIdentity;

		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier GetCloudFrontOriginAccessIdentityConfig;

		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier GetDistribution;

		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier GetDistributionConfig;

		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier GetInvalidation;

		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier GetStreamingDistribution;

		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier GetStreamingDistributionConfig;

		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier ListCloudFrontOriginAccessIdentities;

		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier ListDistributions;

		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier ListInvalidations;

		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier ListStreamingDistributions;

		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x98")]
		public static readonly ActionIdentifier UpdateCloudFrontOriginAccessIdentity;

		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly ActionIdentifier UpdateDistribution;

		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly ActionIdentifier UpdateStreamingDistribution;
	}
}
