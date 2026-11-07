using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD8")]
public class SnowBallTargetBehaviourWithObject : MonoBehaviour
{
	[Token(Token = "0x40045CE")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 IdleTimeAtWayPoint;

	[Token(Token = "0x40045CF")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x40045D0")]
	[FieldOffset(Offset = "0x28")]
	public float MoveSpeed;

	[Token(Token = "0x40045D1")]
	[FieldOffset(Offset = "0x2C")]
	public float RotateSpeed;

	[Token(Token = "0x40045D2")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	[Token(Token = "0x40045D3")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 AnimatorSpeedRanges;

	[Token(Token = "0x40045D4")]
	[FieldOffset(Offset = "0x40")]
	public DollyCartController FollowTarget;

	[Token(Token = "0x40045D5")]
	[FieldOffset(Offset = "0x48")]
	public float SpeedMod;

	[Token(Token = "0x40045D6")]
	[FieldOffset(Offset = "0x4C")]
	public float RotateAnimationSpeed;

	[Token(Token = "0x40045D7")]
	[FieldOffset(Offset = "0x50")]
	public Action<SnowBallTargetBehaviourWithObject> OnCollapsed;

	[Token(Token = "0x40045D8")]
	[FieldOffset(Offset = "0x58")]
	public AudioEventAsset sfxEventOnCollapse;

	[Token(Token = "0x40045D9")]
	[FieldOffset(Offset = "0x60")]
	public AudioEventAsset sfxOnSpeedup;

	[Token(Token = "0x40045DA")]
	[FieldOffset(Offset = "0x68")]
	private float idleTime;

	[Token(Token = "0x40045DB")]
	[FieldOffset(Offset = "0x6C")]
	private float lastAnimatorSpeed;

	[Token(Token = "0x40045DC")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 refVel;

	[Token(Token = "0x40045DD")]
	[FieldOffset(Offset = "0x7C")]
	private float lastFrameDeltaTime;

	[Token(Token = "0x40045DE")]
	[FieldOffset(Offset = "0x80")]
	private bool hasCollapsed;

	[Token(Token = "0x40045DF")]
	[FieldOffset(Offset = "0x81")]
	private bool firstFrame;

	[Token(Token = "0x40045E0")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 oldPos;

	[Token(Token = "0x40045E1")]
	[FieldOffset(Offset = "0x90")]
	private float targetVel;

	[Token(Token = "0x40045E2")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 forward;

	[Token(Token = "0x40045E3")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject carriedObject;

	[Token(Token = "0x6003CCD")]
	[Address(RVA = "0x16BBFF0", Offset = "0x16BBFF0", VA = "0x16BBFF0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003CCE")]
	[Address(RVA = "0x16BC208", Offset = "0x16BC208", VA = "0x16BC208")]
	private void Update()
	{
	}

	[Token(Token = "0x6003CCF")]
	[Address(RVA = "0x16BC4D8", Offset = "0x16BC4D8", VA = "0x16BC4D8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003CD0")]
	[Address(RVA = "0x16BC6E8", Offset = "0x16BC6E8", VA = "0x16BC6E8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003CD1")]
	[Address(RVA = "0x16BC710", Offset = "0x16BC710", VA = "0x16BC710")]
	public bool Collapse(Collision other, Rigidbody targetRigid)
	{
		return default;
	}

	[Token(Token = "0x6003CD2")]
	[Address(RVA = "0x16BC8F4", Offset = "0x16BC8F4", VA = "0x16BC8F4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003CD3")]
	[Address(RVA = "0x16BC964", Offset = "0x16BC964", VA = "0x16BC964")]
	public SnowBallTargetBehaviourWithObject()
	{
	}
}
