using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BB")]
public abstract class BaseRTPCSetter : MonoBehaviour
{
	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x18")]
	public float Value;

	[Token(Token = "0x4001498")]
	[FieldOffset(Offset = "0x1C")]
	public int transitionTime;

	[Token(Token = "0x4001499")]
	[FieldOffset(Offset = "0x20")]
	public bool useLevelMusicRTPC;

	[Token(Token = "0x400149A")]
	[FieldOffset(Offset = "0x21")]
	public bool canOnlyGoUp;

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x1608248", Offset = "0x1608248", VA = "0x1608248")]
	protected void SetRTPC()
	{
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x16082D4", Offset = "0x16082D4", VA = "0x16082D4")]
	protected BaseRTPCSetter()
	{
	}
}
