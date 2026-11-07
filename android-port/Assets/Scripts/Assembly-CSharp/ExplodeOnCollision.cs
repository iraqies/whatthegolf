using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE5")]
public class ExplodeOnCollision : MonoBehaviour
{
	[Token(Token = "0x40041E9")]
	[FieldOffset(Offset = "0x18")]
	public ExplosionBarrel2D Explosion;

	[Token(Token = "0x40041EA")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem explosionParticlesPrefab;

	[Token(Token = "0x40041EB")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x40041EC")]
	[FieldOffset(Offset = "0x30")]
	public float explosionForce;

	[Token(Token = "0x6003908")]
	[Address(RVA = "0x14501A8", Offset = "0x14501A8", VA = "0x14501A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003909")]
	[Address(RVA = "0x1450204", Offset = "0x1450204", VA = "0x1450204")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600390A")]
	[Address(RVA = "0x145039C", Offset = "0x145039C", VA = "0x145039C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600390B")]
	[Address(RVA = "0x1450598", Offset = "0x1450598", VA = "0x1450598")]
	public ExplodeOnCollision()
	{
	}
}
