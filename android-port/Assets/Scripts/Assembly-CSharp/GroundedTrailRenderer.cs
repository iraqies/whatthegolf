using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000716")]
public class GroundedTrailRenderer : MonoBehaviour
{
	[Token(Token = "0x4002559")]
	[FieldOffset(Offset = "0x18")]
	public float GroundDistCheck;

	[Token(Token = "0x400255A")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask GroundMask;

	[Token(Token = "0x400255B")]
	[FieldOffset(Offset = "0x20")]
	public TrailRenderer Trail;

	[Token(Token = "0x400255C")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem particles;

	[Token(Token = "0x400255D")]
	[FieldOffset(Offset = "0x30")]
	public ConstantForce2D LeftForce;

	[Token(Token = "0x400255E")]
	[FieldOffset(Offset = "0x38")]
	public ConstantForce2D RightForce;

	[Token(Token = "0x400255F")]
	[FieldOffset(Offset = "0x40")]
	public bool inAir;

	[Token(Token = "0x4002560")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem.EmissionModule emission;

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x14BDB30", Offset = "0x14BDB30", VA = "0x14BDB30")]
	private void Start()
	{
	}

	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x14BDB64", Offset = "0x14BDB64", VA = "0x14BDB64")]
	private void Update()
	{
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x14BDDFC", Offset = "0x14BDDFC", VA = "0x14BDDFC")]
	public GroundedTrailRenderer()
	{
	}
}
