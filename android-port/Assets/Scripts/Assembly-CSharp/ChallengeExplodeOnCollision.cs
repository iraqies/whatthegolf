using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000441")]
public class ChallengeExplodeOnCollision : MonoBehaviour
{
	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem explosionParticlesPrefab;

	[Token(Token = "0x400173D")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem _explosion;

	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0x30")]
	public float explosionForce;

	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x34")]
	public bool explodeFootballPlayers;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask checkLayer;

	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x3C")]
	public float explosionRadius;

	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x1892EA8", Offset = "0x1892EA8", VA = "0x1892EA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001400")]
	[Address(RVA = "0x1892FE8", Offset = "0x1892FE8", VA = "0x1892FE8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001401")]
	[Address(RVA = "0x18933F8", Offset = "0x18933F8", VA = "0x18933F8")]
	public ChallengeExplodeOnCollision()
	{
	}
}
