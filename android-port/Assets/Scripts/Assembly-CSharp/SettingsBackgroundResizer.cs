using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000904")]
public class SettingsBackgroundResizer : MonoBehaviour
{
	[Token(Token = "0x4003119")]
	[FieldOffset(Offset = "0x18")]
	public float TotalPadding;

	[Token(Token = "0x400311A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI Label;

	[Token(Token = "0x400311B")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rectTransform;

	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x16936FC", Offset = "0x16936FC", VA = "0x16936FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x1693758", Offset = "0x1693758", VA = "0x1693758")]
	private void Update()
	{
	}

	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x1693838", Offset = "0x1693838", VA = "0x1693838")]
	public SettingsBackgroundResizer()
	{
	}
}
