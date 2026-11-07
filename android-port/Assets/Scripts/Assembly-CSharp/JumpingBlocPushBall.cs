using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF7")]
public class JumpingBlocPushBall : MonoBehaviour
{
	[Token(Token = "0x4004C0A")]
	[FieldOffset(Offset = "0x18")]
	private bool applyForce;

	[Token(Token = "0x4004C0B")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody ball_rb;

	[Token(Token = "0x4004C0C")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 savedBallVelocity;

	[Token(Token = "0x60041C4")]
	[Address(RVA = "0x14F9084", Offset = "0x14F9084", VA = "0x14F9084")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60041C5")]
	[Address(RVA = "0x14F9170", Offset = "0x14F9170", VA = "0x14F9170")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60041C6")]
	[Address(RVA = "0x14F921C", Offset = "0x14F921C", VA = "0x14F921C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60041C7")]
	[Address(RVA = "0x14F92CC", Offset = "0x14F92CC", VA = "0x14F92CC")]
	public JumpingBlocPushBall()
	{
	}
}
