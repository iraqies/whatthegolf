using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000703")]
public class FlabbyGolfShooter : GolfBallShooterBase
{
	[Token(Token = "0x40024D6")]
	[FieldOffset(Offset = "0x60")]
	public Rigidbody PipeTemplate;

	[Token(Token = "0x40024D7")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody WinPipe;

	[Token(Token = "0x40024D8")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody StartPipe;

	[Token(Token = "0x40024D9")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 DistanceBetweenPipes;

	[Token(Token = "0x40024DA")]
	[FieldOffset(Offset = "0x80")]
	public Vector2 HeightRange;

	[Token(Token = "0x40024DB")]
	[FieldOffset(Offset = "0x88")]
	public int NumberOfPipes;

	[Token(Token = "0x40024DC")]
	[FieldOffset(Offset = "0x8C")]
	public float PipeMoveSpeed;

	[Token(Token = "0x40024DD")]
	[FieldOffset(Offset = "0x90")]
	public float FlyForce;

	[Token(Token = "0x40024DE")]
	[FieldOffset(Offset = "0x98")]
	private List<Rigidbody> currentPipes;

	[Token(Token = "0x40024DF")]
	[FieldOffset(Offset = "0xA0")]
	private bool hasShot;

	[Token(Token = "0x40024E0")]
	[FieldOffset(Offset = "0xA1")]
	private bool completed;

	[Token(Token = "0x600205D")]
	[Address(RVA = "0x146966C", Offset = "0x146966C", VA = "0x146966C")]
	private void Start()
	{
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0x1469A24", Offset = "0x1469A24", VA = "0x1469A24", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x1469A98", Offset = "0x1469A98", VA = "0x1469A98", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x1469D18", Offset = "0x1469D18", VA = "0x1469D18")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0x1469DCC", Offset = "0x1469DCC", VA = "0x1469DCC")]
	public FlabbyGolfShooter()
	{
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0x1469DEC", Offset = "0x1469DEC", VA = "0x1469DEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65920", Offset = "0x65920")]
	private void _003CStart_003Eb__11_0(Level.CompletedState s)
	{
	}
}
