using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006AE")]
public class ActualCarPhysicsHelper : MonoBehaviour
{
	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x18")]
	private GolfBallController controller;

	[Token(Token = "0x40022EC")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x40022ED")]
	[FieldOffset(Offset = "0x28")]
	private float startDrag;

	[Token(Token = "0x40022EE")]
	[FieldOffset(Offset = "0x2C")]
	private float nextDrag;

	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0x14054F0", Offset = "0x14054F0", VA = "0x14054F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0x14055F8", Offset = "0x14055F8", VA = "0x14055F8")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x1405648", Offset = "0x1405648", VA = "0x1405648")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x1405868", Offset = "0x1405868", VA = "0x1405868")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0x14058D8", Offset = "0x14058D8", VA = "0x14058D8")]
	public ActualCarPhysicsHelper()
	{
	}
}
