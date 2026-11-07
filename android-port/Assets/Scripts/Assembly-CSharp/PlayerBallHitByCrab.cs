using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000107")]
public class PlayerBallHitByCrab : MonoBehaviour
{
	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x18")]
	public BeachBallWithAvatarController Owner;

	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x20")]
	public FinalLevel FinalLevel;

	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem HitParticles;

	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x30")]
	public CrabsController CrabController;

	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x38")]
	public Animator playerAnimator;

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x15F6F40", Offset = "0x15F6F40", VA = "0x15F6F40")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x15F70C0", Offset = "0x15F70C0", VA = "0x15F70C0")]
	public PlayerBallHitByCrab()
	{
	}
}
