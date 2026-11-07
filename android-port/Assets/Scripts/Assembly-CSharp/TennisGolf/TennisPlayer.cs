using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace TennisGolf
{
	[Token(Token = "0x20010A6")]
	public class TennisPlayer : MonoBehaviour
	{
		[Token(Token = "0x20010A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47AD4", Offset = "0x47AD4")]
		private sealed class _003CDelayedWin_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40057B0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40057B1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40057B2")]
			[FieldOffset(Offset = "0x20")]
			public TennisPlayer _003C_003E4__this;

			[Token(Token = "0x170007E0")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004AA9")]
				[Address(RVA = "0x186320C", Offset = "0x186320C", VA = "0x186320C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007E1")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004AAB")]
				[Address(RVA = "0x1863254", Offset = "0x1863254", VA = "0x1863254", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004AA6")]
			[Address(RVA = "0x18630F8", Offset = "0x18630F8", VA = "0x18630F8")]
			[DebuggerHidden]
			public _003CDelayedWin_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004AA7")]
			[Address(RVA = "0x1863124", Offset = "0x1863124", VA = "0x1863124", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004AA8")]
			[Address(RVA = "0x1863128", Offset = "0x1863128", VA = "0x1863128", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004AA9")]
			[Address(RVA = "0x186320C", Offset = "0x186320C", VA = "0x186320C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004AAA")]
			[Address(RVA = "0x1863214", Offset = "0x1863214", VA = "0x1863214", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004AAB")]
			[Address(RVA = "0x1863254", Offset = "0x1863254", VA = "0x1863254", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20010A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47AE4", Offset = "0x47AE4")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x40057B3")]
			[FieldOffset(Offset = "0x10")]
			public TennisPlayer _003C_003E4__this;

			[Token(Token = "0x40057B4")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 startPosition;

			[Token(Token = "0x6004AAC")]
			[Address(RVA = "0x1863004", Offset = "0x1863004", VA = "0x1863004")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6004AAD")]
			[Address(RVA = "0x186300C", Offset = "0x186300C", VA = "0x186300C")]
			internal void _003CModelJump_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x20010A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47AF4", Offset = "0x47AF4")]
		private sealed class _003CModelJump_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40057B5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40057B6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40057B7")]
			[FieldOffset(Offset = "0x20")]
			public TennisPlayer _003C_003E4__this;

			[Token(Token = "0x170007E2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004AB1")]
				[Address(RVA = "0x18633EC", Offset = "0x18633EC", VA = "0x18633EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007E3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004AB3")]
				[Address(RVA = "0x1863434", Offset = "0x1863434", VA = "0x1863434", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004AAE")]
			[Address(RVA = "0x186325C", Offset = "0x186325C", VA = "0x186325C")]
			[DebuggerHidden]
			public _003CModelJump_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004AAF")]
			[Address(RVA = "0x1863288", Offset = "0x1863288", VA = "0x1863288", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004AB0")]
			[Address(RVA = "0x186328C", Offset = "0x186328C", VA = "0x186328C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004AB1")]
			[Address(RVA = "0x18633EC", Offset = "0x18633EC", VA = "0x18633EC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004AB2")]
			[Address(RVA = "0x18633F4", Offset = "0x18633F4", VA = "0x18633F4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004AB3")]
			[Address(RVA = "0x1863434", Offset = "0x1863434", VA = "0x1863434", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40057A1")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody TennisBall;

		[Token(Token = "0x40057A2")]
		[FieldOffset(Offset = "0x20")]
		public Transform TennisCourt;

		[Token(Token = "0x40057A3")]
		[FieldOffset(Offset = "0x28")]
		public Transform CenterOfOtherSide;

		[Token(Token = "0x40057A4")]
		[FieldOffset(Offset = "0x30")]
		public float CourtSize;

		[Token(Token = "0x40057A5")]
		[FieldOffset(Offset = "0x38")]
		public List<GameObject> PlayerTrophies;

		[Token(Token = "0x40057A6")]
		[FieldOffset(Offset = "0x40")]
		public List<GameObject> OpponentTrophies;

		[Token(Token = "0x40057A7")]
		[FieldOffset(Offset = "0x48")]
		public GameObject FlagObject;

		[Token(Token = "0x40057A8")]
		[FieldOffset(Offset = "0x50")]
		public float ShotAngle;

		[Token(Token = "0x40057A9")]
		[FieldOffset(Offset = "0x54")]
		public float JumpHeight;

		[Token(Token = "0x40057AA")]
		[FieldOffset(Offset = "0x58")]
		public float JumpDuration;

		[Token(Token = "0x40057AB")]
		[FieldOffset(Offset = "0x60")]
		private TennisBall ball;

		[Token(Token = "0x40057AC")]
		[FieldOffset(Offset = "0x68")]
		private float enableCollisionTimer;

		[Token(Token = "0x40057AD")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody rigid;

		[Token(Token = "0x40057AE")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 lastDirection;

		[Token(Token = "0x40057AF")]
		[FieldOffset(Offset = "0x88")]
		private Transform model;

		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x170E3A0", Offset = "0x170E3A0", VA = "0x170E3A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004A9F")]
		[Address(RVA = "0x170E594", Offset = "0x170E594", VA = "0x170E594")]
		private void OnAimUpdate(Vector3 boost, bool b)
		{
		}

		[Token(Token = "0x6004AA0")]
		[Address(RVA = "0x170E5A0", Offset = "0x170E5A0", VA = "0x170E5A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004AA1")]
		[Address(RVA = "0x170E660", Offset = "0x170E660", VA = "0x170E660")]
		private IEnumerator DelayedWin()
		{
			return null;
		}

		[Token(Token = "0x6004AA2")]
		[Address(RVA = "0x170E6D4", Offset = "0x170E6D4", VA = "0x170E6D4")]
		public void OnPlayerWon()
		{
		}

		[Token(Token = "0x6004AA3")]
		[Address(RVA = "0x170E838", Offset = "0x170E838", VA = "0x170E838")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6004AA4")]
		[Address(RVA = "0x170EB0C", Offset = "0x170EB0C", VA = "0x170EB0C")]
		private IEnumerator ModelJump()
		{
			return null;
		}

		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x170EB80", Offset = "0x170EB80", VA = "0x170EB80")]
		public TennisPlayer()
		{
		}
	}
}
