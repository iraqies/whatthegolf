using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000055")]
public class DebugMenu : MonoBehaviour
{
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x18")]
	public List<AchievementData> AchievementDatas;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI debugDate;

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x18D4FF0", Offset = "0x18D4FF0", VA = "0x18D4FF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x18D506C", Offset = "0x18D506C", VA = "0x18D506C")]
	public void PlayFromLink()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x18D50D8", Offset = "0x18D50D8", VA = "0x18D50D8")]
	public void ResetAchievments()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x18D5134", Offset = "0x18D5134", VA = "0x18D5134")]
	public void UnlockAllAchievements()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x18D52BC", Offset = "0x18D52BC", VA = "0x18D52BC")]
	public void OnChangeDays(int arg0)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x18D5414", Offset = "0x18D5414", VA = "0x18D5414")]
	private void SetDateText()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x18D54F4", Offset = "0x18D54F4", VA = "0x18D54F4")]
	public void OnSetWeek(int arg0)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x18D564C", Offset = "0x18D564C", VA = "0x18D564C")]
	internal void OnDebugLeaderboards()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x18D56B4", Offset = "0x18D56B4", VA = "0x18D56B4")]
	public void TriggerNotification(WTGNotification notification)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x18D5818", Offset = "0x18D5818", VA = "0x18D5818")]
	internal void OnCheatUnlockNoSave(bool arg0)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x18D5884", Offset = "0x18D5884", VA = "0x18D5884")]
	public DebugMenu()
	{
	}
}
