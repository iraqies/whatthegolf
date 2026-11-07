using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

[Token(Token = "0x20001FA")]
public class GiraffeSprayPainter : MonoBehaviour
{
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x18")]
	public GiraffePainterController Controller;

	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x20")]
	public CCDIK BodyIK;

	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x28")]
	public float WeightChangeSpeed;

	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x30")]
	public Collider PlayerCollider;

	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem SpraySystem;

	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystemDistanceEmissionCurve EmissionCurve;

	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem.MainModule main;

	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x50")]
	private IKSolverCCD solver;

	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x58")]
	private float weightTarget;

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x148D310", Offset = "0x148D310", VA = "0x148D310")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x148D418", Offset = "0x148D418", VA = "0x148D418")]
	private void ChangeState(GiraffePainterController.PaintStateEnum newState)
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x148D4C4", Offset = "0x148D4C4", VA = "0x148D4C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x148D5F4", Offset = "0x148D5F4", VA = "0x148D5F4")]
	public GiraffeSprayPainter()
	{
	}
}
