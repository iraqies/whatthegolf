using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000276")]
	public static class CloudWatchLogsActionIdentifiers
	{
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCloudWatchLogsActions;

		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateLogGroup;

		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CreateLogStream;

		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DeleteLogGroup;

		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteLogStream;

		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteMetricFilter;

		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeleteRetentionPolicy;

		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DescribeLogGroups;

		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier DescribeLogStreams;

		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier DescribeMetricFilters;

		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier GetLogEvents;

		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier PutLogEvents;

		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier PutMetricFilter;

		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier PutRetentionPolicy;

		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier TestMetricFilter;
	}
}
