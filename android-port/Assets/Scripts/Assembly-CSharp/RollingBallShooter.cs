using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA1")]
public class RollingBallShooter : GolfBallShooterBase
{
	[Token(Token = "0x4004F0E")]
	[FieldOffset(Offset = "0x60")]
	public float RollSpeed;

	[Token(Token = "0x4004F0F")]
	[FieldOffset(Offset = "0x64")]
	public float ForceSpeed;

	[Token(Token = "0x4004F10")]
	[FieldOffset(Offset = "0x68")]
	public bool AddForcesInFixedUpdate;

	[Token(Token = "0x4004F11")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 currentBoost;

	[Token(Token = "0x6004454")]
	[Address(RVA = "0x165C6EC", Offset = "0x165C6EC", VA = "0x165C6EC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6004455")]
	[Address(RVA = "0x165C7AC", Offset = "0x165C7AC", VA = "0x165C7AC", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6004456")]
	[Address(RVA = "0x165C878", Offset = "0x165C878", VA = "0x165C878", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6004457")]
	[Address(RVA = "0x165C8A4", Offset = "0x165C8A4", VA = "0x165C8A4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6004458")]
	[Address(RVA = "0x165C8D0", Offset = "0x165C8D0", VA = "0x165C8D0")]
	public RollingBallShooter()
	{
	}
}
