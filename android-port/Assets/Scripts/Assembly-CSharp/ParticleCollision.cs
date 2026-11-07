using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1C")]
public class ParticleCollision : MonoBehaviour
{
	[Token(Token = "0x4003E1E")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask Mask;

	[Token(Token = "0x4003E1F")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ExplosionParticles;

	[Token(Token = "0x4003E20")]
	[FieldOffset(Offset = "0x28")]
	public float CollisionThreshold;

	[Token(Token = "0x4003E21")]
	[FieldOffset(Offset = "0x2C")]
	public int ParticlesToEmit;

	[Token(Token = "0x4003E22")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 Offset;

	[Token(Token = "0x4003E23")]
	[FieldOffset(Offset = "0x3C")]
	public bool AddScreenShake;

	[Token(Token = "0x6003506")]
	[Address(RVA = "0x15DBA40", Offset = "0x15DBA40", VA = "0x15DBA40")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003507")]
	[Address(RVA = "0x15DBC00", Offset = "0x15DBC00", VA = "0x15DBC00")]
	public ParticleCollision()
	{
	}
}
