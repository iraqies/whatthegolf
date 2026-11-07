using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Token(Token = "0x2001124")]
	public class AnalyticsLevelData
	{
		[Token(Token = "0x4005AC5")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4005AC6")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		[Token(Token = "0x4005AC7")]
		[FieldOffset(Offset = "0x20")]
		public string challengeId;

		[Token(Token = "0x4005AC8")]
		[FieldOffset(Offset = "0x28")]
		public string campaignId;

		[Token(Token = "0x4005AC9")]
		[FieldOffset(Offset = "0x30")]
		public string flagId;

		[Token(Token = "0x4005ACA")]
		[FieldOffset(Offset = "0x38")]
		public string sectionId;

		[Token(Token = "0x4005ACB")]
		[FieldOffset(Offset = "0x40")]
		public bool isOnboarding;

		[Token(Token = "0x4005ACC")]
		[FieldOffset(Offset = "0x44")]
		public int manualRetries;

		[Token(Token = "0x4005ACD")]
		[FieldOffset(Offset = "0x48")]
		public int fails;

		[Token(Token = "0x4005ACE")]
		[FieldOffset(Offset = "0x4C")]
		public float lastCompleteTime;

		[Token(Token = "0x4005ACF")]
		[FieldOffset(Offset = "0x50")]
		public int currentStrokes;

		[Token(Token = "0x1700082C")]
		public bool isChallenge
		{
			[Token(Token = "0x6004D45")]
			[Address(RVA = "0x1415514", Offset = "0x1415514", VA = "0x1415514")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004D46")]
		[Address(RVA = "0x1415480", Offset = "0x1415480", VA = "0x1415480")]
		public AnalyticsLevelData()
		{
		}
	}
}
