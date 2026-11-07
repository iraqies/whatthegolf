using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000893")]
public class BanjoShooter2D : ShooterBase
{
	[Token(Token = "0x4002F0C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float aimSpringFactor;

	[Token(Token = "0x4002F0D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxAngularVelocity;

	[Token(Token = "0x4002F0E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float maxAngleDelta;

	[Token(Token = "0x4002F0F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float springDampAngle;

	[Token(Token = "0x4002F10")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float springDampPower;

	[Token(Token = "0x4002F11")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Rigidbody2D grabRigidbody;

	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector2 centerOfMass;

	[Token(Token = "0x4002F13")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float shootForce;

	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4002F15")]
	[FieldOffset(Offset = "0x58")]
	private FixedJoint2D grabJoint;

	[Token(Token = "0x4002F16")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 grabLocalPosition;

	[Token(Token = "0x6002790")]
	[Address(RVA = "0x151A91C", Offset = "0x151A91C", VA = "0x151A91C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002791")]
	[Address(RVA = "0x151A9B0", Offset = "0x151A9B0", VA = "0x151A9B0", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6002792")]
	[Address(RVA = "0x151AA64", Offset = "0x151AA64", VA = "0x151AA64", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0x151AB64", Offset = "0x151AB64", VA = "0x151AB64", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6002794")]
	[Address(RVA = "0x151AC44", Offset = "0x151AC44", VA = "0x151AC44", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0x151AB68", Offset = "0x151AB68", VA = "0x151AB68")]
	private void ReleaseGrab()
	{
	}

	[Token(Token = "0x6002796")]
	[Address(RVA = "0x151AC8C", Offset = "0x151AC8C", VA = "0x151AC8C")]
	private void OnHitGoal()
	{
	}

	[Token(Token = "0x6002797")]
	[Address(RVA = "0x151ACC0", Offset = "0x151ACC0", VA = "0x151ACC0")]
	public BanjoShooter2D()
	{
	}
}
