using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3C")]
[Attribute(Name = "RequireComponent", RVA = "0x44030", Offset = "0x44030")]
public class SetIKTarget : MonoBehaviour
{
	[Token(Token = "0x400434D")]
	[FieldOffset(Offset = "0x18")]
	public AvatarIKGoal IKGoal;

	[Token(Token = "0x400434E")]
	[FieldOffset(Offset = "0x20")]
	public Transform Target;

	[Token(Token = "0x400434F")]
	[FieldOffset(Offset = "0x28")]
	private Animator animator;

	[Token(Token = "0x6003A57")]
	[Address(RVA = "0x168CF34", Offset = "0x168CF34", VA = "0x168CF34")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A58")]
	[Address(RVA = "0x168CF90", Offset = "0x168CF90", VA = "0x168CF90")]
	private void OnAnimatorIK(int layer)
	{
	}

	[Token(Token = "0x6003A59")]
	[Address(RVA = "0x168D0D0", Offset = "0x168D0D0", VA = "0x168D0D0")]
	public SetIKTarget()
	{
	}
}
