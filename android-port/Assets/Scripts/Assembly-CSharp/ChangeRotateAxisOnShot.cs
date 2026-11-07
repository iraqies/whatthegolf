using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BCD")]
public class ChangeRotateAxisOnShot : MonoBehaviour
{
	[Token(Token = "0x40041B0")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40041B1")]
	[FieldOffset(Offset = "0x20")]
	public RotateAxis rotateAxis;

	[Token(Token = "0x40041B2")]
	[FieldOffset(Offset = "0x28")]
	public RotateAxis2D rotateAxis2D;

	[Token(Token = "0x40041B3")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController controller;

	[Token(Token = "0x60038C9")]
	[Address(RVA = "0x1898134", Offset = "0x1898134", VA = "0x1898134")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038CA")]
	[Address(RVA = "0x18982C4", Offset = "0x18982C4", VA = "0x18982C4")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x60038CB")]
	[Address(RVA = "0x18983CC", Offset = "0x18983CC", VA = "0x18983CC")]
	public ChangeRotateAxisOnShot()
	{
	}
}
