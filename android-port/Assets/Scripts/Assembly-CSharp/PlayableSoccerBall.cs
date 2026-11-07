using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000855")]
public class PlayableSoccerBall : MonoBehaviour
{
	[Token(Token = "0x4002D28")]
	[FieldOffset(Offset = "0x18")]
	public float pickupCooldown;

	[Token(Token = "0x4002D29")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x4002D2A")]
	[FieldOffset(Offset = "0x28")]
	public Collider BallCollider;

	[Token(Token = "0x4002D2B")]
	[FieldOffset(Offset = "0x30")]
	private PlayerSoccerInfo isHeldBy;

	[Token(Token = "0x4002D2C")]
	[FieldOffset(Offset = "0x38")]
	private PlayerSoccerInfo lastHeldBy;

	[Token(Token = "0x4002D2D")]
	[FieldOffset(Offset = "0x40")]
	private float previousPlayerNextPickupTime;

	[Token(Token = "0x600266B")]
	[Address(RVA = "0x15F6878", Offset = "0x15F6878", VA = "0x15F6878")]
	public PlayerSoccerInfo GetIsHeldBy()
	{
		return null;
	}

	[Token(Token = "0x600266C")]
	[Address(RVA = "0x15F6880", Offset = "0x15F6880", VA = "0x15F6880")]
	private void Awake()
	{
	}

	[Token(Token = "0x600266D")]
	[Address(RVA = "0x15F68DC", Offset = "0x15F68DC", VA = "0x15F68DC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600266E")]
	[Address(RVA = "0x15F6D9C", Offset = "0x15F6D9C", VA = "0x15F6D9C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600266F")]
	[Address(RVA = "0x15F6AE0", Offset = "0x15F6AE0", VA = "0x15F6AE0")]
	private void SetNewOwner(PlayerSoccerInfo newOwner)
	{
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0x15F6C38", Offset = "0x15F6C38", VA = "0x15F6C38")]
	private void Disengage()
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0x15F6ED4", Offset = "0x15F6ED4", VA = "0x15F6ED4")]
	public void BallShot(Vector3 vel)
	{
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0x15F6F2C", Offset = "0x15F6F2C", VA = "0x15F6F2C")]
	public PlayableSoccerBall()
	{
	}
}
