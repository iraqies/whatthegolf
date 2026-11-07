using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200076A")]
public class EffectsInOne : MonoBehaviour
{
	[Token(Token = "0x4002746")]
	[FieldOffset(Offset = "0x18")]
	public BallCollider ballCollider;

	[Token(Token = "0x4002747")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem collisionparticles;

	[Token(Token = "0x4002748")]
	[FieldOffset(Offset = "0x28")]
	public float amountOfParticles;

	[Token(Token = "0x4002749")]
	[FieldOffset(Offset = "0x30")]
	private Collider2D lastHit;

	[Token(Token = "0x400274A")]
	[FieldOffset(Offset = "0x38")]
	private float nextSameParticles;

	[Token(Token = "0x6002228")]
	[Address(RVA = "0x143AE98", Offset = "0x143AE98", VA = "0x143AE98")]
	public void FindBall()
	{
	}

	[Token(Token = "0x6002229")]
	[Address(RVA = "0x143B05C", Offset = "0x143B05C", VA = "0x143B05C")]
	private void BallCollider_OnCollisionEnter(Vector3 pos, Vector3 normal, float impactMagnitude, Collider2D other)
	{
	}

	[Token(Token = "0x600222A")]
	[Address(RVA = "0x143B20C", Offset = "0x143B20C", VA = "0x143B20C")]
	public EffectsInOne()
	{
	}
}
