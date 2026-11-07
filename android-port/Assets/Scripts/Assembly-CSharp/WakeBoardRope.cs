using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E3")]
public class WakeBoardRope : MonoBehaviour
{
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x18")]
	public float MaxLength;

	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxSpring;

	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Boat;

	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x28")]
	public SpringJoint Joint;

	[Token(Token = "0x600086F")]
	[Address(RVA = "0x174F9FC", Offset = "0x174F9FC", VA = "0x174F9FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0x174FAD4", Offset = "0x174FAD4", VA = "0x174FAD4")]
	public WakeBoardRope()
	{
	}
}
