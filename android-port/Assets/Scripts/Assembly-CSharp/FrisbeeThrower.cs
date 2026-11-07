using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000607")]
public class FrisbeeThrower : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x2000608")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x409A0", Offset = "0x409A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001F25")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001F26")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__35_0;

		[Token(Token = "0x4001F27")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__43_0;

		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x17A9AA0", Offset = "0x17A9AA0", VA = "0x17A9AA0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x17A9AA8", Offset = "0x17A9AA8", VA = "0x17A9AA8")]
		internal void _003COnShoot_003Eb__35_0(float t)
		{
		}

		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x17A9AAC", Offset = "0x17A9AAC", VA = "0x17A9AAC")]
		internal void _003CRemovePin_003Eb__43_0(float t)
		{
		}
	}

	[Token(Token = "0x2000609")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x409B0", Offset = "0x409B0")]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x4001F28")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody ball;

		[Token(Token = "0x4001F29")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 origScale;

		[Token(Token = "0x4001F2A")]
		[FieldOffset(Offset = "0x28")]
		public FrisbeeThrower _003C_003E4__this;

		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x17A9AB0", Offset = "0x17A9AB0", VA = "0x17A9AB0")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x17A9AB8", Offset = "0x17A9AB8", VA = "0x17A9AB8")]
		internal void _003CGetNewBowlingBall_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200060A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x409C0", Offset = "0x409C0")]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x4001F2B")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody pin;

		[Token(Token = "0x4001F2C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x17A9B6C", Offset = "0x17A9B6C", VA = "0x17A9B6C")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x17A9B74", Offset = "0x17A9B74", VA = "0x17A9B74")]
		internal void _003CRemovePin_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x17A9C24", Offset = "0x17A9C24", VA = "0x17A9C24")]
		internal void _003CRemovePin_003Eb__2()
		{
		}
	}

	[Token(Token = "0x4001F03")]
	[FieldOffset(Offset = "0x60")]
	public Animator Animator;

	[Token(Token = "0x4001F04")]
	[FieldOffset(Offset = "0x68")]
	public float SwingRadius;

	[Token(Token = "0x4001F05")]
	[FieldOffset(Offset = "0x6C")]
	public float SwingSpeed;

	[Token(Token = "0x4001F06")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody BowlingBallPrefab;

	[Token(Token = "0x4001F07")]
	[FieldOffset(Offset = "0x78")]
	public float SwingDistance;

	[Token(Token = "0x4001F08")]
	[FieldOffset(Offset = "0x7C")]
	public float ExtraHoldLength;

	[Token(Token = "0x4001F09")]
	[FieldOffset(Offset = "0x80")]
	public float ThrowSpeedBoost;

	[Token(Token = "0x4001F0A")]
	[FieldOffset(Offset = "0x84")]
	public float BlockTime;

	[Token(Token = "0x4001F0B")]
	[FieldOffset(Offset = "0x88")]
	public float SinMod;

	[Token(Token = "0x4001F0C")]
	[FieldOffset(Offset = "0x8C")]
	public float CosMod;

	[Token(Token = "0x4001F0D")]
	[FieldOffset(Offset = "0x90")]
	public bool RagdollAfterFirstShot;

	[Token(Token = "0x4001F0E")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 Spin;

	[Token(Token = "0x4001F0F")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 Pitch;

	[Token(Token = "0x4001F10")]
	[FieldOffset(Offset = "0xB0")]
	public List<Rigidbody> Pins;

	[Token(Token = "0x4001F11")]
	[FieldOffset(Offset = "0xB8")]
	public int PinsLeftToStillWin;

	[Token(Token = "0x4001F12")]
	[FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E3F4", Offset = "0x4E3F4")]
	public float TippedOverThreshold;

	[Token(Token = "0x4001F13")]
	[FieldOffset(Offset = "0xC0")]
	public Collider ColliderUp;

	[Token(Token = "0x4001F14")]
	[FieldOffset(Offset = "0xC8")]
	public float AppearTime;

	[Token(Token = "0x4001F15")]
	[FieldOffset(Offset = "0xCC")]
	public float Amplitude;

	[Token(Token = "0x4001F16")]
	[FieldOffset(Offset = "0xD0")]
	public Vector3 from;

	[Token(Token = "0x4001F17")]
	[FieldOffset(Offset = "0xE0")]
	public RandomAudioClips swingClips;

	[Token(Token = "0x4001F18")]
	[FieldOffset(Offset = "0xE8")]
	public float sinusThreshold;

	[Token(Token = "0x4001F19")]
	[FieldOffset(Offset = "0xEC")]
	public float boostThresholdForSwingSounds;

	[Token(Token = "0x4001F1A")]
	[FieldOffset(Offset = "0xF0")]
	private float swingAngle;

	[Token(Token = "0x4001F1B")]
	[FieldOffset(Offset = "0xF4")]
	private float weightTarget;

	[Token(Token = "0x4001F1C")]
	[FieldOffset(Offset = "0xF8")]
	private float weight;

	[Token(Token = "0x4001F1D")]
	[FieldOffset(Offset = "0xFC")]
	private float lastSin;

	[Token(Token = "0x4001F1E")]
	[FieldOffset(Offset = "0x100")]
	private int numberOfShots;

	[Token(Token = "0x4001F1F")]
	[FieldOffset(Offset = "0x104")]
	private int numberOfPins;

	[Token(Token = "0x4001F20")]
	[FieldOffset(Offset = "0x108")]
	private Rigidbody bowlingBall;

	[Token(Token = "0x4001F21")]
	[FieldOffset(Offset = "0x110")]
	private Vector3 lastBallPosition;

	[Token(Token = "0x4001F22")]
	[FieldOffset(Offset = "0x11C")]
	private Vector3 ballPosition;

	[Token(Token = "0x4001F23")]
	[FieldOffset(Offset = "0x128")]
	private Vector3 ballVelocity;

	[Token(Token = "0x4001F24")]
	[FieldOffset(Offset = "0x134")]
	private bool didWin;

	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x14734CC", Offset = "0x14734CC", VA = "0x14734CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x1473784", Offset = "0x1473784", VA = "0x1473784", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001B7B")]
	[Address(RVA = "0x1473AEC", Offset = "0x1473AEC", VA = "0x1473AEC", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6001B7C")]
	[Address(RVA = "0x1473B18", Offset = "0x1473B18", VA = "0x1473B18", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x1473CD0", Offset = "0x1473CD0", VA = "0x1473CD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x1473560", Offset = "0x1473560", VA = "0x1473560")]
	private Rigidbody GetNewBowlingBall()
	{
		return null;
	}

	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x1473ECC", Offset = "0x1473ECC", VA = "0x1473ECC")]
	private Vector3 GetBowlingBallPosition()
	{
		return default;
	}

	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x14742D8", Offset = "0x14742D8", VA = "0x14742D8")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x147434C", Offset = "0x147434C", VA = "0x147434C")]
	private Vector3 GetIKPositionAtAngle(float angle)
	{
		return default;
	}

	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x1474460", Offset = "0x1474460", VA = "0x1474460")]
	private void RemovePin(Rigidbody pin)
	{
	}

	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x1473F94", Offset = "0x1473F94", VA = "0x1473F94")]
	public void EvaluateShot()
	{
	}

	[Token(Token = "0x6001B84")]
	[Address(RVA = "0x1474724", Offset = "0x1474724", VA = "0x1474724")]
	public FrisbeeThrower()
	{
	}

	[Token(Token = "0x6001B85")]
	[Address(RVA = "0x14747B4", Offset = "0x14747B4", VA = "0x14747B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63BBC", Offset = "0x63BBC")]
	private void _003COnShoot_003Eb__35_1()
	{
	}
}
