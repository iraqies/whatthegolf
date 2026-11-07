using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20002E7")]
public class PuppetControllerWithShoot : UserControlThirdPerson
{
	[Token(Token = "0x20002E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED3C", Offset = "0x3ED3C")]
	private sealed class _003CActionAfter_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x28")]
		public Action a;

		[Token(Token = "0x17000198")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D6C")]
			[Address(RVA = "0x182F050", Offset = "0x182F050", VA = "0x182F050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000199")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x182F098", Offset = "0x182F098", VA = "0x182F098", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x182EF64", Offset = "0x182EF64", VA = "0x182EF64")]
		[DebuggerHidden]
		public _003CActionAfter_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x182EF90", Offset = "0x182EF90", VA = "0x182EF90", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x182EF94", Offset = "0x182EF94", VA = "0x182EF94", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x182F050", Offset = "0x182F050", VA = "0x182F050", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x182F058", Offset = "0x182F058", VA = "0x182F058", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x182F098", Offset = "0x182F098", VA = "0x182F098", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20002E9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED4C", Offset = "0x3ED4C")]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody ball;

		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 origScale;

		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x28")]
		public PuppetControllerWithShoot _003C_003E4__this;

		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x182EEA8", Offset = "0x182EEA8", VA = "0x182EEA8")]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x182EEB0", Offset = "0x182EEB0", VA = "0x182EEB0")]
		internal void _003CGetNewThrowable_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool CanJump;

	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GolfBallController Controller;

	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float JumpTime;

	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private CharacterPuppet m_CharacterPuppet;

	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float BlockTime;

	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AnimationCurve AnimSpeedMultiplierCurve;

	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private CharacterAnimationThirdPerson characterAnimation;

	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 AimDirection;

	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x94")]
	private float JumpTimer;

	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x98")]
	private float BlockTimer;

	[Token(Token = "0x4000FF7")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Animator m_Animator;

	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private PuppetMaster m_PuppetMaster;

	[Token(Token = "0x4000FF9")]
	private const string animParamIsGolfSwinging = "IsGolfSwinging";

	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0xB0")]
	private bool Shooting;

	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Rigidbody Root;

	[Token(Token = "0x4000FFC")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Rigidbody ThrowablePrefab;

	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private float ThrowSpeedBoost;

	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private float ExplosionForce;

	[Token(Token = "0x4000FFF")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Vector3 AdditionalShootForce;

	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Transform BallShootPosition;

	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Transform BallAimPosition;

	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private float PunchEasingAmplitude;

	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	private Vector3 EndScaleOfThrowable;

	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Vector2 DisappearTime;

	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private List<SnowBallTargetBehaviour> Targets;

	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x110")]
	private int CollapsedTargets;

	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	private int TargetsToHit;

	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x118")]
	private Rigidbody ThrowablePrefabInstance;

	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BDAC", Offset = "0x4BDAC")]
	private bool HasBeenShooting__BackingField;

	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0x121")]
	private bool isDead;

	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0x122")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BDBC", Offset = "0x4BDBC")]
	private bool HasShoot__BackingField;

	[Token(Token = "0x17000196")]
	public bool HasBeenShooting
	{
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x162A690", Offset = "0x162A690", VA = "0x162A690")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x608AC", Offset = "0x608AC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x162A698", Offset = "0x162A698", VA = "0x162A698")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x608BC", Offset = "0x608BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000197")]
	public bool HasShoot
	{
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x162A6A0", Offset = "0x162A6A0", VA = "0x162A6A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x608CC", Offset = "0x608CC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x162A6A8", Offset = "0x162A6A8", VA = "0x162A6A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x608DC", Offset = "0x608DC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x162A6B0", Offset = "0x162A6B0", VA = "0x162A6B0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x162A898", Offset = "0x162A898", VA = "0x162A898")]
	public void SwapToShooting()
	{
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x162AA94", Offset = "0x162AA94", VA = "0x162AA94")]
	private IEnumerator ActionAfter(Action a, float delay)
	{
		return null;
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x162AB18", Offset = "0x162AB18", VA = "0x162AB18")]
	private void OnTargetCollapsed(SnowBallTargetBehaviour target)
	{
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x162ADE0", Offset = "0x162ADE0", VA = "0x162ADE0")]
	private void OnTriggerEnter(Collider collision)
	{
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x162ACC8", Offset = "0x162ACC8", VA = "0x162ACC8")]
	public void SwapToRunning()
	{
	}

	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x162B18C", Offset = "0x162B18C", VA = "0x162B18C")]
	public void OnAimStart()
	{
	}

	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x162B228", Offset = "0x162B228", VA = "0x162B228")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x162B414", Offset = "0x162B414", VA = "0x162B414")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x162B4F8", Offset = "0x162B4F8", VA = "0x162B4F8")]
	public void Kill()
	{
	}

	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x162B67C", Offset = "0x162B67C", VA = "0x162B67C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x162AEF4", Offset = "0x162AEF4", VA = "0x162AEF4")]
	private void GetNewThrowable()
	{
	}

	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x162BA34", Offset = "0x162BA34", VA = "0x162BA34")]
	public PuppetControllerWithShoot()
	{
	}

	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x162BAA0", Offset = "0x162BAA0", VA = "0x162BAA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x608EC", Offset = "0x608EC")]
	private void _003CSwapToShooting_003Eb__39_0()
	{
	}

	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x162BAA4", Offset = "0x162BAA4", VA = "0x162BAA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x608FC", Offset = "0x608FC")]
	private void _003CSwapToShooting_003Eb__39_1(SnowBallTargetBehaviour t)
	{
	}
}
