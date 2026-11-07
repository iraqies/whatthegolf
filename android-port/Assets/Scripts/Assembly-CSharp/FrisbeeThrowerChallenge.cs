using System;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000451")]
public class FrisbeeThrowerChallenge : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x2000452")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FADC", Offset = "0x3FADC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001797")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__31_0;

		[Token(Token = "0x6001447")]
		[Address(RVA = "0x17A9D04", Offset = "0x17A9D04", VA = "0x17A9D04")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001448")]
		[Address(RVA = "0x17A9D0C", Offset = "0x17A9D0C", VA = "0x17A9D0C")]
		internal void _003COnShoot_003Eb__31_0(float t)
		{
		}
	}

	[Token(Token = "0x2000453")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FAEC", Offset = "0x3FAEC")]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[Token(Token = "0x4001798")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody ball;

		[Token(Token = "0x4001799")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 origScale;

		[Token(Token = "0x400179A")]
		[FieldOffset(Offset = "0x28")]
		public FrisbeeThrowerChallenge _003C_003E4__this;

		[Token(Token = "0x6001449")]
		[Address(RVA = "0x17A9D10", Offset = "0x17A9D10", VA = "0x17A9D10")]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[Token(Token = "0x600144A")]
		[Address(RVA = "0x17A9D18", Offset = "0x17A9D18", VA = "0x17A9D18")]
		internal void _003CGetNewBowlingBall_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0x60")]
	public Animator Animator;

	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0x68")]
	public float SwingRadius;

	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0x6C")]
	public float SwingSpeed;

	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody BowlingBallPrefab;

	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x78")]
	public float SwingDistance;

	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x7C")]
	public float ExtraHoldLength;

	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x80")]
	public float ThrowSpeedBoost;

	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x84")]
	public float BlockTime;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x88")]
	public float SinMod;

	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0x8C")]
	public float CosMod;

	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0x90")]
	public bool RagdollAfterFirstShot;

	[Token(Token = "0x4001783")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 Spin;

	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 Pitch;

	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0xAC")]
	public float AppearTime;

	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0xB0")]
	public float Amplitude;

	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0xB4")]
	public Vector3 from;

	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0xC0")]
	public RandomAudioClips swingClips;

	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0xC8")]
	public float sinusThreshold;

	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0xCC")]
	public float boostThresholdForSwingSounds;

	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0xD0")]
	private float swingAngle;

	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0xD4")]
	private float weightTarget;

	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0xD8")]
	private float weight;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0xDC")]
	private float lastSin;

	[Token(Token = "0x400178F")]
	[FieldOffset(Offset = "0xE0")]
	private int numberOfPins;

	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0xE8")]
	private Rigidbody bowlingBall;

	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 lastBallPosition;

	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0xFC")]
	private Vector3 ballPosition;

	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 ballVelocity;

	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x114")]
	private bool didWin;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x115")]
	private bool _hasShot;

	[Token(Token = "0x600143B")]
	[Address(RVA = "0x14747D8", Offset = "0x14747D8", VA = "0x14747D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600143C")]
	[Address(RVA = "0x1474A54", Offset = "0x1474A54", VA = "0x1474A54", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600143D")]
	[Address(RVA = "0x1474D90", Offset = "0x1474D90", VA = "0x1474D90", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x600143E")]
	[Address(RVA = "0x1474DC0", Offset = "0x1474DC0", VA = "0x1474DC0", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600143F")]
	[Address(RVA = "0x1474F78", Offset = "0x1474F78", VA = "0x1474F78")]
	private void Update()
	{
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0x1474830", Offset = "0x1474830", VA = "0x1474830")]
	private Rigidbody GetNewBowlingBall()
	{
		return null;
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0x147517C", Offset = "0x147517C", VA = "0x147517C")]
	private Vector3 GetBowlingBallPosition()
	{
		return default;
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0x1475244", Offset = "0x1475244", VA = "0x1475244")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6001443")]
	[Address(RVA = "0x14752B8", Offset = "0x14752B8", VA = "0x14752B8")]
	private Vector3 GetIKPositionAtAngle(float angle)
	{
		return default;
	}

	[Token(Token = "0x6001444")]
	[Address(RVA = "0x14753CC", Offset = "0x14753CC", VA = "0x14753CC")]
	public FrisbeeThrowerChallenge()
	{
	}

	[Token(Token = "0x6001445")]
	[Address(RVA = "0x1475450", Offset = "0x1475450", VA = "0x1475450")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6215C", Offset = "0x6215C")]
	private void _003COnShoot_003Eb__31_1()
	{
	}
}
