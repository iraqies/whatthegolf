using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000859")]
public class SonicBounce : MonoBehaviour
{
	[Token(Token = "0x4002D56")]
	[FieldOffset(Offset = "0x18")]
	private Text countTxt;

	[Token(Token = "0x4002D57")]
	[FieldOffset(Offset = "0x20")]
	private int startCount;

	[Token(Token = "0x4002D58")]
	[FieldOffset(Offset = "0x24")]
	public int bounceCount;

	[Token(Token = "0x4002D59")]
	[FieldOffset(Offset = "0x28")]
	private Renderer rend;

	[Token(Token = "0x4002D5A")]
	[FieldOffset(Offset = "0x30")]
	public Color noBounce;

	[Token(Token = "0x4002D5B")]
	[FieldOffset(Offset = "0x40")]
	public Color bounce;

	[Token(Token = "0x4002D5C")]
	[FieldOffset(Offset = "0x50")]
	public Color hit;

	[Token(Token = "0x4002D5D")]
	[FieldOffset(Offset = "0x60")]
	private float cooldown;

	[Token(Token = "0x4002D5E")]
	[FieldOffset(Offset = "0x64")]
	private float requiredCool;

	[Token(Token = "0x6002683")]
	[Address(RVA = "0x16BFE4C", Offset = "0x16BFE4C", VA = "0x16BFE4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002684")]
	[Address(RVA = "0x16BFF04", Offset = "0x16BFF04", VA = "0x16BFF04")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0x16BFFCC", Offset = "0x16BFFCC", VA = "0x16BFFCC")]
	private void Update()
	{
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0x16C0198", Offset = "0x16C0198", VA = "0x16C0198")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002687")]
	[Address(RVA = "0x16C01A4", Offset = "0x16C01A4", VA = "0x16C01A4")]
	public SonicBounce()
	{
	}
}
