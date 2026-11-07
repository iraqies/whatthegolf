using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045D")]
public class BowlerAutoFailBehaviour : AutoFailBase
{
	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0x2C")]
	public float velocityThreshold;

	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0x30")]
	public BowlingShooter[] bowlingShooters;

	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x38")]
	public bool CheckDistance;

	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0x40")]
	public Transform[] DistanceTargets;

	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0x48")]
	public float MinDistance;

	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x50")]
	private List<Rigidbody> activeBalls;

	[Token(Token = "0x600146B")]
	[Address(RVA = "0x1702CD8", Offset = "0x1702CD8", VA = "0x1702CD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600146C")]
	[Address(RVA = "0x1702EAC", Offset = "0x1702EAC", VA = "0x1702EAC")]
	private void OnNewBall(Rigidbody obj)
	{
	}

	[Token(Token = "0x600146D")]
	[Address(RVA = "0x1702F68", Offset = "0x1702F68", VA = "0x1702F68")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600146E")]
	[Address(RVA = "0x1702F6C", Offset = "0x1702F6C", VA = "0x1702F6C")]
	public BowlerAutoFailBehaviour()
	{
	}
}
