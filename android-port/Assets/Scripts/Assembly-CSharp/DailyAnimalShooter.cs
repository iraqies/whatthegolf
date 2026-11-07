using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ED5")]
public class DailyAnimalShooter : GolfBallShooterBase
{
	[Token(Token = "0x400501D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private DailyPrize da;

	[Token(Token = "0x400501E")]
	[FieldOffset(Offset = "0x68")]
	public bool lookInAimDirection;

	[Token(Token = "0x6004530")]
	[Address(RVA = "0x18C8A84", Offset = "0x18C8A84", VA = "0x18C8A84", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6004531")]
	[Address(RVA = "0x18C8BB8", Offset = "0x18C8BB8", VA = "0x18C8BB8", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6004532")]
	[Address(RVA = "0x18C8D90", Offset = "0x18C8D90", VA = "0x18C8D90", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6004533")]
	[Address(RVA = "0x18C8DAC", Offset = "0x18C8DAC", VA = "0x18C8DAC")]
	public DailyAnimalShooter()
	{
	}
}
