using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001042")]
	public class RailObject : PuzzleObjectBase, ITimedPuzzleObject
	{
		[Token(Token = "0x2001043")]
		public enum MovementSmooth
		{
			[Token(Token = "0x40055BD")]
			LINEAR = 0,
			[Token(Token = "0x40055BE")]
			EASE_OUT = 1,
			[Token(Token = "0x40055BF")]
			EASE_IN = 2,
			[Token(Token = "0x40055C0")]
			SMOOTHSTEP = 3,
			[Token(Token = "0x40055C1")]
			SMOOTHERSTEP = 4
		}

		[Token(Token = "0x2001044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x476F4", Offset = "0x476F4")]
		private sealed class _003CMoveToPoint_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40055C2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40055C3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40055C4")]
			[FieldOffset(Offset = "0x20")]
			public RailObject _003C_003E4__this;

			[Token(Token = "0x40055C5")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 point;

			[Token(Token = "0x40055C6")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 _003CstartPos_003E5__2;

			[Token(Token = "0x40055C7")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 _003CnewPos_003E5__3;

			[Token(Token = "0x40055C8")]
			[FieldOffset(Offset = "0x4C")]
			private float _003CdurationClamped_003E5__4;

			[Token(Token = "0x40055C9")]
			[FieldOffset(Offset = "0x50")]
			private float _003Ctime_003E5__5;

			[Token(Token = "0x170007B4")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60048E7")]
				[Address(RVA = "0x1830104", Offset = "0x1830104", VA = "0x1830104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007B5")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60048E9")]
				[Address(RVA = "0x183014C", Offset = "0x183014C", VA = "0x183014C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60048E4")]
			[Address(RVA = "0x182FF48", Offset = "0x182FF48", VA = "0x182FF48")]
			[DebuggerHidden]
			public _003CMoveToPoint_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60048E5")]
			[Address(RVA = "0x182FF74", Offset = "0x182FF74", VA = "0x182FF74", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60048E6")]
			[Address(RVA = "0x182FF78", Offset = "0x182FF78", VA = "0x182FF78", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60048E7")]
			[Address(RVA = "0x1830104", Offset = "0x1830104", VA = "0x1830104", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60048E8")]
			[Address(RVA = "0x183010C", Offset = "0x183010C", VA = "0x183010C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60048E9")]
			[Address(RVA = "0x183014C", Offset = "0x183014C", VA = "0x183014C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40055AF")]
		[FieldOffset(Offset = "0x34")]
		public float timeToMoveMin;

		[Token(Token = "0x40055B0")]
		[FieldOffset(Offset = "0x38")]
		public float timeToMoveMax;

		[Token(Token = "0x40055B1")]
		[FieldOffset(Offset = "0x3C")]
		public bool canRetriggerWhileMoving;

		[Token(Token = "0x40055B2")]
		[FieldOffset(Offset = "0x40")]
		public Transform movingObject;

		[Token(Token = "0x40055B3")]
		[FieldOffset(Offset = "0x48")]
		public Transform pointA;

		[Token(Token = "0x40055B4")]
		[FieldOffset(Offset = "0x50")]
		public Transform pointB;

		[Token(Token = "0x40055B5")]
		[FieldOffset(Offset = "0x58")]
		public MovementSmooth movementSmooth;

		[Token(Token = "0x40055B6")]
		[FieldOffset(Offset = "0x60")]
		private Transform currentPoint;

		[Token(Token = "0x40055B7")]
		[FieldOffset(Offset = "0x68")]
		private float maxDistance;

		[Token(Token = "0x40055B8")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine routine;

		[Token(Token = "0x40055B9")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 posA;

		[Token(Token = "0x40055BA")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 posB;

		[Token(Token = "0x40055BB")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555A0", Offset = "0x555A0")]
		private LocalClock BallClock__BackingField;

		[Token(Token = "0x170007B3")]
		public LocalClock BallClock
		{
			[Token(Token = "0x60048DB")]
			[Address(RVA = "0x163E268", Offset = "0x163E268", VA = "0x163E268", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F0F4", Offset = "0x6F0F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60048DC")]
			[Address(RVA = "0x163E270", Offset = "0x163E270", VA = "0x163E270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F104", Offset = "0x6F104")]
			set
			{
			}
		}

		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x163E278", Offset = "0x163E278", VA = "0x163E278", Slot = "9")]
		public void SetClock(LocalClock clock)
		{
		}

		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x163E280", Offset = "0x163E280", VA = "0x163E280", Slot = "11")]
		public float GetDeltaTime()
		{
			return default;
		}

		[Token(Token = "0x60048DF")]
		[Address(RVA = "0x163E328", Offset = "0x163E328", VA = "0x163E328")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x163E3C0", Offset = "0x163E3C0", VA = "0x163E3C0", Slot = "8")]
		public override void Trigger(bool active)
		{
		}

		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x163E574", Offset = "0x163E574", VA = "0x163E574")]
		private IEnumerator MoveToPoint(Vector3 point)
		{
			return null;
		}

		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x163E60C", Offset = "0x163E60C", VA = "0x163E60C")]
		private float ReturnSmoothedValue(float t)
		{
			return default;
		}

		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x163E678", Offset = "0x163E678", VA = "0x163E678")]
		public RailObject()
		{
		}
	}
}
