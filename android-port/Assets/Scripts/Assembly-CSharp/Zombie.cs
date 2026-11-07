using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200094B")]
public class Zombie : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200094C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x421B0", Offset = "0x421B0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__34_0;

		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x187DD90", Offset = "0x187DD90", VA = "0x187DD90")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x187DD98", Offset = "0x187DD98", VA = "0x187DD98")]
		internal void _003CDoKick_003Eb__34_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x400331B")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] patrolRoute;

	[Token(Token = "0x400331C")]
	[FieldOffset(Offset = "0x20")]
	public ZombieClub[] golfClubs;

	[Token(Token = "0x400331D")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody ball;

	[Token(Token = "0x400331E")]
	[FieldOffset(Offset = "0x30")]
	public bool KickTarget;

	[Token(Token = "0x400331F")]
	[FieldOffset(Offset = "0x34")]
	public float UpKickForce;

	[Token(Token = "0x4003320")]
	[FieldOffset(Offset = "0x38")]
	public float ForwardKickForce;

	[Token(Token = "0x4003321")]
	[FieldOffset(Offset = "0x3C")]
	public float kickRange;

	[Token(Token = "0x4003322")]
	[FieldOffset(Offset = "0x40")]
	public float slowSpeed;

	[Token(Token = "0x4003323")]
	[FieldOffset(Offset = "0x44")]
	public float fastSpeed;

	[Token(Token = "0x4003324")]
	[FieldOffset(Offset = "0x48")]
	public float reactDistance;

	[Token(Token = "0x4003325")]
	[FieldOffset(Offset = "0x4C")]
	public float stopDistance;

	[Token(Token = "0x4003326")]
	[FieldOffset(Offset = "0x50")]
	public List<AudioClip> sfxKick;

	[Token(Token = "0x4003327")]
	[FieldOffset(Offset = "0x58")]
	public float rotateSpeed;

	[Token(Token = "0x4003328")]
	[FieldOffset(Offset = "0x5C")]
	public bool lookAlongVelocity;

	[Token(Token = "0x4003329")]
	[FieldOffset(Offset = "0x60")]
	public float sightRange;

	[Token(Token = "0x400332A")]
	[FieldOffset(Offset = "0x64")]
	public float timeBeforeStopChase;

	[Token(Token = "0x400332B")]
	[FieldOffset(Offset = "0x68")]
	public float sightAngle;

	[Token(Token = "0x400332C")]
	[FieldOffset(Offset = "0x6C")]
	public float angleToForwardBeforeMove;

	[Token(Token = "0x400332D")]
	[FieldOffset(Offset = "0x70")]
	public float maxGroundAngle;

	[Token(Token = "0x400332E")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 startPosition;

	[Token(Token = "0x400332F")]
	[FieldOffset(Offset = "0x80")]
	private Quaternion startRotation;

	[Token(Token = "0x4003330")]
	[FieldOffset(Offset = "0x90")]
	private Rigidbody rigid;

	[Token(Token = "0x4003331")]
	[FieldOffset(Offset = "0x98")]
	private float nextHit;

	[Token(Token = "0x4003332")]
	[FieldOffset(Offset = "0x9C")]
	private bool targetIsTouching;

	[Token(Token = "0x4003333")]
	[FieldOffset(Offset = "0xA0")]
	private float lastSeenPlayer;

	[Token(Token = "0x4003334")]
	[FieldOffset(Offset = "0xA8")]
	private Transform golfClubSeat;

	[Token(Token = "0x4003335")]
	[FieldOffset(Offset = "0xB0")]
	private ZombieClub golfClub;

	[Token(Token = "0x4003336")]
	[FieldOffset(Offset = "0xB8")]
	private int currentPatrolTarget;

	[Token(Token = "0x4003337")]
	[FieldOffset(Offset = "0xC0")]
	private Rigidbody ground;

	[Token(Token = "0x4003338")]
	[FieldOffset(Offset = "0xC8")]
	private bool grounded;

	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x1762328", Offset = "0x1762328", VA = "0x1762328")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B5F")]
	[Address(RVA = "0x1762468", Offset = "0x1762468", VA = "0x1762468")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6002B60")]
	[Address(RVA = "0x17625E4", Offset = "0x17625E4", VA = "0x17625E4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002B61")]
	[Address(RVA = "0x17629BC", Offset = "0x17629BC", VA = "0x17629BC")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6002B62")]
	[Address(RVA = "0x17627A8", Offset = "0x17627A8", VA = "0x17627A8")]
	private void DoKick(Rigidbody other)
	{
	}

	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x1762AA8", Offset = "0x1762AA8", VA = "0x1762AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x1762C00", Offset = "0x1762C00", VA = "0x1762C00")]
	private bool CanSee(GameObject obj)
	{
		return default;
	}

	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x1762F80", Offset = "0x1762F80", VA = "0x1762F80")]
	public void GraveAwake()
	{
	}

	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x1762FA8", Offset = "0x1762FA8", VA = "0x1762FA8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x17635A8", Offset = "0x17635A8", VA = "0x17635A8")]
	private void MoveTowards(Vector3 target, float speed)
	{
	}

	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x1763464", Offset = "0x1763464", VA = "0x1763464")]
	private void LookTowards(Vector3 target, float speed)
	{
	}

	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x1763774", Offset = "0x1763774", VA = "0x1763774")]
	private void LookTowards(Quaternion target, float speed)
	{
	}

	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x1763830", Offset = "0x1763830", VA = "0x1763830")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x1763B1C", Offset = "0x1763B1C", VA = "0x1763B1C")]
	public Zombie()
	{
	}
}
