using System.Collections.Generic;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000132")]
public class GenericTimelineShooter : GolfBallShooterBase
{
	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Timeline timeline;

	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Clock> clocks;

	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float aimTimeScale;

	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float upSpeed;

	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float downSpeed;

	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float minShootVelocity;

	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public float fullShootVelocity;

	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve;

	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public float spin;

	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	protected bool lookInShotDirection;

	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x95")]
	public bool lookInAimDirection;

	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x98")]
	public float LookInAimDirectionSpeed;

	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	protected bool dontLookInAimDirectionWhenBlocked;

	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x9D")]
	[SerializeField]
	protected bool useLocalUp;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x9E")]
	[SerializeField]
	public bool zeroPitchIfNotGrouneded;

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x1484C04", Offset = "0x1484C04", VA = "0x1484C04", Slot = "4")]
	public override void OnActivate()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x1484C40", Offset = "0x1484C40", VA = "0x1484C40", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x1484DD8", Offset = "0x1484DD8", VA = "0x1484DD8", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x1484F8C", Offset = "0x1484F8C", VA = "0x1484F8C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x14854F8", Offset = "0x14854F8", VA = "0x14854F8", Slot = "14")]
	protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x1485718", Offset = "0x1485718", VA = "0x1485718")]
	public GenericTimelineShooter()
	{
	}
}
