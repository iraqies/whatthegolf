using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B09")]
public class Fan2D : MonoBehaviour, IToggleable
{
	[Token(Token = "0x4003DAD")]
	[FieldOffset(Offset = "0x18")]
	public float SphereCastRadius;

	[Token(Token = "0x4003DAE")]
	[FieldOffset(Offset = "0x1C")]
	public float SphereCastDistance;

	[Token(Token = "0x4003DAF")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider2D EffectTrigger;

	[Token(Token = "0x4003DB0")]
	[FieldOffset(Offset = "0x28")]
	public float MaxForce;

	[Token(Token = "0x4003DB1")]
	[FieldOffset(Offset = "0x2C")]
	public bool CheckForTimeline;

	[Token(Token = "0x4003DB2")]
	[FieldOffset(Offset = "0x2D")]
	private bool isOn;

	[Token(Token = "0x4003DB3")]
	[FieldOffset(Offset = "0x30")]
	private RotateAxis rotator;

	[Token(Token = "0x4003DB4")]
	[FieldOffset(Offset = "0x38")]
	private float rotatorSpeed;

	[Token(Token = "0x4003DB5")]
	[FieldOffset(Offset = "0x3C")]
	private float rotatorSpeedTarget;

	[Token(Token = "0x4003DB6")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem particles;

	[Token(Token = "0x4003DB7")]
	[FieldOffset(Offset = "0x48")]
	public List<Rigidbody2D> affectedObjects;

	[Token(Token = "0x4003DB8")]
	[FieldOffset(Offset = "0x50")]
	public List<Timeline> affectedTimelines;

	[Token(Token = "0x17000569")]
	public bool IsOn
	{
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x145F80C", Offset = "0x145F80C", VA = "0x145F80C", Slot = "4")]
		get
		{
			return default;
		}
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x145F814", Offset = "0x145F814", VA = "0x145F814", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x60034B6")]
	[Address(RVA = "0x145F81C", Offset = "0x145F81C", VA = "0x145F81C")]
	private void Start()
	{
	}

	[Token(Token = "0x60034B7")]
	[Address(RVA = "0x145F93C", Offset = "0x145F93C", VA = "0x145F93C")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60034B8")]
	[Address(RVA = "0x145FB2C", Offset = "0x145FB2C", VA = "0x145FB2C")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x60034B9")]
	[Address(RVA = "0x145FC98", Offset = "0x145FC98", VA = "0x145FC98")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034BA")]
	[Address(RVA = "0x1460278", Offset = "0x1460278", VA = "0x1460278")]
	private void Update()
	{
	}

	[Token(Token = "0x60034BB")]
	[Address(RVA = "0x1460618", Offset = "0x1460618", VA = "0x1460618")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60034BC")]
	[Address(RVA = "0x1460724", Offset = "0x1460724", VA = "0x1460724", Slot = "7")]
	public void Toggle(bool state)
	{
	}

	[Token(Token = "0x60034BD")]
	[Address(RVA = "0x1460778", Offset = "0x1460778", VA = "0x1460778", Slot = "5")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60034BE")]
	[Address(RVA = "0x14607D4", Offset = "0x14607D4", VA = "0x14607D4")]
	public Fan2D()
	{
	}
}
