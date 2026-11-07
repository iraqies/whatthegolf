using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BC")]
public abstract class BaseStateSetter : MonoBehaviour
{
	[Token(Token = "0x400149B")]
	[FieldOffset(Offset = "0x18")]
	public uint state;

	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0x1C")]
	protected bool isTriggered;

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x16092E0", Offset = "0x16092E0", VA = "0x16092E0")]
	protected void SetState()
	{
	}

	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x1609398", Offset = "0x1609398", VA = "0x1609398")]
	protected BaseStateSetter()
	{
	}
}
