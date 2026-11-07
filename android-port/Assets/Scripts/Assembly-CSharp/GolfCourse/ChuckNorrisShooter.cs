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
	[Token(Token = "0x20011FD")]
	public class ChuckNorrisShooter : GolfBallShooterBase
	{
		[Token(Token = "0x20011FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48444", Offset = "0x48444")]
		private sealed class _003CShootRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060E0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060E1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40060E2")]
			[FieldOffset(Offset = "0x20")]
			public ChuckNorrisShooter _003C_003E4__this;

			[Token(Token = "0x40060E3")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 boost;

			[Token(Token = "0x17000914")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60052AD")]
				[Address(RVA = "0x1786C34", Offset = "0x1786C34", VA = "0x1786C34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000915")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60052AF")]
				[Address(RVA = "0x1786C7C", Offset = "0x1786C7C", VA = "0x1786C7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60052AA")]
			[Address(RVA = "0x1786B74", Offset = "0x1786B74", VA = "0x1786B74")]
			[DebuggerHidden]
			public _003CShootRoutine_003Ed__32(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60052AB")]
			[Address(RVA = "0x1786BA0", Offset = "0x1786BA0", VA = "0x1786BA0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60052AC")]
			[Address(RVA = "0x1786BA4", Offset = "0x1786BA4", VA = "0x1786BA4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60052AD")]
			[Address(RVA = "0x1786C34", Offset = "0x1786C34", VA = "0x1786C34", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60052AE")]
			[Address(RVA = "0x1786C3C", Offset = "0x1786C3C", VA = "0x1786C3C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60052AF")]
			[Address(RVA = "0x1786C7C", Offset = "0x1786C7C", VA = "0x1786C7C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20011FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48454", Offset = "0x48454")]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			[Token(Token = "0x40060E4")]
			[FieldOffset(Offset = "0x10")]
			public ChuckNorrisShooter _003C_003E4__this;

			[Token(Token = "0x40060E5")]
			[FieldOffset(Offset = "0x18")]
			public float from;

			[Token(Token = "0x60052B0")]
			[Address(RVA = "0x17868BC", Offset = "0x17868BC", VA = "0x17868BC")]
			public _003C_003Ec__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60052B1")]
			[Address(RVA = "0x17868C4", Offset = "0x17868C4", VA = "0x17868C4")]
			internal void _003CPlayShootSequence_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x2001200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48464", Offset = "0x48464")]
		private sealed class _003CPlayShootSequence_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060E6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060E7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40060E8")]
			[FieldOffset(Offset = "0x20")]
			public ChuckNorrisShooter _003C_003E4__this;

			[Token(Token = "0x17000916")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60052B5")]
				[Address(RVA = "0x1786B24", Offset = "0x1786B24", VA = "0x1786B24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000917")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60052B7")]
				[Address(RVA = "0x1786B6C", Offset = "0x1786B6C", VA = "0x1786B6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60052B2")]
			[Address(RVA = "0x1786958", Offset = "0x1786958", VA = "0x1786958")]
			[DebuggerHidden]
			public _003CPlayShootSequence_003Ed__35(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60052B3")]
			[Address(RVA = "0x1786984", Offset = "0x1786984", VA = "0x1786984", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60052B4")]
			[Address(RVA = "0x1786988", Offset = "0x1786988", VA = "0x1786988", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60052B5")]
			[Address(RVA = "0x1786B24", Offset = "0x1786B24", VA = "0x1786B24", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60052B6")]
			[Address(RVA = "0x1786B2C", Offset = "0x1786B2C", VA = "0x1786B2C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60052B7")]
			[Address(RVA = "0x1786B6C", Offset = "0x1786B6C", VA = "0x1786B6C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40060C6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float minVelocity;

		[Token(Token = "0x40060C7")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float fullVelocity;

		[Token(Token = "0x40060C8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float fullPitch;

		[Token(Token = "0x40060C9")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float fullSpin;

		[Token(Token = "0x40060CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Rigidbody GolfClub;

		[Token(Token = "0x40060CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Animator golfAnimator;

		[Token(Token = "0x40060CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent OnCollapse;

		[Token(Token = "0x40060CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool CollapseAtStart;

		[Token(Token = "0x40060CE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform ClubRoot;

		[Token(Token = "0x40060CF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool playShootRoutine;

		[Token(Token = "0x40060D0")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool doFullReset;

		[Token(Token = "0x40060D1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Rigidbody rigidToShoot;

		[Token(Token = "0x40060D2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float force;

		[Token(Token = "0x40060D3")]
		[FieldOffset(Offset = "0xB0")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x40060D4")]
		[FieldOffset(Offset = "0xB8")]
		private Rigidbody hips;

		[Token(Token = "0x40060D5")]
		[FieldOffset(Offset = "0xC0")]
		private bool hasCollapsed;

		[Token(Token = "0x40060D6")]
		[FieldOffset(Offset = "0xC1")]
		private bool isCollapsing;

		[Token(Token = "0x40060D7")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 oldPosition;

		[Token(Token = "0x40060D8")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion oldRotation;

		[Token(Token = "0x40060D9")]
		[FieldOffset(Offset = "0xE0")]
		public CBFollow followCamera;

		[Token(Token = "0x40060DA")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 targetBlend;

		[Token(Token = "0x40060DB")]
		[FieldOffset(Offset = "0xF4")]
		private float velRef;

		[Token(Token = "0x40060DC")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 baseClubLocalPosition;

		[Token(Token = "0x40060DD")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion baseClubLocalRotation;

		[Token(Token = "0x40060DE")]
		[FieldOffset(Offset = "0x118")]
		private Transform baseClubParent;

		[Token(Token = "0x40060DF")]
		[FieldOffset(Offset = "0x120")]
		private Transform baseArrowFollow;

		[Token(Token = "0x600529F")]
		[Address(RVA = "0x189CD4C", Offset = "0x189CD4C", VA = "0x189CD4C", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x189CF10", Offset = "0x189CF10", VA = "0x189CF10")]
		private void Start()
		{
		}

		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x189D054", Offset = "0x189D054", VA = "0x189D054")]
		private void Update()
		{
		}

		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x189D1E8", Offset = "0x189D1E8", VA = "0x189D1E8", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x189D240", Offset = "0x189D240", VA = "0x189D240", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x189D27C", Offset = "0x189D27C", VA = "0x189D27C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x189D398", Offset = "0x189D398", VA = "0x189D398")]
		private IEnumerator ShootRoutine(Vector3 boost)
		{
			return null;
		}

		[Token(Token = "0x60052A6")]
		[Address(RVA = "0x189D430", Offset = "0x189D430", VA = "0x189D430", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60052A7")]
		[Address(RVA = "0x189D678", Offset = "0x189D678", VA = "0x189D678")]
		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}

		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x189D72C", Offset = "0x189D72C", VA = "0x189D72C")]
		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			return null;
		}

		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x189D7A0", Offset = "0x189D7A0", VA = "0x189D7A0")]
		public ChuckNorrisShooter()
		{
		}
	}
}
