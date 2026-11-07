using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000291")]
	public static class SNSActionIdentifiers
	{
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllSNSActions;

		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier AddPermission;

		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier ConfirmSubscription;

		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreatePlatformApplication;

		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier CreatePlatformEndpoint;

		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier CreateTopic;

		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeleteEndpoint;

		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DeletePlatformApplication;

		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier DeleteTopic;

		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier GetEndpointAttributes;

		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier GetPlatformApplicationAttributes;

		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier GetSubscriptionAttributes;

		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier GetTopicAttributes;

		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier ListEndpointsByPlatformApplication;

		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier ListPlatformApplications;

		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier ListSubscriptions;

		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier ListSubscriptionsByTopic;

		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier ListTopics;

		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier Publish;

		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x98")]
		public static readonly ActionIdentifier RemovePermission;

		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly ActionIdentifier SetEndpointAttributes;

		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly ActionIdentifier SetPlatformApplicationAttributes;

		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly ActionIdentifier SetSubscriptionAttributes;

		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly ActionIdentifier SetTopicAttributes;

		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly ActionIdentifier Subscribe;

		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly ActionIdentifier Unsubscribe;
	}
}
