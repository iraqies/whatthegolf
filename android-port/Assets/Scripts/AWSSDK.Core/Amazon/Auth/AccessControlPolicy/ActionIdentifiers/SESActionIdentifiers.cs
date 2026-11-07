using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200028E")]
	public static class SESActionIdentifiers
	{
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllSESActions;

		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier DeleteIdentity;

		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DeleteVerifiedEmailAddress;

		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier GetIdentityDkimAttributes;

		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier GetIdentityNotificationAttributes;

		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier GetIdentityVerificationAttributes;

		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier GetSendQuota;

		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier GetSendStatistics;

		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier ListIdentities;

		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier ListVerifiedEmailAddresses;

		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier SendEmail;

		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier SendRawEmail;

		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier SetIdentityDkimEnabled;

		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier SetIdentityNotificationTopic;

		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier SetIdentityFeedbackForwardingEnabled;

		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier VerifyDomainDkim;

		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier VerifyDomainIdentity;

		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier VerifyEmailAddress;

		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier VerifyEmailIdentity;
	}
}
