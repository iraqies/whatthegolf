using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B7")]
public class Karaoke2DShooter : ShooterBase
{
	[Token(Token = "0x40028A5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float forwardSpeed;

	[Token(Token = "0x40028A6")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float jumpSpeed;

	[Token(Token = "0x40028A7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float checkY;

	[Token(Token = "0x40028A8")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float checkLength;

	[Token(Token = "0x40028A9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float checkRadius;

	[Token(Token = "0x40028AA")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float fallLimit;

	[Token(Token = "0x40028AB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float groundSkin;

	[Token(Token = "0x40028AC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float failY;

	[Token(Token = "0x40028AD")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 velocity;

	[Token(Token = "0x40028AE")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 gravity;

	[Token(Token = "0x40028AF")]
	[FieldOffset(Offset = "0x50")]
	private bool isGrounded;

	[Token(Token = "0x40028B0")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4EBBC", Offset = "0x4EBBC")]
	private Action m_OnBeginForwardMovement;

	[Token(Token = "0x40028B1")]
	[FieldOffset(Offset = "0x60")]
	private bool isMoving;

	[Token(Token = "0x170003DB")]
	public bool IsGrounded
	{
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x14F9EAC", Offset = "0x14F9EAC", VA = "0x14F9EAC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000031")]
	public event Action OnBeginForwardMovement
	{
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x14F9944", Offset = "0x14F9944", VA = "0x14F9944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x660EC", Offset = "0x660EC")]
		add
		{
		}
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x14F99E8", Offset = "0x14F99E8", VA = "0x14F99E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x660FC", Offset = "0x660FC")]
		remove
		{
		}
	}

	[Token(Token = "0x600234D")]
	[Address(RVA = "0x14F9A8C", Offset = "0x14F9A8C", VA = "0x14F9A8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600234E")]
	[Address(RVA = "0x14F9B44", Offset = "0x14F9B44", VA = "0x14F9B44", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600234F")]
	[Address(RVA = "0x14F9BB8", Offset = "0x14F9BB8", VA = "0x14F9BB8")]
	private float GetGroundY(float checkX)
	{
		return default;
	}

	[Token(Token = "0x6002350")]
	[Address(RVA = "0x14F9D14", Offset = "0x14F9D14", VA = "0x14F9D14")]
	public void Update()
	{
	}

	[Token(Token = "0x6002352")]
	[Address(RVA = "0x14F9EB4", Offset = "0x14F9EB4", VA = "0x14F9EB4")]
	public Karaoke2DShooter()
	{
	}

	[Token(Token = "0x6002353")]
	[Address(RVA = "0x14F9F10", Offset = "0x14F9F10", VA = "0x14F9F10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6610C", Offset = "0x6610C")]
	private void _003CStart_003Eb__15_0(Level.CompletedState s)
	{
	}
}
