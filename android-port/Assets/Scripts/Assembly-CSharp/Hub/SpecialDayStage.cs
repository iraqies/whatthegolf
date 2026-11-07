using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Serializable]
	[Token(Token = "0x200108B")]
	public class SpecialDayStage
	{
		[Token(Token = "0x200108C")]
		public enum CountdownType
		{
			[Token(Token = "0x4005700")]
			ComingSoon = 0,
			[Token(Token = "0x4005701")]
			DaysLeft = 1,
			[Token(Token = "0x4005702")]
			Live = 2,
			[Token(Token = "0x4005703")]
			EventEnded = 3
		}

		[Token(Token = "0x40056FA")]
		[FieldOffset(Offset = "0x10")]
		public bool IsAvailable;

		[Token(Token = "0x40056FB")]
		[FieldOffset(Offset = "0x18")]
		public GameObject RoomDressing;

		[Token(Token = "0x40056FC")]
		[FieldOffset(Offset = "0x20")]
		public int DurationInDays;

		[Token(Token = "0x40056FD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CountdownType countdownType;

		[Token(Token = "0x40056FE")]
		[FieldOffset(Offset = "0x28")]
		private DailyChallengeLevelDataContainer _special;

		[Token(Token = "0x170007D1")]
		private DailyChallengeLevelDataContainerContainer Container
		{
			[Token(Token = "0x6004A2E")]
			[Address(RVA = "0x16CB8DC", Offset = "0x16CB8DC", VA = "0x16CB8DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D2")]
		public string SpecialPackName
		{
			[Token(Token = "0x6004A2F")]
			[Address(RVA = "0x16CB8E4", Offset = "0x16CB8E4", VA = "0x16CB8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D3")]
		private DailyChallengeLevelDataContainer Special
		{
			[Token(Token = "0x6004A30")]
			[Address(RVA = "0x16CB904", Offset = "0x16CB904", VA = "0x16CB904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x16C9CA8", Offset = "0x16C9CA8", VA = "0x16C9CA8")]
		public string GetCountdownText()
		{
			return null;
		}

		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x16CBA28", Offset = "0x16CBA28", VA = "0x16CBA28")]
		public SpecialDayStage()
		{
		}

		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x16CBA30", Offset = "0x16CBA30", VA = "0x16CBA30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F464", Offset = "0x6F464")]
		private bool _003Cget_Special_003Eb__10_0(DailyChallengeLevelDataContainer c)
		{
			return default;
		}
	}
}
