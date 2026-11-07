using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DD2")]
public class RotateWithControllerAim : MonoBehaviour
{
	[Token(Token = "0x4004B53")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController golfBallController;

	[Token(Token = "0x4004B54")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 aimVector;

	[Token(Token = "0x4004B55")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion newRotation;

	[Token(Token = "0x600411F")]
	[Address(RVA = "0x166025C", Offset = "0x166025C", VA = "0x166025C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004120")]
	[Address(RVA = "0x16603F0", Offset = "0x16603F0", VA = "0x16603F0")]
	public RotateWithControllerAim()
	{
	}
}
