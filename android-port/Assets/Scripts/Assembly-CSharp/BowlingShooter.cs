using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FF")]
public class BowlingShooter : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x2000600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40940", Offset = "0x40940")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Rigidbody> _003C_003E9__50_0;

		[Token(Token = "0x4001EEE")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__52_0;

		[Token(Token = "0x4001EEF")]
		[FieldOffset(Offset = "0x18")]
		public static Action<float> _003C_003E9__60_0;

		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x177B470", Offset = "0x177B470", VA = "0x177B470")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x177B478", Offset = "0x177B478", VA = "0x177B478")]
		internal bool _003CStart_003Eb__50_0(Rigidbody p)
		{
			return default;
		}

		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x177B4AC", Offset = "0x177B4AC", VA = "0x177B4AC")]
		internal void _003COnShoot_003Eb__52_0(float t)
		{
		}

		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x177B4B0", Offset = "0x177B4B0", VA = "0x177B4B0")]
		internal void _003CRemovePin_003Eb__60_0(float t)
		{
		}
	}

	[Token(Token = "0x2000601")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40950", Offset = "0x40950")]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		[Token(Token = "0x4001EF0")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody ball;

		[Token(Token = "0x4001EF1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 origScale;

		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x28")]
		public BowlingShooter _003C_003E4__this;

		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x177B4B4", Offset = "0x177B4B4", VA = "0x177B4B4")]
		public _003C_003Ec__DisplayClass56_0()
		{
		}

		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x177B4BC", Offset = "0x177B4BC", VA = "0x177B4BC")]
		internal void _003CGetNewBowlingBall_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000602")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40960", Offset = "0x40960")]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody pin;

		[Token(Token = "0x4001EF4")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x177B5F8", Offset = "0x177B5F8", VA = "0x177B5F8")]
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x177B600", Offset = "0x177B600", VA = "0x177B600")]
		internal void _003CRemovePin_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x177B6B0", Offset = "0x177B6B0", VA = "0x177B6B0")]
		internal void _003CRemovePin_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000603")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40970", Offset = "0x40970")]
	private sealed class _003CEvaluateShotSplit_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EF5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EF6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EF7")]
		[FieldOffset(Offset = "0x20")]
		public BowlingShooter _003C_003E4__this;

		[Token(Token = "0x4001EF8")]
		[FieldOffset(Offset = "0x28")]
		private int _003CtippedOverPins_003E5__2;

		[Token(Token = "0x4001EF9")]
		[FieldOffset(Offset = "0x2C")]
		private int _003CpinsChecked_003E5__3;

		[Token(Token = "0x4001EFA")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x170002FD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x177B8C4", Offset = "0x177B8C4", VA = "0x177B8C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002FE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B6E")]
			[Address(RVA = "0x177B90C", Offset = "0x177B90C", VA = "0x177B90C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x177B730", Offset = "0x177B730", VA = "0x177B730")]
		[DebuggerHidden]
		public _003CEvaluateShotSplit_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x177B75C", Offset = "0x177B75C", VA = "0x177B75C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x177B760", Offset = "0x177B760", VA = "0x177B760", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x177B8C4", Offset = "0x177B8C4", VA = "0x177B8C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x177B8CC", Offset = "0x177B8CC", VA = "0x177B8CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x177B90C", Offset = "0x177B90C", VA = "0x177B90C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001EC0")]
	[FieldOffset(Offset = "0x60")]
	public Animator Animator;

	[Token(Token = "0x4001EC1")]
	[FieldOffset(Offset = "0x68")]
	public float SwingRadius;

	[Token(Token = "0x4001EC2")]
	[FieldOffset(Offset = "0x6C")]
	public float SwingSpeed;

	[Token(Token = "0x4001EC3")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody BowlingBallPrefab;

	[Token(Token = "0x4001EC4")]
	[FieldOffset(Offset = "0x78")]
	public float SwingDistance;

	[Token(Token = "0x4001EC5")]
	[FieldOffset(Offset = "0x7C")]
	public float ExtraHoldLength;

	[Token(Token = "0x4001EC6")]
	[FieldOffset(Offset = "0x80")]
	public float ThrowSpeedBoost;

	[Token(Token = "0x4001EC7")]
	[FieldOffset(Offset = "0x84")]
	public float BlockTime;

	[Token(Token = "0x4001EC8")]
	[FieldOffset(Offset = "0x88")]
	public bool RagdollAfterFirstShot;

	[Token(Token = "0x4001EC9")]
	[FieldOffset(Offset = "0x90")]
	public GolfCoursePinGoal PinGoal;

	[Token(Token = "0x4001ECA")]
	[FieldOffset(Offset = "0x98")]
	public bool WinWhenAllPinsAreKnockedOver;

	[Token(Token = "0x4001ECB")]
	[FieldOffset(Offset = "0x99")]
	public bool UseCustomWinText;

	[Token(Token = "0x4001ECC")]
	[FieldOffset(Offset = "0xA0")]
	public List<Rigidbody> Pins;

	[Token(Token = "0x4001ECD")]
	[FieldOffset(Offset = "0xA8")]
	public int PinsLeftToStillWin;

	[Token(Token = "0x4001ECE")]
	[FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E38C", Offset = "0x4E38C")]
	public float TippedOverThreshold;

	[Token(Token = "0x4001ECF")]
	[FieldOffset(Offset = "0xB0")]
	public Collider ColliderUp;

	[Token(Token = "0x4001ED0")]
	[FieldOffset(Offset = "0xB8")]
	public float TimeBetweenEvaluation;

	[Token(Token = "0x4001ED1")]
	[FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E3A4", Offset = "0x4E3A4")]
	public float EvaluationSplit;

	[Token(Token = "0x4001ED2")]
	[FieldOffset(Offset = "0xC0")]
	public bool AlwaysShootInBoostDirection;

	[Token(Token = "0x4001ED3")]
	[FieldOffset(Offset = "0xC4")]
	public Vector3 AdditionalShootForce;

	[Token(Token = "0x4001ED4")]
	[FieldOffset(Offset = "0xD0")]
	public Transform BallShootPosition;

	[Token(Token = "0x4001ED5")]
	[FieldOffset(Offset = "0xD8")]
	public float AppearTime;

	[Token(Token = "0x4001ED6")]
	[FieldOffset(Offset = "0xDC")]
	public float Amplitude;

	[Token(Token = "0x4001ED7")]
	[FieldOffset(Offset = "0xE0")]
	public Vector3 from;

	[Token(Token = "0x4001ED8")]
	[FieldOffset(Offset = "0xEC")]
	public Vector2 DisappearTime;

	[Token(Token = "0x4001ED9")]
	[FieldOffset(Offset = "0xF4")]
	public bool isOverwritingWinText;

	[Token(Token = "0x4001EDA")]
	[FieldOffset(Offset = "0xF8")]
	public RandomAudioClips swingClips;

	[Token(Token = "0x4001EDB")]
	[FieldOffset(Offset = "0x100")]
	public float sinusThreshold;

	[Token(Token = "0x4001EDC")]
	[FieldOffset(Offset = "0x104")]
	public float boostThresholdForSwingSounds;

	[Token(Token = "0x4001EDD")]
	[FieldOffset(Offset = "0x108")]
	public Action<Rigidbody> OnBallShot;

	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0x110")]
	public Action<GameObject> BallThrown;

	[Token(Token = "0x4001EDF")]
	[FieldOffset(Offset = "0x118")]
	private float lastSin;

	[Token(Token = "0x4001EE0")]
	[FieldOffset(Offset = "0x11C")]
	private float swingAngle;

	[Token(Token = "0x4001EE1")]
	[FieldOffset(Offset = "0x120")]
	private float weightTarget;

	[Token(Token = "0x4001EE2")]
	[FieldOffset(Offset = "0x124")]
	private float weight;

	[Token(Token = "0x4001EE3")]
	[FieldOffset(Offset = "0x128")]
	private int numberOfShots;

	[Token(Token = "0x4001EE4")]
	[FieldOffset(Offset = "0x12C")]
	private int numberOfPins;

	[Token(Token = "0x4001EE5")]
	[FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E3BC", Offset = "0x4E3BC")]
	private Rigidbody bowlingBall__BackingField;

	[Token(Token = "0x4001EE6")]
	[FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E3CC", Offset = "0x4E3CC")]
	private Vector3 lastBallPosition__BackingField;

	[Token(Token = "0x4001EE7")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 ballPosition;

	[Token(Token = "0x4001EE8")]
	[FieldOffset(Offset = "0x150")]
	private Vector3 ballVelocity;

	[Token(Token = "0x4001EE9")]
	[FieldOffset(Offset = "0x15C")]
	private bool didWin;

	[Token(Token = "0x4001EEA")]
	[FieldOffset(Offset = "0x160")]
	private float evaluateTimer;

	[Token(Token = "0x4001EEB")]
	[FieldOffset(Offset = "0x164")]
	private bool routineRunning;

	[Token(Token = "0x170002FB")]
	public Rigidbody bowlingBall
	{
		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x1703DA8", Offset = "0x1703DA8", VA = "0x1703DA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63B1C", Offset = "0x63B1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x1703DB0", Offset = "0x1703DB0", VA = "0x1703DB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63B2C", Offset = "0x63B2C")]
		private set
		{
		}
	}

	[Token(Token = "0x170002FC")]
	public Vector3 lastBallPosition
	{
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x1703DB8", Offset = "0x1703DB8", VA = "0x1703DB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63B3C", Offset = "0x63B3C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x1703DC8", Offset = "0x1703DC8", VA = "0x1703DC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63B4C", Offset = "0x63B4C")]
		private set
		{
		}
	}

	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x1703DD8", Offset = "0x1703DD8", VA = "0x1703DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x1704228", Offset = "0x1704228", VA = "0x1704228")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x17042DC", Offset = "0x17042DC", VA = "0x17042DC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x1704794", Offset = "0x1704794", VA = "0x1704794", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x170483C", Offset = "0x170483C", VA = "0x170483C", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x17049D4", Offset = "0x17049D4", VA = "0x17049D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x1703FCC", Offset = "0x1703FCC", VA = "0x1703FCC")]
	private Rigidbody GetNewBowlingBall()
	{
		return null;
	}

	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x1704C78", Offset = "0x1704C78", VA = "0x1704C78")]
	private Vector3 GetBowlingBallPosition()
	{
		return default;
	}

	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x1704DB4", Offset = "0x1704DB4", VA = "0x1704DB4")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x1704E20", Offset = "0x1704E20", VA = "0x1704E20")]
	private Vector3 GetIKPositionAtAngle(float angle)
	{
		return default;
	}

	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x1704F18", Offset = "0x1704F18", VA = "0x1704F18")]
	private void RemovePin(Rigidbody pin)
	{
	}

	[Token(Token = "0x6001B59")]
	[Address(RVA = "0x1704D40", Offset = "0x1704D40", VA = "0x1704D40")]
	public IEnumerator EvaluateShotSplit()
	{
		return null;
	}

	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x17031D4", Offset = "0x17031D4", VA = "0x17031D4")]
	public void EvaluateShot()
	{
	}

	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x170528C", Offset = "0x170528C", VA = "0x170528C")]
	private bool CheckPin(Rigidbody pin)
	{
		return default;
	}

	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x1705524", Offset = "0x1705524", VA = "0x1705524")]
	private void CheckIfWon(int tippedOverPins)
	{
	}

	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x17056EC", Offset = "0x17056EC", VA = "0x17056EC")]
	public BowlingShooter()
	{
	}

	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x1705798", Offset = "0x1705798", VA = "0x1705798")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63B5C", Offset = "0x63B5C")]
	private void _003COnShoot_003Eb__52_1()
	{
	}
}
