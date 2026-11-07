using System;
using Core;
using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Token(Token = "0x2001123")]
	public class AnalyticsData
	{
		[Token(Token = "0x4005AC3")]
		[FieldOffset(Offset = "0x10")]
		public float totalTimePlayed;

		[Token(Token = "0x4005AC4")]
		[FieldOffset(Offset = "0x18")]
		public AnalyticsTotalsData totalTotals;

		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x1415350", Offset = "0x1415350", VA = "0x1415350")]
		public void UpdateTotals(Action<AnalyticsTotalsData> updateAction)
		{
		}

		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x14153B4", Offset = "0x14153B4", VA = "0x14153B4")]
		public AnalyticsLevelData CreateLevelData(LevelData level, string challengeId)
		{
			return null;
		}

		[Token(Token = "0x6004D44")]
		[Address(RVA = "0x1415490", Offset = "0x1415490", VA = "0x1415490")]
		public AnalyticsData()
		{
		}
	}
}
