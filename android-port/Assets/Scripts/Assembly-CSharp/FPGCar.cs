using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006EC")]
public class FPGCar : GolfBallShooterBase
{
	[Token(Token = "0x4002437")]
	[FieldOffset(Offset = "0x60")]
	public AudioSource CarStartingSource;

	[Token(Token = "0x4002438")]
	[FieldOffset(Offset = "0x68")]
	public AudioSource CarRunningSource;

	[Token(Token = "0x4002439")]
	[FieldOffset(Offset = "0x70")]
	public List<AudioClip> CarCrashClips;

	[Token(Token = "0x400243A")]
	[FieldOffset(Offset = "0x78")]
	public float RotationSpeed;

	[Token(Token = "0x400243B")]
	[FieldOffset(Offset = "0x7C")]
	public float DrivingSpeed;

	[Token(Token = "0x400243C")]
	[FieldOffset(Offset = "0x80")]
	public float WheelRotationSpeed;

	[Token(Token = "0x400243D")]
	[FieldOffset(Offset = "0x88")]
	public Transform Wheel;

	[Token(Token = "0x400243E")]
	[FieldOffset(Offset = "0x90")]
	public Transform Hand;

	[Token(Token = "0x400243F")]
	[FieldOffset(Offset = "0x98")]
	public Transform HandOnWheelPosition;

	[Token(Token = "0x4002440")]
	[FieldOffset(Offset = "0xA0")]
	public ConstantForce DrivingForce;

	[Token(Token = "0x4002441")]
	[FieldOffset(Offset = "0xA8")]
	private bool carStarted;

	[Token(Token = "0x4002442")]
	[FieldOffset(Offset = "0xAC")]
	private float strokeTimer;

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x1456524", Offset = "0x1456524", VA = "0x1456524")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x1456564", Offset = "0x1456564", VA = "0x1456564", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x1456688", Offset = "0x1456688", VA = "0x1456688", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x14566D0", Offset = "0x14566D0", VA = "0x14566D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x1456844", Offset = "0x1456844", VA = "0x1456844", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x14569D4", Offset = "0x14569D4", VA = "0x14569D4")]
	public FPGCar()
	{
	}
}
