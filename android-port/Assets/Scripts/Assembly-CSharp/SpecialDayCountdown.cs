using Hub;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x20008B8")]
public class SpecialDayCountdown : MonoBehaviour
{
	[Token(Token = "0x4002FD8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProLocalized localization;

	[Token(Token = "0x4002FD9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SpecialDayCalendar specialDayCalendar;

	[Token(Token = "0x4002FDA")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text _text;

	[Token(Token = "0x6002837")]
	[Address(RVA = "0x16C9C14", Offset = "0x16C9C14", VA = "0x16C9C14")]
	private void Start()
	{
	}

	[Token(Token = "0x6002838")]
	[Address(RVA = "0x16C9C70", Offset = "0x16C9C70", VA = "0x16C9C70")]
	public void Tick(SpecialDayStage newStage)
	{
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x16CA308", Offset = "0x16CA308", VA = "0x16CA308")]
	public SpecialDayCountdown()
	{
	}
}
