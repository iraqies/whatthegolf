using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200031C")]
public class SimpleTargetBehaviour : MonoBehaviour
{
	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 IdleTimeAtWayPoint;

	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x4001129")]
	[FieldOffset(Offset = "0x28")]
	public float MoveSpeed;

	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0x2C")]
	public float RotateSpeed;

	[Token(Token = "0x400112B")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 AnimatorSpeedRanges;

	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x40")]
	public DollyCartController FollowTarget;

	[Token(Token = "0x400112E")]
	[FieldOffset(Offset = "0x48")]
	public float SpeedMod;

	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x4C")]
	public float RotateAnimationSpeed;

	[Token(Token = "0x4001130")]
	[FieldOffset(Offset = "0x50")]
	public Action<SimpleTargetBehaviour> OnCollapsed;

	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x58")]
	public AudioEventAsset sfxEventOnCollapse;

	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x60")]
	public AudioEventAsset sfxOnSpeedup;

	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x68")]
	private float idleTime;

	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0x6C")]
	private float lastAnimatorSpeed;

	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 refVel;

	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x7C")]
	private float lastFrameDeltaTime;

	[Token(Token = "0x4001137")]
	[FieldOffset(Offset = "0x80")]
	private bool hasCollapsed;

	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x81")]
	private bool firstFrame;

	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 oldPos;

	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x90")]
	private float targetVel;

	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 forward;

	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C35C", Offset = "0x4C35C")]
	private string hotdogTag__BackingField;

	[Token(Token = "0x170001AE")]
	public string hotdogTag
	{
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x16AFC80", Offset = "0x16AFC80", VA = "0x16AFC80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60CAC", Offset = "0x60CAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x16AFC88", Offset = "0x16AFC88", VA = "0x16AFC88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60CBC", Offset = "0x60CBC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x16AFC90", Offset = "0x16AFC90", VA = "0x16AFC90")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x16AFEA8", Offset = "0x16AFEA8", VA = "0x16AFEA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x16B0178", Offset = "0x16B0178", VA = "0x16B0178")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x16B01A0", Offset = "0x16B01A0", VA = "0x16B01A0")]
	public bool Collapse(Collision other, Rigidbody targetRigid)
	{
		return default;
	}

	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x16B033C", Offset = "0x16B033C", VA = "0x16B033C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x16B03D8", Offset = "0x16B03D8", VA = "0x16B03D8")]
	public SimpleTargetBehaviour()
	{
	}
}
