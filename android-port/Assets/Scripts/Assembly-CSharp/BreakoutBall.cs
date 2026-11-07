using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200060C")]
public class BreakoutBall : MonoBehaviour
{
	[Token(Token = "0x200060D")]
	public enum TransferVelocityMode
	{
		[Token(Token = "0x4001F41")]
		X = 0,
		[Token(Token = "0x4001F42")]
		Y = 1,
		[Token(Token = "0x4001F43")]
		XY = 2
	}

	[Token(Token = "0x4001F2D")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController player;

	[Token(Token = "0x4001F2E")]
	[FieldOffset(Offset = "0x20")]
	public float velTransferMagnitude;

	[Token(Token = "0x4001F2F")]
	[FieldOffset(Offset = "0x24")]
	public float maxVel;

	[Token(Token = "0x4001F30")]
	[FieldOffset(Offset = "0x28")]
	public float maxHits;

	[Token(Token = "0x4001F31")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve velocityEvolution;

	[Token(Token = "0x4001F32")]
	[FieldOffset(Offset = "0x38")]
	public float startNormalVel;

	[Token(Token = "0x4001F33")]
	[FieldOffset(Offset = "0x3C")]
	public float minPlayAxisVel;

	[Token(Token = "0x4001F34")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> ShootSounds;

	[Token(Token = "0x4001F35")]
	[FieldOffset(Offset = "0x48")]
	public TransferVelocityMode velTransferMode;

	[Token(Token = "0x4001F36")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4001F37")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 lastVel;

	[Token(Token = "0x4001F38")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody2D playerRigid;

	[Token(Token = "0x4001F39")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 lastPlayerVel;

	[Token(Token = "0x4001F3A")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 startOffset;

	[Token(Token = "0x4001F3B")]
	[FieldOffset(Offset = "0x78")]
	private float startRot;

	[Token(Token = "0x4001F3C")]
	[FieldOffset(Offset = "0x7C")]
	private int hits;

	[Token(Token = "0x4001F3D")]
	[FieldOffset(Offset = "0x80")]
	private float currentMaxVel;

	[Token(Token = "0x4001F3E")]
	[FieldOffset(Offset = "0x88")]
	public string playerTag;

	[Token(Token = "0x4001F3F")]
	[FieldOffset(Offset = "0x90")]
	public UnityAction OnTouchBat;

	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x17078F0", Offset = "0x17078F0", VA = "0x17078F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x1707A48", Offset = "0x1707A48", VA = "0x1707A48")]
	private void Player_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x1708078", Offset = "0x1708078", VA = "0x1708078")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x17080C0", Offset = "0x17080C0", VA = "0x17080C0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x1707BB8", Offset = "0x1707BB8", VA = "0x1707BB8")]
	private void CollideWithPlayer(Vector2 ballVel, Vector2 playerVel, Vector2 normal)
	{
	}

	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x17081FC", Offset = "0x17081FC", VA = "0x17081FC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x1708384", Offset = "0x1708384", VA = "0x1708384")]
	public BreakoutBall()
	{
	}
}
