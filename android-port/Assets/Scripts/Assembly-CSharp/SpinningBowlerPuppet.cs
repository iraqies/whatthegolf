using System;
using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x2000216")]
public class SpinningBowlerPuppet : UserControlThirdPerson
{
	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController Controller;

	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x50")]
	public Transform LookObject;

	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x58")]
	public float RotateSpeed;

	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 runTarget;

	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x78")]
	private Action OnTargedReached;

	[Token(Token = "0x6000954")]
	[Address(RVA = "0x16D652C", Offset = "0x16D652C", VA = "0x16D652C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000955")]
	[Address(RVA = "0x16D6828", Offset = "0x16D6828", VA = "0x16D6828")]
	public void SetRunTarget(Vector3 target, Action OnTargedReached)
	{
	}

	[Token(Token = "0x6000956")]
	[Address(RVA = "0x16D6838", Offset = "0x16D6838", VA = "0x16D6838")]
	public SpinningBowlerPuppet()
	{
	}
}
