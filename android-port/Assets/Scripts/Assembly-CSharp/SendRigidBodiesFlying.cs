using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F26")]
public class SendRigidBodiesFlying : MonoBehaviour
{
	[Token(Token = "0x40051B4")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> rbListToPush;

	[Token(Token = "0x40051B5")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 force;

	[Token(Token = "0x40051B6")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 torque;

	[Token(Token = "0x40051B7")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 randomAmplitude;

	[Token(Token = "0x40051B8")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 randomTorque;

	[Token(Token = "0x40051B9")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 randomVector;

	[Token(Token = "0x60046CD")]
	[Address(RVA = "0x16894E4", Offset = "0x16894E4", VA = "0x16894E4")]
	public void Jump()
	{
	}

	[Token(Token = "0x60046CE")]
	[Address(RVA = "0x1689668", Offset = "0x1689668", VA = "0x1689668")]
	public SendRigidBodiesFlying()
	{
	}
}
