using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E0")]
public class Vehicle : MonoBehaviour
{
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x18")]
	public bool controllable;

	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x20")]
	public Transform vehicleModel;

	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody sphere;

	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem smoke;

	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x38")]
	public Transform body;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4A47C", Offset = "0x4A47C")]
	public float acceleration;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4A498", Offset = "0x4A498")]
	public float steering;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4A4B4", Offset = "0x4A4B4")]
	public float jumpForce;

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4A4D4", Offset = "0x4A4D4")]
	public float gravity;

	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4A4EC", Offset = "0x4A4EC")]
	public float drift;

	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x58")]
	private Transform container;

	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x60")]
	private Transform wheelFrontLeft;

	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x68")]
	private Transform wheelFrontRight;

	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x70")]
	private TrailRenderer trailLeft;

	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x78")]
	private TrailRenderer trailRight;

	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x80")]
	private float speed;

	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x84")]
	private float speedTarget;

	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x88")]
	private float rotate;

	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x8C")]
	private float rotateTarget;

	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x90")]
	private bool nearGround;

	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x91")]
	private bool onGround;

	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 containerBase;

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x1748A8C", Offset = "0x1748A8C", VA = "0x1748A8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x1748AD8", Offset = "0x1748AD8", VA = "0x1748AD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x17490CC", Offset = "0x17490CC", VA = "0x17490CC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0x1749414", Offset = "0x1749414", VA = "0x1749414")]
	public void ControlAccelerate()
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x174942C", Offset = "0x174942C", VA = "0x174942C")]
	public void ControlSteer(int direction)
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x174944C", Offset = "0x174944C", VA = "0x174944C")]
	public void SetPosition(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x1749530", Offset = "0x1749530", VA = "0x1749530")]
	public Vehicle()
	{
	}
}
