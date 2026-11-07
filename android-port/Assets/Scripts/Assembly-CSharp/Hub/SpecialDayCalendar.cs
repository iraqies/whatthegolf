using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001085")]
	public class SpecialDayCalendar : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2001086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x479D4", Offset = "0x479D4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40056EB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40056EC")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpecialDayStage, bool> _003C_003E9__4_0;

			[Token(Token = "0x6004A19")]
			[Address(RVA = "0x18547D8", Offset = "0x18547D8", VA = "0x18547D8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004A1A")]
			[Address(RVA = "0x18547E0", Offset = "0x18547E0", VA = "0x18547E0")]
			internal bool _003CGetCurrentStage_003Eb__4_0(SpecialDayStage s)
			{
				return default;
			}
		}

		[Token(Token = "0x40056E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DailyChallengeLevelDataContainer currentSpecial;

		[Token(Token = "0x40056EA")]
		[FieldOffset(Offset = "0x20")]
		private int _lastDayListSorted;

		[Token(Token = "0x170007CD")]
		private DailyChallengeLevelDataContainerContainer Specials
		{
			[Token(Token = "0x6004A12")]
			[Address(RVA = "0x16C9230", Offset = "0x16C9230", VA = "0x16C9230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x16C9238", Offset = "0x16C9238", VA = "0x16C9238")]
		public SpecialDayStage GetCurrentStage()
		{
			return null;
		}

		[Token(Token = "0x6004A14")]
		[Address(RVA = "0x16C9670", Offset = "0x16C9670", VA = "0x16C9670")]
		private DailyChallengeLevelDataContainer GetCurrentSpecial()
		{
			return null;
		}

		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x16C9960", Offset = "0x16C9960", VA = "0x16C9960")]
		public static TimeSpan TimeUntilSpecialActive(DailyChallengeLevelDataContainer challengePack)
		{
			return default;
		}

		[Token(Token = "0x6004A16")]
		[Address(RVA = "0x16C9B48", Offset = "0x16C9B48", VA = "0x16C9B48")]
		public static TimeSpan TimeUntilSpecialOver(DailyChallengeLevelDataContainer challengePack)
		{
			return default;
		}

		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x16C9C0C", Offset = "0x16C9C0C", VA = "0x16C9C0C")]
		public SpecialDayCalendar()
		{
		}
	}
}
