using System;
using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20001C5")]
public class DropPropOnShoot : MonoBehaviour
{
	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x18")]
	public PropMuscle MuscleWithProp;

	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController Controller;

	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x28")]
	public float ForceMod;

	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x2C")]
	public float UpwardsForce;

	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x30")]
	public bool UseAimVector;

	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x31")]
	public bool UseObjectVelocity;

	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x34")]
	public float MinThrowForce;

	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x38")]
	public bool UseAimCurve;

	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 AimCurveMinDirection;

	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 AimCurveMaxDirection;

	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve AimCurve;

	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x60")]
	public float AngleThreshold;

	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x68")]
	public Action<Vector3> OnPropDropped;

	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 lastObjectVelocity;

	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 lastAimVector;

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x14369F4", Offset = "0x14369F4", VA = "0x14369F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x1436B2C", Offset = "0x1436B2C", VA = "0x1436B2C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x1436BE0", Offset = "0x1436BE0", VA = "0x1436BE0")]
	private void ControllerOnOnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x1436C54", Offset = "0x1436C54", VA = "0x1436C54")]
	private void OnDropProp(PuppetMasterProp prop)
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x1436FAC", Offset = "0x1436FAC", VA = "0x1436FAC")]
	public DropPropOnShoot()
	{
	}
}
