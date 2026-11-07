using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CF8")]
public class AvatarOnTop : MonoBehaviour
{
	[Token(Token = "0x4004676")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4004677")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody rigidbodyOverride;

	[Token(Token = "0x4004678")]
	[FieldOffset(Offset = "0x28")]
	public float animatorOffset;

	[Token(Token = "0x4004679")]
	[FieldOffset(Offset = "0x2C")]
	public float animationSpeedMod;

	[Token(Token = "0x400467A")]
	[FieldOffset(Offset = "0x30")]
	public bool setAnimationSpeed;

	[Token(Token = "0x400467B")]
	[FieldOffset(Offset = "0x38")]
	public SphereCollider ballCollider;

	[Token(Token = "0x6003D4D")]
	[Address(RVA = "0x1515CEC", Offset = "0x1515CEC", VA = "0x1515CEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D4E")]
	[Address(RVA = "0x1515CF0", Offset = "0x1515CF0", VA = "0x1515CF0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003D4F")]
	[Address(RVA = "0x1515EA4", Offset = "0x1515EA4", VA = "0x1515EA4")]
	public AvatarOnTop()
	{
	}
}
