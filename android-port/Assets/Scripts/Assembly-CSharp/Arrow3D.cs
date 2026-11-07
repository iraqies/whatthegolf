using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001CD")]
public class Arrow3D : MonoBehaviour
{
	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x18")]
	public List<Collider> Colliders;

	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x28")]
	public Action OnHitGoal;

	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x30")]
	public Action OnMissGoal;

	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask HitLayers;

	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x40")]
	public Action OnReset;

	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x48")]
	public bool CanWin;

	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x49")]
	public bool Initialized;

	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0x4A")]
	public bool stuck;

	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0x50")]
	private RotateWithVelocity rotator;

	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0x58")]
	public bool shouldStick;

	[NonSerialized]
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0x60")]
	public string golfGoalLayerTag;

	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float minPenetration;

	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float maxPenetration;

	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float additionalHitForce;

	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4A3EC", Offset = "0x4A3EC")]
	[SerializeField]
	private float penetrationFactor;

	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x78")]
	public Action<Collision> OnCollisionEnterExtraActions;

	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x80")]
	private float lastVelBeforeHit;

	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion lastRotationBeforeHit;

	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 lastPositionBeforeHit;

	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0xA0")]
	private float collisionVel;

	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0xA8")]
	private Collision collision;

	[Token(Token = "0x6000808")]
	[Address(RVA = "0x1426630", Offset = "0x1426630", VA = "0x1426630")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000809")]
	[Address(RVA = "0x14267A8", Offset = "0x14267A8", VA = "0x14267A8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600080A")]
	[Address(RVA = "0x1426848", Offset = "0x1426848", VA = "0x1426848")]
	private void HitSomething(Collision collision)
	{
	}

	[Token(Token = "0x600080B")]
	[Address(RVA = "0x1426E0C", Offset = "0x1426E0C", VA = "0x1426E0C")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x600080C")]
	[Address(RVA = "0x1426E10", Offset = "0x1426E10", VA = "0x1426E10")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0x1426E98", Offset = "0x1426E98", VA = "0x1426E98")]
	public void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x14270AC", Offset = "0x14270AC", VA = "0x14270AC")]
	public Arrow3D()
	{
	}
}
