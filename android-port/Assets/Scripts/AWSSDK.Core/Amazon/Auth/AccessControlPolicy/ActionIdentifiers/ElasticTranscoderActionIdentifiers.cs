using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000280")]
	public static class ElasticTranscoderActionIdentifiers
	{
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllElasticTranscoderActions;

		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CancelJob;

		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CreateJob;

		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreatePipeline;

		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier CreatePreset;

		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeletePipeline;

		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeletePreset;

		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier ListJobsByPipeline;

		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier ListJobsByStatus;

		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier ListPipelines;

		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier ListPresets;

		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier ReadJob;

		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier ReadPipeline;

		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier ReadPreset;

		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier TestRole;

		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier UpdatePipeline;

		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier UpdatePipelineNotifications;

		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier UpdatePipelineStatus;
	}
}
