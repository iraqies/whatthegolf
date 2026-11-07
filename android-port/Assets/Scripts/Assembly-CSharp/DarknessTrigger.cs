using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009A4")]
public class DarknessTrigger : MonoBehaviour
{
	[Token(Token = "0x400351D")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer[] DarknessRenderers;

	[Token(Token = "0x400351E")]
	[FieldOffset(Offset = "0x20")]
	public Color DarknessDark;

	[Token(Token = "0x400351F")]
	[FieldOffset(Offset = "0x30")]
	public Color DarknessLight;

	[Token(Token = "0x4003520")]
	[FieldOffset(Offset = "0x40")]
	private float fadeSpeed;

	[Token(Token = "0x4003521")]
	[FieldOffset(Offset = "0x44")]
	private float darkness;

	[Token(Token = "0x4003522")]
	[FieldOffset(Offset = "0x48")]
	private float targetDarkness;

	[Token(Token = "0x6002D53")]
	[Address(RVA = "0x18D4614", Offset = "0x18D4614", VA = "0x18D4614")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002D54")]
	[Address(RVA = "0x18D4728", Offset = "0x18D4728", VA = "0x18D4728")]
	private void ToggleDarkness(bool on)
	{
	}

	[Token(Token = "0x6002D55")]
	[Address(RVA = "0x18D4750", Offset = "0x18D4750", VA = "0x18D4750")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D56")]
	[Address(RVA = "0x18D48F0", Offset = "0x18D48F0", VA = "0x18D48F0")]
	private Color DarknessToColor(float darkness)
	{
		return default;
	}

	[Token(Token = "0x6002D57")]
	[Address(RVA = "0x18D4618", Offset = "0x18D4618", VA = "0x18D4618")]
	private void UpdateRenderers()
	{
	}

	[Token(Token = "0x6002D58")]
	[Address(RVA = "0x18D4874", Offset = "0x18D4874", VA = "0x18D4874")]
	private void EnableRenderers(bool enabled)
	{
	}

	[Token(Token = "0x6002D59")]
	[Address(RVA = "0x18D4988", Offset = "0x18D4988", VA = "0x18D4988")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x18D4A08", Offset = "0x18D4A08", VA = "0x18D4A08")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x18D4A84", Offset = "0x18D4A84", VA = "0x18D4A84")]
	public DarknessTrigger()
	{
	}
}
