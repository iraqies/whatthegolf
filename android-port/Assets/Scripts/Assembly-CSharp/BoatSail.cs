using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A8D")]
public class BoatSail : OverworldBall2D
{
	[Token(Token = "0x4003A9A")]
	[FieldOffset(Offset = "0xD8")]
	public Transform MastPivot;

	[Token(Token = "0x4003A9B")]
	[FieldOffset(Offset = "0xE0")]
	public float MastRotateSpeed;

	[Token(Token = "0x4003A9C")]
	[FieldOffset(Offset = "0xE8")]
	public Transform SailControl;

	[Token(Token = "0x4003A9D")]
	[FieldOffset(Offset = "0xF0")]
	public Vector2 SailRange;

	[Token(Token = "0x4003A9E")]
	[FieldOffset(Offset = "0xF8")]
	public float SailSpeedMod;

	[Token(Token = "0x4003A9F")]
	[FieldOffset(Offset = "0x100")]
	public LineRenderer Line;

	[Token(Token = "0x4003AA0")]
	[FieldOffset(Offset = "0x108")]
	public Rigidbody2D Rigid;

	[Token(Token = "0x4003AA1")]
	[FieldOffset(Offset = "0x110")]
	public float BaseSpeed;

	[Token(Token = "0x4003AA2")]
	[FieldOffset(Offset = "0x114")]
	public float MaxSpeed;

	[Token(Token = "0x4003AA3")]
	[FieldOffset(Offset = "0x118")]
	public float BoatRotateSpeed;

	[Token(Token = "0x4003AA4")]
	[FieldOffset(Offset = "0x11C")]
	public float sidewaysDrag;

	[Token(Token = "0x4003AA5")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 boatDir;

	[Token(Token = "0x4003AA6")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 dir;

	[Token(Token = "0x4003AA7")]
	[FieldOffset(Offset = "0x138")]
	private float curSpeed;

	[Token(Token = "0x4003AA8")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 currentWindForce;

	[Token(Token = "0x4003AA9")]
	[FieldOffset(Offset = "0x148")]
	private Vector3 baseWindForce;

	[Token(Token = "0x4003AAA")]
	[FieldOffset(Offset = "0x154")]
	private float windDecrease;

	[Token(Token = "0x4003AAB")]
	[FieldOffset(Offset = "0x158")]
	private float sailCurrent;

	[Token(Token = "0x6003261")]
	[Address(RVA = "0x1616EA0", Offset = "0x1616EA0", VA = "0x1616EA0", Slot = "14")]
	protected override void Controller_OnCancel()
	{
	}

	[Token(Token = "0x6003262")]
	[Address(RVA = "0x1616ED0", Offset = "0x1616ED0", VA = "0x1616ED0", Slot = "17")]
	protected override void Shooter_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6003263")]
	[Address(RVA = "0x1616F04", Offset = "0x1616F04", VA = "0x1616F04", Slot = "16")]
	protected override void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
	}

	[Token(Token = "0x6003264")]
	[Address(RVA = "0x161700C", Offset = "0x161700C", VA = "0x161700C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003265")]
	[Address(RVA = "0x1617308", Offset = "0x1617308", VA = "0x1617308", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6003266")]
	[Address(RVA = "0x16174FC", Offset = "0x16174FC", VA = "0x16174FC")]
	public BoatSail()
	{
	}
}
