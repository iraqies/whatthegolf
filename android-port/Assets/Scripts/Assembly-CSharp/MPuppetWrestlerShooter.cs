using Core;
using Il2CppDummyDll;
using MPuppet;
using UnityEngine;

[Token(Token = "0x200027F")]
public class MPuppetWrestlerShooter : GolfBallShooterBase
{
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x60")]
	public MPuppetController puppet;

	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x68")]
	public MPuppetGrabBehaviour grab;

	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x1551F84", Offset = "0x1551F84", VA = "0x1551F84", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x1552094", Offset = "0x1552094", VA = "0x1552094", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x15520C4", Offset = "0x15520C4", VA = "0x15520C4", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x155214C", Offset = "0x155214C", VA = "0x155214C", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x1552190", Offset = "0x1552190", VA = "0x1552190", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x1552228", Offset = "0x1552228", VA = "0x1552228")]
	public MPuppetWrestlerShooter()
	{
	}
}
