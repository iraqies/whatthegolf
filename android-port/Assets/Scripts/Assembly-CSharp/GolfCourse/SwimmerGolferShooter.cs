using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Buoyancy;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	[Token(Token = "0x2001204")]
	public class SwimmerGolferShooter : GolfBallShooterBase
	{
		[Token(Token = "0x2001205")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48474", Offset = "0x48474")]
		private sealed class _003CShootRoutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006141")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006142")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006143")]
			[FieldOffset(Offset = "0x20")]
			public SwimmerGolferShooter _003C_003E4__this;

			[Token(Token = "0x4006144")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 boost;

			[Token(Token = "0x4006145")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 _003CpitchedBoost_003E5__2;

			[Token(Token = "0x4006146")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 _003Cright_003E5__3;

			[Token(Token = "0x1700091E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60052E0")]
				[Address(RVA = "0x185FAC4", Offset = "0x185FAC4", VA = "0x185FAC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700091F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60052E2")]
				[Address(RVA = "0x185FB0C", Offset = "0x185FB0C", VA = "0x185FB0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60052DD")]
			[Address(RVA = "0x185F66C", Offset = "0x185F66C", VA = "0x185F66C")]
			[DebuggerHidden]
			public _003CShootRoutine_003Ed__52(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60052DE")]
			[Address(RVA = "0x185F698", Offset = "0x185F698", VA = "0x185F698", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60052DF")]
			[Address(RVA = "0x185F69C", Offset = "0x185F69C", VA = "0x185F69C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60052E0")]
			[Address(RVA = "0x185FAC4", Offset = "0x185FAC4", VA = "0x185FAC4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60052E1")]
			[Address(RVA = "0x185FACC", Offset = "0x185FACC", VA = "0x185FACC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60052E2")]
			[Address(RVA = "0x185FB0C", Offset = "0x185FB0C", VA = "0x185FB0C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001206")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48484", Offset = "0x48484")]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			[Token(Token = "0x4006147")]
			[FieldOffset(Offset = "0x10")]
			public SwimmerGolferShooter _003C_003E4__this;

			[Token(Token = "0x4006148")]
			[FieldOffset(Offset = "0x18")]
			public float from;

			[Token(Token = "0x60052E3")]
			[Address(RVA = "0x185F2A4", Offset = "0x185F2A4", VA = "0x185F2A4")]
			public _003C_003Ec__DisplayClass55_0()
			{
			}

			[Token(Token = "0x60052E4")]
			[Address(RVA = "0x185F2AC", Offset = "0x185F2AC", VA = "0x185F2AC")]
			internal void _003CPlayShootSequence_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x2001207")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48494", Offset = "0x48494")]
		private sealed class _003CPlayShootSequence_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006149")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400614A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400614B")]
			[FieldOffset(Offset = "0x20")]
			public SwimmerGolferShooter _003C_003E4__this;

			[Token(Token = "0x17000920")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60052E8")]
				[Address(RVA = "0x185F61C", Offset = "0x185F61C", VA = "0x185F61C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000921")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60052EA")]
				[Address(RVA = "0x185F664", Offset = "0x185F664", VA = "0x185F664", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60052E5")]
			[Address(RVA = "0x185F340", Offset = "0x185F340", VA = "0x185F340")]
			[DebuggerHidden]
			public _003CPlayShootSequence_003Ed__55(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60052E6")]
			[Address(RVA = "0x185F36C", Offset = "0x185F36C", VA = "0x185F36C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60052E7")]
			[Address(RVA = "0x185F370", Offset = "0x185F370", VA = "0x185F370", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60052E8")]
			[Address(RVA = "0x185F61C", Offset = "0x185F61C", VA = "0x185F61C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60052E9")]
			[Address(RVA = "0x185F624", Offset = "0x185F624", VA = "0x185F624", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60052EA")]
			[Address(RVA = "0x185F664", Offset = "0x185F664", VA = "0x185F664", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006115")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool extraForceOnFirstSkip;

		[Token(Token = "0x4006116")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool onlyAfterFirstShot;

		[Token(Token = "0x4006117")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float firstSkipExtraYVelocity;

		[Token(Token = "0x4006118")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float firstSkipExtraXZVelocity;

		[Token(Token = "0x4006119")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool customForceOnFirstShot;

		[Token(Token = "0x400611A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float firstShotVelocity;

		[Token(Token = "0x400611B")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float firstShotPitch;

		[Token(Token = "0x400611C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float minVelocity;

		[Token(Token = "0x400611D")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float fullVelocity;

		[Token(Token = "0x400611E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float fullPitch;

		[Token(Token = "0x400611F")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float swimmingPitchMultiplier;

		[Token(Token = "0x4006120")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float swimmingVelocityMultiplier;

		[Token(Token = "0x4006121")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float fullSpin;

		[Token(Token = "0x4006122")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4006123")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Rigidbody GolfClub;

		[Token(Token = "0x4006124")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Animator golfAnimator;

		[Token(Token = "0x4006125")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private BuoyancyTarget buoyancyTarget;

		[Token(Token = "0x4006126")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UnityEvent OnCollapse;

		[Token(Token = "0x4006127")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool CollapseAtStart;

		[Token(Token = "0x4006128")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform ClubRoot;

		[Token(Token = "0x4006129")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool playShootRoutine;

		[Token(Token = "0x400612A")]
		[FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool doFullReset;

		[Token(Token = "0x400612B")]
		[FieldOffset(Offset = "0xD0")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400612C")]
		[FieldOffset(Offset = "0xD8")]
		private Rigidbody hips;

		[Token(Token = "0x400612D")]
		[FieldOffset(Offset = "0xE0")]
		private Rigidbody head;

		[Token(Token = "0x400612E")]
		[FieldOffset(Offset = "0xE8")]
		private Rigidbody leftFoot;

		[Token(Token = "0x400612F")]
		[FieldOffset(Offset = "0xF0")]
		private Rigidbody rightFoot;

		[Token(Token = "0x4006130")]
		[FieldOffset(Offset = "0xF8")]
		private GolfBallController controller;

		[Token(Token = "0x4006131")]
		[FieldOffset(Offset = "0x100")]
		private Vector3 lastBoost;

		[Token(Token = "0x4006132")]
		[FieldOffset(Offset = "0x10C")]
		private bool hasCollapsed;

		[Token(Token = "0x4006133")]
		[FieldOffset(Offset = "0x10D")]
		private bool isCollapsing;

		[Token(Token = "0x4006134")]
		[FieldOffset(Offset = "0x110")]
		private Vector3 oldPosition;

		[Token(Token = "0x4006135")]
		[FieldOffset(Offset = "0x11C")]
		private Quaternion oldRotation;

		[Token(Token = "0x4006136")]
		[FieldOffset(Offset = "0x130")]
		public CBFollow followCamera;

		[Token(Token = "0x4006137")]
		[FieldOffset(Offset = "0x138")]
		private Vector3 targetBlend;

		[Token(Token = "0x4006138")]
		[FieldOffset(Offset = "0x144")]
		private float velRef;

		[Token(Token = "0x4006139")]
		[FieldOffset(Offset = "0x148")]
		private int skipCountAfterShot;

		[Token(Token = "0x400613A")]
		[FieldOffset(Offset = "0x14C")]
		private int shotCount;

		[Token(Token = "0x400613B")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 baseClubLocalPosition;

		[Token(Token = "0x400613C")]
		[FieldOffset(Offset = "0x15C")]
		private Quaternion baseClubLocalRotation;

		[Token(Token = "0x400613D")]
		[FieldOffset(Offset = "0x170")]
		private Transform baseClubParent;

		[Token(Token = "0x400613E")]
		[FieldOffset(Offset = "0x178")]
		private Transform baseArrowFollow;

		[Token(Token = "0x400613F")]
		[FieldOffset(Offset = "0x180")]
		public float lookDirectionForce;

		[Token(Token = "0x4006140")]
		[FieldOffset(Offset = "0x184")]
		public float feetForceMultiplier;

		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x16EFD30", Offset = "0x16EFD30", VA = "0x16EFD30", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x16F0148", Offset = "0x16F0148", VA = "0x16F0148")]
		private void BuoyancyTarget_OnPostSkip(Vector3 obj)
		{
		}

		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x16F0240", Offset = "0x16F0240", VA = "0x16F0240")]
		private void Start()
		{
		}

		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x16F0388", Offset = "0x16F0388", VA = "0x16F0388")]
		private void Update()
		{
		}

		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x16F0520", Offset = "0x16F0520", VA = "0x16F0520", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x16F06E4", Offset = "0x16F06E4", VA = "0x16F06E4", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x16F074C", Offset = "0x16F074C", VA = "0x16F074C", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x16F078C", Offset = "0x16F078C", VA = "0x16F078C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x60052D8")]
		[Address(RVA = "0x16F0BF0", Offset = "0x16F0BF0", VA = "0x16F0BF0")]
		private IEnumerator ShootRoutine(Vector3 boost)
		{
			return null;
		}

		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x16F0D90", Offset = "0x16F0D90", VA = "0x16F0D90", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x16F0C88", Offset = "0x16F0C88", VA = "0x16F0C88")]
		private Vector3 PitchBoost(Vector3 boost, bool first = false)
		{
			return default;
		}

		[Token(Token = "0x60052DB")]
		[Address(RVA = "0x16F0FDC", Offset = "0x16F0FDC", VA = "0x16F0FDC")]
		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			return null;
		}

		[Token(Token = "0x60052DC")]
		[Address(RVA = "0x16F1050", Offset = "0x16F1050", VA = "0x16F1050")]
		public SwimmerGolferShooter()
		{
		}
	}
}
