using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000761")]
public class BallShooterFake3D : GolfBallShooterBase
{
	[Token(Token = "0x4002728")]
	[FieldOffset(Offset = "0x60")]
	public float offsetDistance;

	[Token(Token = "0x4002729")]
	[FieldOffset(Offset = "0x64")]
	public bool didShoot;

	[Token(Token = "0x400272A")]
	[FieldOffset(Offset = "0x68")]
	public Action<Vector2> OnShootEvent;

	[Token(Token = "0x6002205")]
	[Address(RVA = "0x15192A4", Offset = "0x15192A4", VA = "0x15192A4", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002206")]
	[Address(RVA = "0x1519360", Offset = "0x1519360", VA = "0x1519360")]
	private void GolfBallControllerOverride_OnAimUpdate(Vector3 boost, bool arg2)
	{
	}

	[Token(Token = "0x6002207")]
	[Address(RVA = "0x15193AC", Offset = "0x15193AC", VA = "0x15193AC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002208")]
	[Address(RVA = "0x15193B0", Offset = "0x15193B0", VA = "0x15193B0")]
	public BallShooterFake3D()
	{
	}
}
