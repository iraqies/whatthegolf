using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DF")]
public class GolfVehicleController : GolfBallShooterBase
{
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x60")]
	public Vehicle Vehicle;

	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x68")]
	public float SteerThreshold;

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x14A4994", Offset = "0x14A4994", VA = "0x14A4994", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x14A4AA4", Offset = "0x14A4AA4", VA = "0x14A4AA4")]
	public GolfVehicleController()
	{
	}
}
