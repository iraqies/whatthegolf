using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x2000215")]
public class SpinningBowlerBall : UserControlThirdPerson
{
	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController Controller;

	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x50")]
	public Transform LookObject;

	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x58")]
	public float RotateSpeed;

	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 moveDir;

	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x74")]
	private bool hasShot;

	[Token(Token = "0x600094F")]
	[Address(RVA = "0x16D6214", Offset = "0x16D6214", VA = "0x16D6214", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x16D62D0", Offset = "0x16D62D0", VA = "0x16D62D0")]
	private void ControllerOnOnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000951")]
	[Address(RVA = "0x16D6318", Offset = "0x16D6318", VA = "0x16D6318", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000952")]
	[Address(RVA = "0x16D6428", Offset = "0x16D6428", VA = "0x16D6428")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000953")]
	[Address(RVA = "0x16D651C", Offset = "0x16D651C", VA = "0x16D651C")]
	public SpinningBowlerBall()
	{
	}
}
