using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x41A48", Offset = "0x41A48")]
public class StickyBall : MonoBehaviour
{
	[Token(Token = "0x4002DEE")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F3A4", Offset = "0x4F3A4")]
	public float Stickiness;

	[Token(Token = "0x4002DEF")]
	[FieldOffset(Offset = "0x1C")]
	public bool UseFixedJoint;

	[Token(Token = "0x4002DF0")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem Particles;

	[Token(Token = "0x4002DF1")]
	[FieldOffset(Offset = "0x28")]
	public int ParticlesToEmit;

	[Token(Token = "0x4002DF2")]
	[FieldOffset(Offset = "0x2C")]
	public float StickDelay;

	[Token(Token = "0x4002DF3")]
	[FieldOffset(Offset = "0x30")]
	public LayerMask BlacklistLayerMask;

	[Token(Token = "0x4002DF4")]
	[FieldOffset(Offset = "0x38")]
	public Action<Vector3> OnStuck;

	[Token(Token = "0x4002DF5")]
	[FieldOffset(Offset = "0x40")]
	public Action OnUnStuck;

	[Token(Token = "0x4002DF6")]
	[FieldOffset(Offset = "0x48")]
	private GolfBallController ball;

	[Token(Token = "0x4002DF7")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody2D rigid2D;

	[Token(Token = "0x4002DF8")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody rigid;

	[Token(Token = "0x4002DF9")]
	[FieldOffset(Offset = "0x60")]
	private bool isStuck;

	[Token(Token = "0x4002DFA")]
	[FieldOffset(Offset = "0x68")]
	private ConstantForce force;

	[Token(Token = "0x4002DFB")]
	[FieldOffset(Offset = "0x70")]
	private ConstantForce2D force2D;

	[Token(Token = "0x4002DFC")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 startForce;

	[Token(Token = "0x4002DFD")]
	[FieldOffset(Offset = "0x88")]
	private FixedJoint currentJoint;

	[Token(Token = "0x4002DFE")]
	[FieldOffset(Offset = "0x90")]
	private FixedJoint2D currentJoint2D;

	[Token(Token = "0x4002DFF")]
	[FieldOffset(Offset = "0x98")]
	private float stickDelay;

	[Token(Token = "0x4002E00")]
	[FieldOffset(Offset = "0x9C")]
	private bool attachedToRigidbody;

	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x16DF570", Offset = "0x16DF570", VA = "0x16DF570")]
	private void Awake()
	{
	}

	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x16DF6FC", Offset = "0x16DF6FC", VA = "0x16DF6FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x16DF7D0", Offset = "0x16DF7D0", VA = "0x16DF7D0")]
	private void Ball_OnPreShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x16DF900", Offset = "0x16DF900", VA = "0x16DF900")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x16DF8E4", Offset = "0x16DF8E4", VA = "0x16DF8E4")]
	private void Unstuck()
	{
	}

	[Token(Token = "0x60026D2")]
	[Address(RVA = "0x16DFC48", Offset = "0x16DFC48", VA = "0x16DFC48")]
	private void Stuck(Vector3 normal)
	{
	}

	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x16DFCDC", Offset = "0x16DFCDC", VA = "0x16DFCDC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x16E0018", Offset = "0x16E0018", VA = "0x16E0018")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x16E0078", Offset = "0x16E0078", VA = "0x16E0078")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x16E03E4", Offset = "0x16E03E4", VA = "0x16E03E4")]
	private void OnCollisionStay2D(Collision2D other)
	{
	}

	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x16E0444", Offset = "0x16E0444", VA = "0x16E0444")]
	public StickyBall()
	{
	}
}
