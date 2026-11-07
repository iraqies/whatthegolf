using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000275")]
	public static class CloudWatchActionIdentifiers
	{
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCloudWatchActions;

		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier DeleteAlarms;

		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DescribeAlarmHistory;

		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DescribeAlarms;

		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DescribeAlarmsForMetric;

		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DisableAlarmActions;

		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier EnableAlarmActions;

		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier GetMetricStatistics;

		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier ListMetrics;

		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier PutMetricAlarm;

		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier PutMetricData;

		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier SetAlarmState;
	}
}
