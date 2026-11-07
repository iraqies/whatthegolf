using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA7")]
public class SetAnimatorFloat : MonoBehaviour
{
	[Token(Token = "0x4004F29")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4004F2A")]
	[FieldOffset(Offset = "0x20")]
	public string floatName;

	[Token(Token = "0x4004F2B")]
	[FieldOffset(Offset = "0x28")]
	public float amountToSet;

	[Token(Token = "0x600446D")]
	[Address(RVA = "0x168B978", Offset = "0x168B978", VA = "0x168B978")]
	public void SetFloat()
	{
	}

	[Token(Token = "0x600446E")]
	[Address(RVA = "0x168B9A0", Offset = "0x168B9A0", VA = "0x168B9A0")]
	public SetAnimatorFloat()
	{
	}
}
