using Core;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

[Token(Token = "0x20001F9")]
public class GiraffeSculptorController : GolfBallShooterBase
{
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x60")]
	public Transform PointContainer;

	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x68")]
	public Transform Mover;

	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x70")]
	public Transform ToungeRoot;

	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x78")]
	public CCDIK motor;

	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x80")]
	private int currentPointIndex;

	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 refVel;

	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 toungeScale;

	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x9C")]
	private float targetWeight;

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x148CF48", Offset = "0x148CF48", VA = "0x148CF48")]
	private void Start()
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x148D0BC", Offset = "0x148D0BC", VA = "0x148D0BC")]
	private void OnComplete(Level.CompletedState obj)
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x148D0EC", Offset = "0x148D0EC", VA = "0x148D0EC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x148D180", Offset = "0x148D180", VA = "0x148D180")]
	private void Update()
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x148D2D4", Offset = "0x148D2D4", VA = "0x148D2D4")]
	public GiraffeSculptorController()
	{
	}
}
