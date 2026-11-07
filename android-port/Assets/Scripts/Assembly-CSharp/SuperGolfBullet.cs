using System;
using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000830")]
public class SuperGolfBullet : MonoBehaviour
{
	[Token(Token = "0x4002C1D")]
	[FieldOffset(Offset = "0x18")]
	public ObjectPool<GameObject> BulletPool;

	[Token(Token = "0x4002C1E")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x4002C1F")]
	[FieldOffset(Offset = "0x24")]
	public float LifeTime;

	[Token(Token = "0x4002C20")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem BulletDeathParticles;

	[Token(Token = "0x4002C21")]
	[FieldOffset(Offset = "0x30")]
	public Collider collider;

	[Token(Token = "0x4002C22")]
	[FieldOffset(Offset = "0x38")]
	public int Bounces;

	[Token(Token = "0x4002C23")]
	[FieldOffset(Offset = "0x3C")]
	public bool KillOnImpact;

	[Token(Token = "0x4002C24")]
	[FieldOffset(Offset = "0x40")]
	public Collider previousOwnerCollider;

	[Token(Token = "0x4002C25")]
	[FieldOffset(Offset = "0x48")]
	public List<Collider> previousOwnerColliders;

	[Token(Token = "0x4002C26")]
	[FieldOffset(Offset = "0x50")]
	public Action<SuperGolfBullet> OnBulletDeath;

	[Token(Token = "0x4002C27")]
	[FieldOffset(Offset = "0x58")]
	private float currentLifeTime;

	[Token(Token = "0x4002C28")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigidBody;

	[Token(Token = "0x4002C29")]
	[FieldOffset(Offset = "0x68")]
	private Timeline timeline;

	[Token(Token = "0x4002C2A")]
	[FieldOffset(Offset = "0x70")]
	private float originalMoveSpeed;

	[Token(Token = "0x4002C2B")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 direction;

	[Token(Token = "0x4002C2C")]
	[FieldOffset(Offset = "0x80")]
	private float trailTime;

	[Token(Token = "0x4002C2D")]
	[FieldOffset(Offset = "0x88")]
	protected TrailRenderer trail;

	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x16E81AC", Offset = "0x16E81AC", VA = "0x16E81AC", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x16E82C0", Offset = "0x16E82C0", VA = "0x16E82C0", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x16E8360", Offset = "0x16E8360", VA = "0x16E8360", Slot = "6")]
	public virtual void SetSpeed(float speedMod)
	{
	}

	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x16E83E0", Offset = "0x16E83E0", VA = "0x16E83E0", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60025AB")]
	[Address(RVA = "0x16E8558", Offset = "0x16E8558", VA = "0x16E8558")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60025AC")]
	[Address(RVA = "0x16E912C", Offset = "0x16E912C", VA = "0x16E912C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x16E92E8", Offset = "0x16E92E8", VA = "0x16E92E8", Slot = "8")]
	protected virtual void KillBullet(Vector3 point)
	{
	}

	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x16E959C", Offset = "0x16E959C", VA = "0x16E959C")]
	public SuperGolfBullet()
	{
	}
}
