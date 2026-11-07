using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200024F")]
public class OlympicGolferShooter : GolfBallShooterBase
{
	[Token(Token = "0x2000250")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E6C4", Offset = "0x3E6C4")]
	private sealed class _003CShootRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x20")]
		public OlympicGolferShooter _003C_003E4__this;

		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x17000145")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x180AA3C", Offset = "0x180AA3C", VA = "0x180AA3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000146")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x180AA84", Offset = "0x180AA84", VA = "0x180AA84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x180A830", Offset = "0x180A830", VA = "0x180A830")]
		[DebuggerHidden]
		public _003CShootRoutine_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x180A85C", Offset = "0x180A85C", VA = "0x180A85C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x180A860", Offset = "0x180A860", VA = "0x180A860", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x180AA3C", Offset = "0x180AA3C", VA = "0x180AA3C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x180AA44", Offset = "0x180AA44", VA = "0x180AA44", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x180AA84", Offset = "0x180AA84", VA = "0x180AA84", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000251")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E6D4", Offset = "0x3E6D4")]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x10")]
		public OlympicGolferShooter _003C_003E4__this;

		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x18")]
		public float from;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x180A4F0", Offset = "0x180A4F0", VA = "0x180A4F0")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x180A4F8", Offset = "0x180A4F8", VA = "0x180A4F8")]
		internal void _003CPlayShootSequence_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000252")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E6E4", Offset = "0x3E6E4")]
	private sealed class _003CPlayShootSequence_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x20")]
		public OlympicGolferShooter _003C_003E4__this;

		[Token(Token = "0x17000147")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x180A7E0", Offset = "0x180A7E0", VA = "0x180A7E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000148")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x180A828", Offset = "0x180A828", VA = "0x180A828", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x180A58C", Offset = "0x180A58C", VA = "0x180A58C")]
		[DebuggerHidden]
		public _003CPlayShootSequence_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x180A5B8", Offset = "0x180A5B8", VA = "0x180A5B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x180A5BC", Offset = "0x180A5BC", VA = "0x180A5BC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x180A7E0", Offset = "0x180A7E0", VA = "0x180A7E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x180A7E8", Offset = "0x180A7E8", VA = "0x180A7E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x180A828", Offset = "0x180A828", VA = "0x180A828", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Animator golfAnimator;

	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool playShootRoutine;

	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Rigidbody hips;

	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PuppetCarLikeController shooter;

	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private PuppetMaster puppet;

	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Animator cameraController;

	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private CinemachineVirtualCamera cinemachineCamera;

	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x98")]
	private CinemachineBasicMultiChannelPerlin cameraShaker;

	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float amplitudeGain;

	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float frequencyGain;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private AudioSource ScreamSource;

	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private float screamVolumeChangeSpeed;

	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private BehaviourPuppet puppetBehaviour;

	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private List<AudioClip> loseBalanceSfx;

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AudioSource loseBalanceSfxSource;

	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float collisionExtraPushForce;

	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float getUpPushRadius;

	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float getUpPushPower;

	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0xDC")]
	private bool hasCollapsed;

	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0xDD")]
	private bool isCollapsing;

	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0xE0")]
	public CBFollow followCamera;

	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 targetBlend;

	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0xF4")]
	private float velRef;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0xF8")]
	private float targetScreamVolume;

	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x100")]
	private string blendParamName;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x108")]
	private Collider[] colliders;

	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private CapsuleCollider collider;

	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private LayerMask extraPushLayers;

	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private float extraPushAreaScaleFactor;

	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x15950BC", Offset = "0x15950BC", VA = "0x15950BC", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x15951B8", Offset = "0x15951B8", VA = "0x15951B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x15952CC", Offset = "0x15952CC", VA = "0x15952CC")]
	public void HandlePuppetLoseBalance()
	{
	}

	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x15953F8", Offset = "0x15953F8", VA = "0x15953F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x159558C", Offset = "0x159558C", VA = "0x159558C", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x15955E4", Offset = "0x15955E4", VA = "0x15955E4", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x1595620", Offset = "0x1595620", VA = "0x1595620", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x1595780", Offset = "0x1595780", VA = "0x1595780")]
	private IEnumerator ShootRoutine(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x1595818", Offset = "0x1595818", VA = "0x1595818")]
	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x159588C", Offset = "0x159588C", VA = "0x159588C")]
	private new void FixedUpdate()
	{
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x1595DCC", Offset = "0x1595DCC", VA = "0x1595DCC")]
	public void GetUpPush()
	{
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x1595F9C", Offset = "0x1595F9C", VA = "0x1595F9C")]
	public OlympicGolferShooter()
	{
	}
}
