using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000722")]
public class ObjectDraggerShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x400259D")]
	[FieldOffset(Offset = "0x48")]
	public float DragForce;

	[Token(Token = "0x400259E")]
	[FieldOffset(Offset = "0x4C")]
	public ForceMode2D DragMode;

	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x1591D70", Offset = "0x1591D70", VA = "0x1591D70", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x1591DA0", Offset = "0x1591DA0", VA = "0x1591DA0")]
	public ObjectDraggerShooter()
	{
	}
}
