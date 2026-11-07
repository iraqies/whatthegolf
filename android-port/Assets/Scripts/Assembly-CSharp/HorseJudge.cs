using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000118")]
public class HorseJudge : MonoBehaviour
{
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x20")]
	public SetMaterialColorToPlayerColor LeftFlag;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x28")]
	public SetMaterialColorToPlayerColor RightFlag;

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x14D51C0", Offset = "0x14D51C0", VA = "0x14D51C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x14D5278", Offset = "0x14D5278", VA = "0x14D5278")]
	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo info)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x14D5424", Offset = "0x14D5424", VA = "0x14D5424")]
	public HorseJudge()
	{
	}
}
