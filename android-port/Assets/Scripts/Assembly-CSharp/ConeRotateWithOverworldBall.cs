using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D69")]
public class ConeRotateWithOverworldBall : MonoBehaviour
{
	[Token(Token = "0x4004901")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController golfBallController;

	[Token(Token = "0x4004902")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 aimVector;

	[Token(Token = "0x4004903")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion newRotation;

	[Token(Token = "0x6003F1C")]
	[Address(RVA = "0x18AAE94", Offset = "0x18AAE94", VA = "0x18AAE94")]
	private void Update()
	{
	}

	[Token(Token = "0x6003F1D")]
	[Address(RVA = "0x18AB02C", Offset = "0x18AB02C", VA = "0x18AB02C")]
	public ConeRotateWithOverworldBall()
	{
	}
}
