using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace TennisGolf
{
	[Token(Token = "0x20010A0")]
	public class TennisOpponent : MonoBehaviour
	{
		[Token(Token = "0x20010A1")]
		private enum StateEnum
		{
			[Token(Token = "0x4005793")]
			Serving = 0,
			[Token(Token = "0x4005794")]
			Passing = 1,
			[Token(Token = "0x4005795")]
			Receiving = 2
		}

		[Token(Token = "0x20010A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A94", Offset = "0x47A94")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x4005796")]
			[FieldOffset(Offset = "0x10")]
			public TennisOpponent _003C_003E4__this;

			[Token(Token = "0x4005797")]
			[FieldOffset(Offset = "0x18")]
			public float startY;

			[Token(Token = "0x6004A8E")]
			[Address(RVA = "0x186274C", Offset = "0x186274C", VA = "0x186274C")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6004A8F")]
			[Address(RVA = "0x1862754", Offset = "0x1862754", VA = "0x1862754")]
			internal void _003CDoServe_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x20010A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47AA4", Offset = "0x47AA4")]
		private sealed class _003CDoServe_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005798")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005799")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400579A")]
			[FieldOffset(Offset = "0x20")]
			public TennisOpponent _003C_003E4__this;

			[Token(Token = "0x400579B")]
			[FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

			[Token(Token = "0x170007DC")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A93")]
				[Address(RVA = "0x1862DD4", Offset = "0x1862DD4", VA = "0x1862DD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007DD")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A95")]
				[Address(RVA = "0x1862E1C", Offset = "0x1862E1C", VA = "0x1862E1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A90")]
			[Address(RVA = "0x1862908", Offset = "0x1862908", VA = "0x1862908")]
			[DebuggerHidden]
			public _003CDoServe_003Ed__25(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A91")]
			[Address(RVA = "0x1862934", Offset = "0x1862934", VA = "0x1862934", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A92")]
			[Address(RVA = "0x1862938", Offset = "0x1862938", VA = "0x1862938", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A93")]
			[Address(RVA = "0x1862DD4", Offset = "0x1862DD4", VA = "0x1862DD4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A94")]
			[Address(RVA = "0x1862DDC", Offset = "0x1862DDC", VA = "0x1862DDC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A95")]
			[Address(RVA = "0x1862E1C", Offset = "0x1862E1C", VA = "0x1862E1C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20010A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47AB4", Offset = "0x47AB4")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x400579C")]
			[FieldOffset(Offset = "0x10")]
			public TennisOpponent _003C_003E4__this;

			[Token(Token = "0x400579D")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 startPosition;

			[Token(Token = "0x6004A96")]
			[Address(RVA = "0x1862814", Offset = "0x1862814", VA = "0x1862814")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6004A97")]
			[Address(RVA = "0x186281C", Offset = "0x186281C", VA = "0x186281C")]
			internal void _003CModelJump_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x20010A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47AC4", Offset = "0x47AC4")]
		private sealed class _003CModelJump_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400579E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400579F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40057A0")]
			[FieldOffset(Offset = "0x20")]
			public TennisOpponent _003C_003E4__this;

			[Token(Token = "0x170007DE")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A9B")]
				[Address(RVA = "0x1862FB4", Offset = "0x1862FB4", VA = "0x1862FB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007DF")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A9D")]
				[Address(RVA = "0x1862FFC", Offset = "0x1862FFC", VA = "0x1862FFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A98")]
			[Address(RVA = "0x1862E24", Offset = "0x1862E24", VA = "0x1862E24")]
			[DebuggerHidden]
			public _003CModelJump_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x1862E50", Offset = "0x1862E50", VA = "0x1862E50", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A9A")]
			[Address(RVA = "0x1862E54", Offset = "0x1862E54", VA = "0x1862E54", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A9B")]
			[Address(RVA = "0x1862FB4", Offset = "0x1862FB4", VA = "0x1862FB4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0x1862FBC", Offset = "0x1862FBC", VA = "0x1862FBC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x1862FFC", Offset = "0x1862FFC", VA = "0x1862FFC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400577F")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody TennisBall;

		[Token(Token = "0x4005780")]
		[FieldOffset(Offset = "0x20")]
		public Transform CenterOfThisSide;

		[Token(Token = "0x4005781")]
		[FieldOffset(Offset = "0x28")]
		public Transform CenterOfOtherSide;

		[Token(Token = "0x4005782")]
		[FieldOffset(Offset = "0x30")]
		public BoxCollider TennisCourt;

		[Token(Token = "0x4005783")]
		[FieldOffset(Offset = "0x38")]
		public float CourtSize;

		[Token(Token = "0x4005784")]
		[FieldOffset(Offset = "0x3C")]
		public float ShotAngle;

		[Token(Token = "0x4005785")]
		[FieldOffset(Offset = "0x40")]
		public float BallServeHeight;

		[Token(Token = "0x4005786")]
		[FieldOffset(Offset = "0x44")]
		public float BallVelocityMultiplier;

		[Token(Token = "0x4005787")]
		[FieldOffset(Offset = "0x48")]
		public float MoveSpeed;

		[Token(Token = "0x4005788")]
		[FieldOffset(Offset = "0x4C")]
		public float JumpHeight;

		[Token(Token = "0x4005789")]
		[FieldOffset(Offset = "0x50")]
		public float JumpDuration;

		[Token(Token = "0x400578A")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400578B")]
		[FieldOffset(Offset = "0x60")]
		private StateEnum currentState;

		[Token(Token = "0x400578C")]
		[FieldOffset(Offset = "0x68")]
		private TennisBall ball;

		[Token(Token = "0x400578D")]
		[FieldOffset(Offset = "0x70")]
		private float enableCollisionTimer;

		[Token(Token = "0x400578E")]
		[FieldOffset(Offset = "0x78")]
		private TennisBall tennisBall;

		[Token(Token = "0x400578F")]
		[FieldOffset(Offset = "0x80")]
		private float moveSpeedDecrementer;

		[Token(Token = "0x4005790")]
		[FieldOffset(Offset = "0x88")]
		private Transform model;

		[Token(Token = "0x4005791")]
		[FieldOffset(Offset = "0x90")]
		public bool firstShootNeutral;

		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x170DA18", Offset = "0x170DA18", VA = "0x170DA18")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x170DB90", Offset = "0x170DB90", VA = "0x170DB90")]
		private void OnGameWon()
		{
		}

		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x170DC80", Offset = "0x170DC80", VA = "0x170DC80")]
		private void Start()
		{
		}

		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x170DCFC", Offset = "0x170DCFC", VA = "0x170DCFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x170DDBC", Offset = "0x170DDBC", VA = "0x170DDBC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004A8A")]
		[Address(RVA = "0x170DC0C", Offset = "0x170DC0C", VA = "0x170DC0C")]
		private IEnumerator DoServe()
		{
			return null;
		}

		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0x170DFEC", Offset = "0x170DFEC", VA = "0x170DFEC")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x170E304", Offset = "0x170E304", VA = "0x170E304")]
		private IEnumerator ModelJump()
		{
			return null;
		}

		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x170E378", Offset = "0x170E378", VA = "0x170E378")]
		public TennisOpponent()
		{
		}
	}
}
