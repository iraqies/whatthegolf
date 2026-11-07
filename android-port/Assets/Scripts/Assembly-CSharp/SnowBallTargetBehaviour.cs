using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000032")]
public class SnowBallTargetBehaviour : MonoBehaviour
{
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 IdleTimeAtWayPoint;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x28")]
	public float MoveSpeed;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x2C")]
	public float RotateSpeed;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 AnimatorSpeedRanges;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x40")]
	public DollyCartController FollowTarget;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x48")]
	public float SpeedMod;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x4C")]
	public float RotateAnimationSpeed;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x50")]
	public bool KeepAnimatorOnCollapse;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x58")]
	public Action<SnowBallTargetBehaviour> OnCollapsed;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x60")]
	public AudioEventAsset sfxEventOnCollapse;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x68")]
	public AudioEventAsset sfxOnSpeedup;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x70")]
	private float idleTime;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x74")]
	private float lastAnimatorSpeed;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 refVel;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x84")]
	private float lastFrameDeltaTime;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x88")]
	private bool hasCollapsed;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x89")]
	private bool firstFrame;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 oldPos;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x98")]
	private float targetVel;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 forward;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0xA8")]
	private float savedRotSpeed;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0xAC")]
	private float savedMoveSpeed;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x16BB680", Offset = "0x16BB680", VA = "0x16BB680")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x16BB898", Offset = "0x16BB898", VA = "0x16BB898")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x16BBB68", Offset = "0x16BBB68", VA = "0x16BBB68")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x16BBD78", Offset = "0x16BBD78", VA = "0x16BBD78")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x16BBDA0", Offset = "0x16BBDA0", VA = "0x16BBDA0")]
	public void StopMovement()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x16BBDB0", Offset = "0x16BBDB0", VA = "0x16BBDB0")]
	public void ResumeMovement()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x16BBDBC", Offset = "0x16BBDBC", VA = "0x16BBDBC")]
	public bool Collapse(Collision other, Rigidbody targetRigid)
	{
		return default;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x16BBF58", Offset = "0x16BBF58", VA = "0x16BBF58")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x16BBFC8", Offset = "0x16BBFC8", VA = "0x16BBFC8")]
	public SnowBallTargetBehaviour()
	{
	}
}
