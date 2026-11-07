using System;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000558")]
public class DailyChallenges : AddressableSingleton<DailyChallenges>
{
	[Token(Token = "0x2000559")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40424", Offset = "0x40424")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x10")]
		public string packname;

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x17983B4", Offset = "0x17983B4", VA = "0x17983B4")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x17983BC", Offset = "0x17983BC", VA = "0x17983BC")]
		internal bool _003CSetIsDailyPackPlayed_003Eb__1(string s)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x200055A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40434", Offset = "0x40434")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001BAB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, string> _003C_003E9__10_0;

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x179830C", Offset = "0x179830C", VA = "0x179830C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001881")]
		[Address(RVA = "0x1798314", Offset = "0x1798314", VA = "0x1798314")]
		internal string _003CSetIsDailyPackPlayed_003Eb__10_0(string s)
		{
			return null;
		}
	}

	[Token(Token = "0x200055B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40444", Offset = "0x40444")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x10")]
		public DailyChallengeLevelDataContainer pack;

		[Token(Token = "0x6001882")]
		[Address(RVA = "0x1798468", Offset = "0x1798468", VA = "0x1798468")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6001883")]
		[Address(RVA = "0x1798470", Offset = "0x1798470", VA = "0x1798470")]
		internal bool _003CGetPacksForDate_003Eb__1(string x)
		{
			return default;
		}
	}

	[Token(Token = "0x200055C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40454", Offset = "0x40454")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x10")]
		public string specialId;

		[Token(Token = "0x6001884")]
		[Address(RVA = "0x17984F0", Offset = "0x17984F0", VA = "0x17984F0")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001885")]
		[Address(RVA = "0x17984F8", Offset = "0x17984F8", VA = "0x17984F8")]
		internal bool _003CHasSpecialBeenPlayedBefore_003Eb__0(string d)
		{
			return default;
		}
	}

	[Token(Token = "0x200055D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40464", Offset = "0x40464")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4001BAE")]
		[FieldOffset(Offset = "0x10")]
		public string s;

		[Token(Token = "0x6001886")]
		[Address(RVA = "0x179851C", Offset = "0x179851C", VA = "0x179851C")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6001887")]
		[Address(RVA = "0x1798524", Offset = "0x1798524", VA = "0x1798524")]
		internal bool _003CGetSpecialEventByPrizeID_003Eb__0(DailyChallengeLevelDataContainer c)
		{
			return default;
		}
	}

	[Token(Token = "0x200055E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40474", Offset = "0x40474")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x10")]
		public DateTime day;

		[Token(Token = "0x6001888")]
		[Address(RVA = "0x1798554", Offset = "0x1798554", VA = "0x1798554")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6001889")]
		[Address(RVA = "0x179855C", Offset = "0x179855C", VA = "0x179855C")]
		internal bool _003CGetSpecialPack_003Eb__0(DailyChallengeLevelDataContainer s)
		{
			return default;
		}
	}

	[Token(Token = "0x4001BA5")]
	[FieldOffset(Offset = "0x18")]
	internal bool NewPackWasCompletedToday;

	[Token(Token = "0x4001BA6")]
	[FieldOffset(Offset = "0x20")]
	internal DailyChallengeLevelDataContainer lastPackPlayed;

	[Token(Token = "0x4001BA7")]
	[FieldOffset(Offset = "0x28")]
	internal bool isDailyPlaying;

	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly TimeSpan EndOfDay;

	[Token(Token = "0x6001869")]
	[Address(RVA = "0x18CBF48", Offset = "0x18CBF48", VA = "0x18CBF48")]
	public static bool WasLastPlayedToday()
	{
		return default;
	}

	[Token(Token = "0x600186A")]
	[Address(RVA = "0x18CFD0C", Offset = "0x18CFD0C", VA = "0x18CFD0C")]
	public static string DateToString(DateTime dateValue)
	{
		return null;
	}

	[Token(Token = "0x600186B")]
	[Address(RVA = "0x18CFDA0", Offset = "0x18CFDA0", VA = "0x18CFDA0")]
	private static DateTime GetAndAdjustTime(DateTime dt)
	{
		return default;
	}

	[Token(Token = "0x600186C")]
	[Address(RVA = "0x18C95EC", Offset = "0x18C95EC", VA = "0x18C95EC")]
	public static DateTime GetToday()
	{
		return default;
	}

	[Token(Token = "0x600186D")]
	[Address(RVA = "0x18CFDA4", Offset = "0x18CFDA4", VA = "0x18CFDA4")]
	public static TimeSpan GetRemainingDayTime()
	{
		return default;
	}

	[Token(Token = "0x600186E")]
	[Address(RVA = "0x18CFE70", Offset = "0x18CFE70", VA = "0x18CFE70")]
	public static int GetWeekNumber(DateTime time)
	{
		return default;
	}

	[Token(Token = "0x600186F")]
	[Address(RVA = "0x18CFF74", Offset = "0x18CFF74", VA = "0x18CFF74")]
	public static void SetIsDailyPackPlayed(DailyChallengeLevelDataContainer pack)
	{
	}

	[Token(Token = "0x6001870")]
	[Address(RVA = "0x18D063C", Offset = "0x18D063C", VA = "0x18D063C")]
	public static bool GetPacksForDate(DateTime d, out DailyChallengeLevelDataContainer special, out DailyChallengeLevelDataContainer normal)
	{
		return default;
	}

	[Token(Token = "0x6001871")]
	[Address(RVA = "0x18D0BE0", Offset = "0x18D0BE0", VA = "0x18D0BE0")]
	public static DailyChallengeLevelDataContainer GetPack()
	{
		return null;
	}

	[Token(Token = "0x6001872")]
	[Address(RVA = "0x18CC330", Offset = "0x18CC330", VA = "0x18CC330")]
	public static DailyChallengeLevelDataContainer GetNormalPack()
	{
		return null;
	}

	[Token(Token = "0x6001873")]
	[Address(RVA = "0x18CC38C", Offset = "0x18CC38C", VA = "0x18CC38C")]
	public static DailyChallengeLevelDataContainer GetSpecialPack()
	{
		return null;
	}

	[Token(Token = "0x6001874")]
	[Address(RVA = "0x18D0D1C", Offset = "0x18D0D1C", VA = "0x18D0D1C")]
	public static bool HasSpecialBeenPlayedBefore()
	{
		return default;
	}

	[Token(Token = "0x6001875")]
	[Address(RVA = "0x18D0E44", Offset = "0x18D0E44", VA = "0x18D0E44")]
	public static bool HasSpecialBeenPlayedBefore(string specialId)
	{
		return default;
	}

	[Token(Token = "0x6001876")]
	[Address(RVA = "0x18D0C3C", Offset = "0x18D0C3C", VA = "0x18D0C3C")]
	public static DailyChallengeLevelDataContainer GetPack(DateTime day)
	{
		return null;
	}

	[Token(Token = "0x6001877")]
	[Address(RVA = "0x18D0A98", Offset = "0x18D0A98", VA = "0x18D0A98")]
	public static DailyChallengeLevelDataContainer GetNormalPack(DateTime day)
	{
		return null;
	}

	[Token(Token = "0x6001878")]
	[Address(RVA = "0x18D0FA0", Offset = "0x18D0FA0", VA = "0x18D0FA0")]
	public DailyChallengeLevelDataContainer GetSpecialEventByPrizeID(string s)
	{
		return null;
	}

	[Token(Token = "0x6001879")]
	[Address(RVA = "0x18D07EC", Offset = "0x18D07EC", VA = "0x18D07EC")]
	public static DailyChallengeLevelDataContainer GetSpecialPack(DateTime day)
	{
		return null;
	}

	[Token(Token = "0x600187A")]
	[Address(RVA = "0x18D10DC", Offset = "0x18D10DC", VA = "0x18D10DC")]
	public DailyChallenges()
	{
	}

	[Token(Token = "0x600187C")]
	[Address(RVA = "0x18D0928", Offset = "0x18D0928", VA = "0x18D0928")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x631A8", Offset = "0x631A8")]
	internal static bool _003CGetPacksForDate_003Eg__IsPlayed_007C11_0(DailyChallengeLevelDataContainer pack)
	{
		return default;
	}
}
