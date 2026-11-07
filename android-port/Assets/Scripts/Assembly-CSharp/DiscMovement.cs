using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AFD")]
public class DiscMovement : MonoBehaviour
{
	[Token(Token = "0x4003D2A")]
	[FieldOffset(Offset = "0x18")]
	public Transform Pivot;

	[Token(Token = "0x4003D2B")]
	[FieldOffset(Offset = "0x20")]
	public float ForceMod;

	[Token(Token = "0x4003D2C")]
	[FieldOffset(Offset = "0x24")]
	public float MoveSpeed;

	[Token(Token = "0x4003D2D")]
	[FieldOffset(Offset = "0x28")]
	public float DeadZoneSize;

	[Token(Token = "0x4003D2E")]
	[FieldOffset(Offset = "0x2C")]
	public float MaxRotate;

	[Token(Token = "0x4003D2F")]
	[FieldOffset(Offset = "0x30")]
	public Collider WinCollider;

	[Token(Token = "0x4003D30")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4003D31")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 currentDirection;

	[Token(Token = "0x4003D32")]
	[FieldOffset(Offset = "0x50")]
	private ParticleSystem crashParticles;

	[Token(Token = "0x600345D")]
	[Address(RVA = "0x18DD8B4", Offset = "0x18DD8B4", VA = "0x18DD8B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600345E")]
	[Address(RVA = "0x18DD934", Offset = "0x18DD934", VA = "0x18DD934")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x600345F")]
	[Address(RVA = "0x18DDA2C", Offset = "0x18DDA2C", VA = "0x18DDA2C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003460")]
	[Address(RVA = "0x18DDCD8", Offset = "0x18DDCD8", VA = "0x18DDCD8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003461")]
	[Address(RVA = "0x18DE140", Offset = "0x18DE140", VA = "0x18DE140")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003462")]
	[Address(RVA = "0x18DE178", Offset = "0x18DE178", VA = "0x18DE178")]
	public DiscMovement()
	{
	}
}
