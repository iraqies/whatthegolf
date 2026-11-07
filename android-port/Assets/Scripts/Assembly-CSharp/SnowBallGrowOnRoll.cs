using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000040")]
public class SnowBallGrowOnRoll : MonoBehaviour
{
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem Particles;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x20")]
	public float GrowRate;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x24")]
	public float TrailSize;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x28")]
	public float MassGrowRate;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x30")]
	public Transform trans;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem.MainModule main;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x48")]
	private bool onGround;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x16BB234", Offset = "0x16BB234", VA = "0x16BB234")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x16BB33C", Offset = "0x16BB33C", VA = "0x16BB33C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x16BB4F4", Offset = "0x16BB4F4", VA = "0x16BB4F4")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x16BB5B4", Offset = "0x16BB5B4", VA = "0x16BB5B4")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x16BB670", Offset = "0x16BB670", VA = "0x16BB670")]
	public SnowBallGrowOnRoll()
	{
	}
}
