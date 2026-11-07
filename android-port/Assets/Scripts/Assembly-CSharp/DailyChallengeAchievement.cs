using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000007")]
public class DailyChallengeAchievement : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000008")]
	[SerializeField]
	private struct WeekdayAcheivements
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		public DayOfWeek day;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		public UnlockAchievement achievement;
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D178", Offset = "0x3D178")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x10")]
		public DayOfWeek d;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1794304", Offset = "0x1794304", VA = "0x1794304")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x179430C", Offset = "0x179430C", VA = "0x179430C")]
		internal bool _003CUpdateDailyChallengeAchievements_003Eb__0(WeekdayAcheivements w)
		{
			return default;
		}
	}

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<WeekdayAcheivements> weekdayAcheivements;

	[Token(Token = "0x4000012")]
	private const string PlayerPrefLastDailyChallengeDate = "LAST_DAILY";

	[Token(Token = "0x4000013")]
	private const string PlayerPrefLastDailyChallengeDateCount = "LAST_DAILY_COUNT";

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x20")]
	public UnlockAchievement dailyFirst;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x28")]
	public UnlockAchievement daily9;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x30")]
	public UnlockAchievement daily18;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x0")]
	public static DailyChallengeAchievement Instance;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x18C8DB4", Offset = "0x18C8DB4", VA = "0x18C8DB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x18C8E0C", Offset = "0x18C8E0C", VA = "0x18C8E0C")]
	private static int DateToDay(DateTime date)
	{
		return default;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x18C8E54", Offset = "0x18C8E54", VA = "0x18C8E54")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D02C", Offset = "0x5D02C")]
	public void UpdateDailyChallengeAchievements(DailyChallengePackStarter menu)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x18C91BC", Offset = "0x18C91BC", VA = "0x18C91BC")]
	public static int GetCurrentDailyChallengeCount()
	{
		return default;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x18C92E4", Offset = "0x18C92E4", VA = "0x18C92E4")]
	public static bool WasLastDailyChallengeDateToday()
	{
		return default;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x18C8FF4", Offset = "0x18C8FF4", VA = "0x18C8FF4")]
	public static int IncrementPlayedCount()
	{
		return default;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x18C9684", Offset = "0x18C9684", VA = "0x18C9684")]
	public DailyChallengeAchievement()
	{
	}
}
