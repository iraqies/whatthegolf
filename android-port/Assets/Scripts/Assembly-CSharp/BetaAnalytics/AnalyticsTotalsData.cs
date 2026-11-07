using System;
using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Serializable]
	[Token(Token = "0x2001126")]
	public class AnalyticsTotalsData
	{
		[Token(Token = "0x4005AD0")]
		[FieldOffset(Offset = "0x10")]
		public float totalTimeInOverworld;

		[Token(Token = "0x4005AD1")]
		[FieldOffset(Offset = "0x14")]
		public float totalTimeInPlainLevels;

		[Token(Token = "0x4005AD2")]
		[FieldOffset(Offset = "0x18")]
		public float totalTimeInChallenges;

		[Token(Token = "0x4005AD3")]
		[FieldOffset(Offset = "0x1C")]
		public int totalShotsInOnboarding;

		[Token(Token = "0x4005AD4")]
		[FieldOffset(Offset = "0x20")]
		public int totalShotsInOverworld;

		[Token(Token = "0x4005AD5")]
		[FieldOffset(Offset = "0x24")]
		public int totalShotsInLevels;

		[Token(Token = "0x4005AD6")]
		[FieldOffset(Offset = "0x28")]
		public int talkingThingsHit;

		[Token(Token = "0x4005AD7")]
		[FieldOffset(Offset = "0x2C")]
		public int flagDialogsCancelCount;

		[Token(Token = "0x4005AD8")]
		[FieldOffset(Offset = "0x30")]
		public float firstCrownTime;

		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x1415504", Offset = "0x1415504", VA = "0x1415504")]
		public AnalyticsTotalsData()
		{
		}
	}
}
