using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000700")]
public class FishingBall : MonoBehaviour
{
	[Token(Token = "0x40024C3")]
	[FieldOffset(Offset = "0x18")]
	public ObjectPool<GameObject> BulletPool;

	[Token(Token = "0x40024C4")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x40024C5")]
	[FieldOffset(Offset = "0x24")]
	public float LifeTime;

	[Token(Token = "0x40024C6")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem BulletDeathParticles;

	[Token(Token = "0x40024C7")]
	[FieldOffset(Offset = "0x30")]
	public Collider collider;

	[Token(Token = "0x40024C8")]
	[FieldOffset(Offset = "0x38")]
	private float currentLifeTime;

	[Token(Token = "0x40024C9")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidBody;

	[Token(Token = "0x40024CA")]
	[FieldOffset(Offset = "0x48")]
	private Timeline timeline;

	[Token(Token = "0x40024CB")]
	[FieldOffset(Offset = "0x50")]
	private TrailRenderer trail;

	[Token(Token = "0x40024CC")]
	[FieldOffset(Offset = "0x58")]
	private LineRenderer line;

	[Token(Token = "0x40024CD")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 lastLinePos;

	[Token(Token = "0x40024CE")]
	[FieldOffset(Offset = "0x6C")]
	public float lineSegmentDistance;

	[Token(Token = "0x40024CF")]
	[FieldOffset(Offset = "0x70")]
	private int lineSections;

	[Token(Token = "0x40024D0")]
	[FieldOffset(Offset = "0x78")]
	private List<Vector3> linePositions;

	[Token(Token = "0x40024D1")]
	[FieldOffset(Offset = "0x80")]
	private bool inWater;

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x1468C3C", Offset = "0x1468C3C", VA = "0x1468C3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002051")]
	[Address(RVA = "0x1468D54", Offset = "0x1468D54", VA = "0x1468D54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002052")]
	[Address(RVA = "0x1466B2C", Offset = "0x1466B2C", VA = "0x1466B2C")]
	public void SetSpeed(float speedMod)
	{
	}

	[Token(Token = "0x6002053")]
	[Address(RVA = "0x1468E3C", Offset = "0x1468E3C", VA = "0x1468E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002054")]
	[Address(RVA = "0x14693C0", Offset = "0x14693C0", VA = "0x14693C0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002055")]
	[Address(RVA = "0x14694BC", Offset = "0x14694BC", VA = "0x14694BC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x1468F3C", Offset = "0x1468F3C", VA = "0x1468F3C")]
	private void KillBullet(Vector3 point)
	{
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0x1469124", Offset = "0x1469124", VA = "0x1469124")]
	private void DrawFishingLine()
	{
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0x1469594", Offset = "0x1469594", VA = "0x1469594")]
	public FishingBall()
	{
	}
}
