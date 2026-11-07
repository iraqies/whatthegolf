using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000CEB")]
[Attribute(Name = "RequireComponent", RVA = "0x44528", Offset = "0x44528")]
public class ToggleOnPause : MonoBehaviour
{
	[Token(Token = "0x4004639")]
	[FieldOffset(Offset = "0x18")]
	private Image _crosshair;

	[Token(Token = "0x6003D19")]
	[Address(RVA = "0x171C3BC", Offset = "0x171C3BC", VA = "0x171C3BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D1A")]
	[Address(RVA = "0x171C484", Offset = "0x171C484", VA = "0x171C484")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003D1B")]
	[Address(RVA = "0x171C504", Offset = "0x171C504", VA = "0x171C504")]
	private void ToggleCross(bool state)
	{
	}

	[Token(Token = "0x6003D1C")]
	[Address(RVA = "0x171C524", Offset = "0x171C524", VA = "0x171C524")]
	public ToggleOnPause()
	{
	}
}
