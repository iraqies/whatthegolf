using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074A")]
public class RopeBoss : MonoBehaviour
{
	[Token(Token = "0x4002685")]
	[FieldOffset(Offset = "0x18")]
	public float MoveSpeed;

	[Token(Token = "0x4002686")]
	[FieldOffset(Offset = "0x1C")]
	public float BobAmount;

	[Token(Token = "0x4002687")]
	[FieldOffset(Offset = "0x20")]
	public float BobSpeed;

	[Token(Token = "0x4002688")]
	[FieldOffset(Offset = "0x24")]
	public float ShakeMagnitudeMod;

	[Token(Token = "0x4002689")]
	[FieldOffset(Offset = "0x28")]
	public List<Transform> Paws;

	[Token(Token = "0x400268A")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	[Token(Token = "0x400268B")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource Source;

	[Token(Token = "0x400268C")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> StepClips;

	[Token(Token = "0x400268D")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioClip> CrashIntoIslandClips;

	[Token(Token = "0x400268E")]
	[FieldOffset(Offset = "0x50")]
	public List<AudioClip> IntroSound;

	[Token(Token = "0x400268F")]
	[FieldOffset(Offset = "0x58")]
	public BossIntro Intro;

	[Token(Token = "0x4002690")]
	[FieldOffset(Offset = "0x60")]
	public float PauseAfterSeconds;

	[Token(Token = "0x4002691")]
	[FieldOffset(Offset = "0x64")]
	public float PauseDuration;

	[Token(Token = "0x4002692")]
	[FieldOffset(Offset = "0x68")]
	public GolfBallController GolfBall;

	[Token(Token = "0x4002693")]
	[FieldOffset(Offset = "0x70")]
	private Rigidbody rigid;

	[Token(Token = "0x4002694")]
	[FieldOffset(Offset = "0x78")]
	private float bobTimer;

	[Token(Token = "0x4002695")]
	[FieldOffset(Offset = "0x7C")]
	private float previousBob;

	[Token(Token = "0x4002696")]
	[FieldOffset(Offset = "0x80")]
	private int lastStepIndex;

	[Token(Token = "0x4002697")]
	[FieldOffset(Offset = "0x84")]
	private float introStopTimer;

	[Token(Token = "0x4002698")]
	[FieldOffset(Offset = "0x88")]
	private bool playerHasShot;

	[Token(Token = "0x6002193")]
	[Address(RVA = "0x165E0DC", Offset = "0x165E0DC", VA = "0x165E0DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002194")]
	[Address(RVA = "0x165E210", Offset = "0x165E210", VA = "0x165E210")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002195")]
	[Address(RVA = "0x165E4D8", Offset = "0x165E4D8", VA = "0x165E4D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6002196")]
	[Address(RVA = "0x165E630", Offset = "0x165E630", VA = "0x165E630")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002197")]
	[Address(RVA = "0x165E91C", Offset = "0x165E91C", VA = "0x165E91C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002198")]
	[Address(RVA = "0x165E9D0", Offset = "0x165E9D0", VA = "0x165E9D0")]
	public RopeBoss()
	{
	}

	[Token(Token = "0x6002199")]
	[Address(RVA = "0x165E9F4", Offset = "0x165E9F4", VA = "0x165E9F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65CB0", Offset = "0x65CB0")]
	private void _003CStart_003Eb__20_0(Vector3 v)
	{
	}

	[Token(Token = "0x600219A")]
	[Address(RVA = "0x165EA00", Offset = "0x165EA00", VA = "0x165EA00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65CC0", Offset = "0x65CC0")]
	private void _003COnTriggerEnter_003Eb__23_0(AudioSource t)
	{
	}
}
