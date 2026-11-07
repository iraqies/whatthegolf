using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009B2")]
public class Explosion2D : MonoBehaviour
{
	[Token(Token = "0x4003549")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem smokeRingSystem;

	[Token(Token = "0x400354A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem aftersmokeSystem;

	[Token(Token = "0x400354B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem fireballsSystem;

	[Token(Token = "0x400354C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform explosionContainer;

	[Token(Token = "0x400354D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x6002D94")]
	[Address(RVA = "0x1450F2C", Offset = "0x1450F2C", VA = "0x1450F2C")]
	public void Explode(float magnitude)
	{
	}

	[Token(Token = "0x6002D95")]
	[Address(RVA = "0x1450FC0", Offset = "0x1450FC0", VA = "0x1450FC0")]
	public void FireRingParticles()
	{
	}

	[Token(Token = "0x6002D96")]
	[Address(RVA = "0x1451004", Offset = "0x1451004", VA = "0x1451004")]
	public void StartAftersmoke()
	{
	}

	[Token(Token = "0x6002D97")]
	[Address(RVA = "0x1451064", Offset = "0x1451064", VA = "0x1451064")]
	public Explosion2D()
	{
	}
}
