using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E74")]
public class ChangeShootForce : MonoBehaviour
{
	[Token(Token = "0x4004E35")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallShooterExperimental shooter;

	[Token(Token = "0x4004E36")]
	[FieldOffset(Offset = "0x20")]
	public float minShoot;

	[Token(Token = "0x4004E37")]
	[FieldOffset(Offset = "0x24")]
	public float maxShoot;

	[Token(Token = "0x600438F")]
	[Address(RVA = "0x18985C4", Offset = "0x18985C4", VA = "0x18985C4")]
	public void ChangeForce()
	{
	}

	[Token(Token = "0x6004390")]
	[Address(RVA = "0x18985E4", Offset = "0x18985E4", VA = "0x18985E4")]
	public ChangeShootForce()
	{
	}
}
