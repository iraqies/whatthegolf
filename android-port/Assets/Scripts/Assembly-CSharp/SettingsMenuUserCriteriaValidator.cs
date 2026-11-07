using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200092A")]
public class SettingsMenuUserCriteriaValidator : SettingsMenuCommon
{
	[Token(Token = "0x4003200")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI _text;

	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x169CD74", Offset = "0x169CD74", VA = "0x169CD74")]
	public void Init(SettingsMenu settings, List<UserCriteria> criteria, bool active, string title)
	{
	}

	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x169CDE8", Offset = "0x169CDE8", VA = "0x169CDE8")]
	private void SetUpCriteria(List<UserCriteria> criteria, string title)
	{
	}

	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x169D168", Offset = "0x169D168", VA = "0x169D168")]
	public SettingsMenuUserCriteriaValidator()
	{
	}
}
