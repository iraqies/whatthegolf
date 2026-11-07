using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	[Token(Token = "0x200120D")]
	public class GolferShooter : GolfBallShooterBase
	{
		[Token(Token = "0x200120E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484D4", Offset = "0x484D4")]
		private sealed class _003CShootRoutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006188")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006189")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400618A")]
			[FieldOffset(Offset = "0x20")]
			public GolferShooter _003C_003E4__this;

			[Token(Token = "0x400618B")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 boost;

			[Token(Token = "0x400618C")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 _003CpitchedBoost_003E5__2;

			[Token(Token = "0x400618D")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 _003Cright_003E5__3;

			[Token(Token = "0x17000922")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005311")]
				[Address(RVA = "0x17B6BD8", Offset = "0x17B6BD8", VA = "0x17B6BD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000923")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005313")]
				[Address(RVA = "0x17B6C20", Offset = "0x17B6C20", VA = "0x17B6C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600530E")]
			[Address(RVA = "0x17B67E8", Offset = "0x17B67E8", VA = "0x17B67E8")]
			[DebuggerHidden]
			public _003CShootRoutine_003Ed__34(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600530F")]
			[Address(RVA = "0x17B6814", Offset = "0x17B6814", VA = "0x17B6814", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005310")]
			[Address(RVA = "0x17B6818", Offset = "0x17B6818", VA = "0x17B6818", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005311")]
			[Address(RVA = "0x17B6BD8", Offset = "0x17B6BD8", VA = "0x17B6BD8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005312")]
			[Address(RVA = "0x17B6BE0", Offset = "0x17B6BE0", VA = "0x17B6BE0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005313")]
			[Address(RVA = "0x17B6C20", Offset = "0x17B6C20", VA = "0x17B6C20", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200120F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484E4", Offset = "0x484E4")]
		private sealed class _003C_003Ec__DisplayClass38_0
		{
			[Token(Token = "0x400618E")]
			[FieldOffset(Offset = "0x10")]
			public GolferShooter _003C_003E4__this;

			[Token(Token = "0x400618F")]
			[FieldOffset(Offset = "0x18")]
			public float from;

			[Token(Token = "0x6005314")]
			[Address(RVA = "0x17B642C", Offset = "0x17B642C", VA = "0x17B642C")]
			public _003C_003Ec__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6005315")]
			[Address(RVA = "0x17B6434", Offset = "0x17B6434", VA = "0x17B6434")]
			internal void _003CPlayShootSequence_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x2001210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484F4", Offset = "0x484F4")]
		private sealed class _003CPlayShootSequence_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006190")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006191")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006192")]
			[FieldOffset(Offset = "0x20")]
			public GolferShooter _003C_003E4__this;

			[Token(Token = "0x17000924")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005319")]
				[Address(RVA = "0x17B6798", Offset = "0x17B6798", VA = "0x17B6798", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000925")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600531B")]
				[Address(RVA = "0x17B67E0", Offset = "0x17B67E0", VA = "0x17B67E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005316")]
			[Address(RVA = "0x17B64C8", Offset = "0x17B64C8", VA = "0x17B64C8")]
			[DebuggerHidden]
			public _003CPlayShootSequence_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005317")]
			[Address(RVA = "0x17B64F4", Offset = "0x17B64F4", VA = "0x17B64F4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005318")]
			[Address(RVA = "0x17B64F8", Offset = "0x17B64F8", VA = "0x17B64F8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005319")]
			[Address(RVA = "0x17B6798", Offset = "0x17B6798", VA = "0x17B6798", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600531A")]
			[Address(RVA = "0x17B67A0", Offset = "0x17B67A0", VA = "0x17B67A0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600531B")]
			[Address(RVA = "0x17B67E0", Offset = "0x17B67E0", VA = "0x17B67E0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400616C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float minVelocity;

		[Token(Token = "0x400616D")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float fullVelocity;

		[Token(Token = "0x400616E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float fullPitch;

		[Token(Token = "0x400616F")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float fullSpin;

		[Token(Token = "0x4006170")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Rigidbody GolfClub;

		[Token(Token = "0x4006171")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Animator golfAnimator;

		[Token(Token = "0x4006172")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent OnCollapse;

		[Token(Token = "0x4006173")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool CollapseAtStart;

		[Token(Token = "0x4006174")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform ClubRoot;

		[Token(Token = "0x4006175")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool playShootRoutine;

		[Token(Token = "0x4006176")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool doFullReset;

		[Token(Token = "0x4006177")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Rigidbody hips;

		[Token(Token = "0x4006178")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool forceSpecificDirection;

		[Token(Token = "0x4006179")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Vector3 boostOverride;

		[Token(Token = "0x400617A")]
		[FieldOffset(Offset = "0xB8")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400617B")]
		[FieldOffset(Offset = "0xC0")]
		private bool hasCollapsed;

		[Token(Token = "0x400617C")]
		[FieldOffset(Offset = "0xC1")]
		private bool isCollapsing;

		[Token(Token = "0x400617D")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 oldPosition;

		[Token(Token = "0x400617E")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion oldRotation;

		[Token(Token = "0x400617F")]
		[FieldOffset(Offset = "0xE0")]
		public CBFollow followCamera;

		[Token(Token = "0x4006180")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 targetBlend;

		[Token(Token = "0x4006181")]
		[FieldOffset(Offset = "0xF4")]
		private float velRef;

		[Token(Token = "0x4006182")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 baseClubLocalPosition;

		[Token(Token = "0x4006183")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion baseClubLocalRotation;

		[Token(Token = "0x4006184")]
		[FieldOffset(Offset = "0x118")]
		private Transform baseClubParent;

		[Token(Token = "0x4006185")]
		[FieldOffset(Offset = "0x120")]
		private Transform baseArrowFollow;

		[Token(Token = "0x4006186")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool isEditorGolfer;

		[Token(Token = "0x4006187")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Transform anchor;

		[Token(Token = "0x6005302")]
		[Address(RVA = "0x14A568C", Offset = "0x14A568C", VA = "0x14A568C", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005303")]
		[Address(RVA = "0x14A598C", Offset = "0x14A598C", VA = "0x14A598C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005304")]
		[Address(RVA = "0x14A5B40", Offset = "0x14A5B40", VA = "0x14A5B40")]
		private void Update()
		{
		}

		[Token(Token = "0x6005305")]
		[Address(RVA = "0x14A5D7C", Offset = "0x14A5D7C", VA = "0x14A5D7C", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005306")]
		[Address(RVA = "0x14A5DD4", Offset = "0x14A5DD4", VA = "0x14A5DD4", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005307")]
		[Address(RVA = "0x14A5E10", Offset = "0x14A5E10", VA = "0x14A5E10", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005308")]
		[Address(RVA = "0x14A61B0", Offset = "0x14A61B0", VA = "0x14A61B0")]
		private IEnumerator ShootRoutine(Vector3 boost)
		{
			return null;
		}

		[Token(Token = "0x6005309")]
		[Address(RVA = "0x14A62FC", Offset = "0x14A62FC", VA = "0x14A62FC", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600530A")]
		[Address(RVA = "0x14A6574", Offset = "0x14A6574", VA = "0x14A6574")]
		public void ResetClub()
		{
		}

		[Token(Token = "0x600530B")]
		[Address(RVA = "0x14A6248", Offset = "0x14A6248", VA = "0x14A6248")]
		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}

		[Token(Token = "0x600530C")]
		[Address(RVA = "0x14A6678", Offset = "0x14A6678", VA = "0x14A6678")]
		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			return null;
		}

		[Token(Token = "0x600530D")]
		[Address(RVA = "0x14A66EC", Offset = "0x14A66EC", VA = "0x14A66EC")]
		public GolferShooter()
		{
		}
	}
}
