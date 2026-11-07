using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B14")]
public class NearestVertGravity : MonoBehaviour
{
	[Token(Token = "0x4003DF2")]
	[FieldOffset(Offset = "0x18")]
	public Collider GravityCollider;

	[Token(Token = "0x4003DF3")]
	[FieldOffset(Offset = "0x20")]
	public bool SetWorldUp;

	[Token(Token = "0x4003DF4")]
	[FieldOffset(Offset = "0x21")]
	public bool SetModelRotation;

	[Token(Token = "0x4003DF5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject nearest;

	[Token(Token = "0x4003DF6")]
	[FieldOffset(Offset = "0x30")]
	public Transform CheckTransform;

	[Token(Token = "0x4003DF7")]
	[FieldOffset(Offset = "0x38")]
	public bool FlipOnHitByGolfBall;

	[Token(Token = "0x4003DF8")]
	[FieldOffset(Offset = "0x3C")]
	public float upwardsImpulseOnHit;

	[Token(Token = "0x4003DF9")]
	[FieldOffset(Offset = "0x40")]
	public List<Transform> ModelsToMatchUpWith;

	[Token(Token = "0x4003DFA")]
	[FieldOffset(Offset = "0x48")]
	private ConstantForce constForce;

	[Token(Token = "0x4003DFB")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 lastUp;

	[Token(Token = "0x4003DFC")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigid;

	[Token(Token = "0x4003DFD")]
	[FieldOffset(Offset = "0x68")]
	private float delay;

	[Token(Token = "0x4003DFE")]
	[FieldOffset(Offset = "0x6C")]
	private bool isFlipped;

	[Token(Token = "0x4003DFF")]
	[FieldOffset(Offset = "0x70")]
	private float magnitude;

	[Token(Token = "0x60034E7")]
	[Address(RVA = "0x158BD10", Offset = "0x158BD10", VA = "0x158BD10")]
	private void Start()
	{
	}

	[Token(Token = "0x60034E8")]
	[Address(RVA = "0x158BF60", Offset = "0x158BF60", VA = "0x158BF60")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034E9")]
	[Address(RVA = "0x158C5F8", Offset = "0x158C5F8", VA = "0x158C5F8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60034EA")]
	[Address(RVA = "0x158C750", Offset = "0x158C750", VA = "0x158C750")]
	public NearestVertGravity()
	{
	}
}
