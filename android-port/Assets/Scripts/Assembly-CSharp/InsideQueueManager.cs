using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079C")]
public class InsideQueueManager : MonoBehaviour
{
	[Token(Token = "0x400282B")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> QueueMembers;

	[Token(Token = "0x400282C")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 QueueDirection;

	[Token(Token = "0x400282D")]
	[FieldOffset(Offset = "0x2C")]
	public float StopInterval;

	[Token(Token = "0x400282E")]
	[FieldOffset(Offset = "0x30")]
	public float StopDuration;

	[Token(Token = "0x400282F")]
	[FieldOffset(Offset = "0x34")]
	public float MoveForce;

	[Token(Token = "0x4002830")]
	[FieldOffset(Offset = "0x38")]
	public float StartDelay;

	[Token(Token = "0x4002831")]
	[FieldOffset(Offset = "0x3C")]
	public float JumpForce;

	[Token(Token = "0x4002832")]
	[FieldOffset(Offset = "0x40")]
	public float AlertRange;

	[Token(Token = "0x4002833")]
	[FieldOffset(Offset = "0x44")]
	public float KillDistance;

	[Token(Token = "0x4002834")]
	[FieldOffset(Offset = "0x48")]
	public BoxCollider ActivityCollider;

	[Token(Token = "0x4002835")]
	[FieldOffset(Offset = "0x50")]
	public Transform QueueTarget;

	[Token(Token = "0x4002836")]
	[FieldOffset(Offset = "0x58")]
	public Transform Player;

	[Token(Token = "0x4002837")]
	[FieldOffset(Offset = "0x60")]
	public InsideObserver Observer;

	[Token(Token = "0x4002838")]
	[FieldOffset(Offset = "0x68")]
	public List<SpiderLegs> Spiders;

	[Token(Token = "0x4002839")]
	[FieldOffset(Offset = "0x70")]
	public float SpiderMoveSpeed;

	[Token(Token = "0x400283A")]
	[FieldOffset(Offset = "0x78")]
	public GolfBallController PlayerController;

	[Token(Token = "0x400283B")]
	[FieldOffset(Offset = "0x80")]
	public Transform StopFollowPoint;

	[Token(Token = "0x400283C")]
	[FieldOffset(Offset = "0x88")]
	private float stopTimer;

	[Token(Token = "0x400283D")]
	[FieldOffset(Offset = "0x8C")]
	private float startDelayTimer;

	[Token(Token = "0x400283E")]
	[FieldOffset(Offset = "0x90")]
	private float alertTime;

	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x14F0880", Offset = "0x14F0880", VA = "0x14F0880")]
	private void Start()
	{
	}

	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x14F0930", Offset = "0x14F0930", VA = "0x14F0930")]
	private void PlayerOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x14F09A0", Offset = "0x14F09A0", VA = "0x14F09A0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x14F0FD4", Offset = "0x14F0FD4", VA = "0x14F0FD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x14F1450", Offset = "0x14F1450", VA = "0x14F1450")]
	public InsideQueueManager()
	{
	}
}
