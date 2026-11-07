using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BFC")]
public class HorseAutoJump2D : MonoBehaviour
{
	[Token(Token = "0x4004256")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody2D m_RigidbodyRoot;

	[Token(Token = "0x4004257")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody2D[] m_ApplyToRigidbodies;

	[Token(Token = "0x4004258")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform m_GroundCheckPosition;

	[Token(Token = "0x4004259")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_JumpCooldownMin;

	[Token(Token = "0x400425A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_JumpCooldownMax;

	[Token(Token = "0x400425B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_DirectionChangeCooldown;

	[Token(Token = "0x400425C")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float m_JumpForce;

	[Token(Token = "0x400425D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float forwardVelocity;

	[Token(Token = "0x400425E")]
	[FieldOffset(Offset = "0x44")]
	private float m_JumpCooldown;

	[Token(Token = "0x400425F")]
	[FieldOffset(Offset = "0x48")]
	private float m_lastJumpTime;

	[Token(Token = "0x4004260")]
	[FieldOffset(Offset = "0x4C")]
	private float m_lastDirectionChangeTime;

	[Token(Token = "0x4004261")]
	[FieldOffset(Offset = "0x50")]
	private int m_xDirection;

	[Token(Token = "0x4004262")]
	[FieldOffset(Offset = "0x54")]
	private int m_lastDirection;

	[Token(Token = "0x4004263")]
	[FieldOffset(Offset = "0x58")]
	private bool isGrounded;

	[Token(Token = "0x6003986")]
	[Address(RVA = "0x14D48E8", Offset = "0x14D48E8", VA = "0x14D48E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003987")]
	[Address(RVA = "0x14D4B9C", Offset = "0x14D4B9C", VA = "0x14D4B9C")]
	public HorseAutoJump2D()
	{
	}
}
