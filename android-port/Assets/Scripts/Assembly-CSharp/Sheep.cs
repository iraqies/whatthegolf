using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CA")]
public class Sheep : MonoBehaviour
{
	[Token(Token = "0x400238E")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody2D rigid;

	[Token(Token = "0x400238F")]
	[FieldOffset(Offset = "0x20")]
	public BlockShotIfNotGrounded grounding;

	[Token(Token = "0x4002390")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 force;

	[Token(Token = "0x4002391")]
	[FieldOffset(Offset = "0x30")]
	public float cooldownDuration;

	[Token(Token = "0x4002392")]
	[FieldOffset(Offset = "0x34")]
	public float lastImpulseTime;

	[Token(Token = "0x6001F5A")]
	[Address(RVA = "0x169EC84", Offset = "0x169EC84", VA = "0x169EC84")]
	private void Start()
	{
	}

	[Token(Token = "0x6001F5B")]
	[Address(RVA = "0x169ECE4", Offset = "0x169ECE4", VA = "0x169ECE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x169ED74", Offset = "0x169ED74", VA = "0x169ED74")]
	public Sheep()
	{
	}
}
