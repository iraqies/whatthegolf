using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BFD")]
public class HorseAutoRun2D : MonoBehaviour
{
	[Token(Token = "0x4004264")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody2D m_RigidbodyRoot;

	[Token(Token = "0x4004265")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody2D[] m_ApplyToRigidbodies;

	[Token(Token = "0x4004266")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform m_GroundCheckPosition;

	[Token(Token = "0x4004267")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_JumpCooldown;

	[Token(Token = "0x4004268")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_JumpForce;

	[Token(Token = "0x4004269")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float forwardVelocity;

	[Token(Token = "0x400426A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float steadyForwardVelocity;

	[Token(Token = "0x400426B")]
	[FieldOffset(Offset = "0x40")]
	private float m_lastJumpTime;

	[Token(Token = "0x400426C")]
	[FieldOffset(Offset = "0x44")]
	private bool isGrounded;

	[Token(Token = "0x6003988")]
	[Address(RVA = "0x14D4BB4", Offset = "0x14D4BB4", VA = "0x14D4BB4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003989")]
	[Address(RVA = "0x14D4E50", Offset = "0x14D4E50", VA = "0x14D4E50")]
	public HorseAutoRun2D()
	{
	}
}
