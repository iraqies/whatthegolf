using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B5")]
public class GolfCartShooter : GolfBallShooterBase
{
	[Token(Token = "0x4001D22")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rb;

	[Token(Token = "0x4001D23")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private WheelCollider FL;

	[Token(Token = "0x4001D24")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private WheelCollider FR;

	[Token(Token = "0x4001D25")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private WheelCollider BL;

	[Token(Token = "0x4001D26")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private WheelCollider BR;

	[Token(Token = "0x4001D27")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float torque;

	[Token(Token = "0x4001D28")]
	[FieldOffset(Offset = "0x90")]
	private WheelCollider[] wheels;

	[Token(Token = "0x4001D29")]
	[FieldOffset(Offset = "0x98")]
	private bool spinWheels;

	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x149D850", Offset = "0x149D850", VA = "0x149D850", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x149D9AC", Offset = "0x149D9AC", VA = "0x149D9AC", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x149DA08", Offset = "0x149DA08", VA = "0x149DA08", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x149DAD0", Offset = "0x149DAD0", VA = "0x149DAD0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x149DB78", Offset = "0x149DB78", VA = "0x149DB78")]
	private new void FixedUpdate()
	{
	}

	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x149DBF4", Offset = "0x149DBF4", VA = "0x149DBF4")]
	public GolfCartShooter()
	{
	}
}
