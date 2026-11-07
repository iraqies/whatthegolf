using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005E4")]
public class LevelDotsUI : MonoBehaviour
{
	[Token(Token = "0x4001E02")]
	[FieldOffset(Offset = "0x18")]
	public int currentDotIndex;

	[Token(Token = "0x4001E03")]
	[FieldOffset(Offset = "0x1C")]
	public Color inactiveColor;

	[Token(Token = "0x4001E04")]
	[FieldOffset(Offset = "0x2C")]
	public Color activeColor;

	[Token(Token = "0x4001E05")]
	[FieldOffset(Offset = "0x3C")]
	public float blinkFrequency;

	[Token(Token = "0x4001E06")]
	[FieldOffset(Offset = "0x40")]
	public float width;

	[Token(Token = "0x4001E07")]
	[FieldOffset(Offset = "0x48")]
	public LevelDot levelDotTemplate;

	[Token(Token = "0x4001E08")]
	[FieldOffset(Offset = "0x50")]
	private LevelDot[] dots;

	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x152CF0C", Offset = "0x152CF0C", VA = "0x152CF0C")]
	public void Initialize(int dotCount)
	{
	}

	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x152D160", Offset = "0x152D160", VA = "0x152D160")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x152D2B0", Offset = "0x152D2B0", VA = "0x152D2B0")]
	public LevelDotsUI()
	{
	}
}
