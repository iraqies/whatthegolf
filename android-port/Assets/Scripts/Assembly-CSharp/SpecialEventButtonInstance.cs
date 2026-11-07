using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000EAC")]
public class SpecialEventButtonInstance : MonoBehaviour
{
	[Token(Token = "0x4004F3A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimateRectTransform animator;

	[Token(Token = "0x4004F3B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject bigBanner;

	[Token(Token = "0x4004F3C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject smallBanner;

	[Token(Token = "0x4004F3D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4004F3E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProLocalized localizer;

	[Token(Token = "0x4004F3F")]
	[FieldOffset(Offset = "0x40")]
	public Graphic targetGraphics;

	[Token(Token = "0x4004F40")]
	[FieldOffset(Offset = "0x48")]
	private string title;

	[Token(Token = "0x600447D")]
	[Address(RVA = "0x16CC0F0", Offset = "0x16CC0F0", VA = "0x16CC0F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600447E")]
	[Address(RVA = "0x16CC204", Offset = "0x16CC204", VA = "0x16CC204")]
	internal void Init(string title)
	{
	}

	[Token(Token = "0x600447F")]
	[Address(RVA = "0x16CC2A0", Offset = "0x16CC2A0", VA = "0x16CC2A0")]
	private void ShowBanner(int length)
	{
	}

	[Token(Token = "0x6004480")]
	[Address(RVA = "0x16CC2F0", Offset = "0x16CC2F0", VA = "0x16CC2F0")]
	private void UpdateBanner(string language)
	{
	}

	[Token(Token = "0x6004481")]
	[Address(RVA = "0x16CC2F8", Offset = "0x16CC2F8", VA = "0x16CC2F8")]
	public SpecialEventButtonInstance()
	{
	}
}
