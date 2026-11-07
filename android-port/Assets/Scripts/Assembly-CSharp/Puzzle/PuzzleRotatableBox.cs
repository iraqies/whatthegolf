using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x200103E")]
	public class PuzzleRotatableBox : PuzzleObjectBase
	{
		[Token(Token = "0x200103F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x476D4", Offset = "0x476D4")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x40055A9")]
			[FieldOffset(Offset = "0x10")]
			public PuzzleRotatableBox _003C_003E4__this;

			[Token(Token = "0x40055AA")]
			[FieldOffset(Offset = "0x18")]
			public Quaternion rot;

			[Token(Token = "0x40055AB")]
			[FieldOffset(Offset = "0x28")]
			public Quaternion newRotation;

			[Token(Token = "0x60048D2")]
			[Address(RVA = "0x182F25C", Offset = "0x182F25C", VA = "0x182F25C")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60048D3")]
			[Address(RVA = "0x182F264", Offset = "0x182F264", VA = "0x182F264")]
			internal void _003CRotate_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x2001040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x476E4", Offset = "0x476E4")]
		private sealed class _003CRotate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40055AC")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40055AD")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40055AE")]
			[FieldOffset(Offset = "0x20")]
			public PuzzleRotatableBox _003C_003E4__this;

			[Token(Token = "0x170007B1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60048D7")]
				[Address(RVA = "0x182F51C", Offset = "0x182F51C", VA = "0x182F51C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007B2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60048D9")]
				[Address(RVA = "0x182F564", Offset = "0x182F564", VA = "0x182F564", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60048D4")]
			[Address(RVA = "0x182F2D4", Offset = "0x182F2D4", VA = "0x182F2D4")]
			[DebuggerHidden]
			public _003CRotate_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60048D5")]
			[Address(RVA = "0x182F300", Offset = "0x182F300", VA = "0x182F300", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60048D6")]
			[Address(RVA = "0x182F304", Offset = "0x182F304", VA = "0x182F304", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60048D7")]
			[Address(RVA = "0x182F51C", Offset = "0x182F51C", VA = "0x182F51C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60048D8")]
			[Address(RVA = "0x182F524", Offset = "0x182F524", VA = "0x182F524", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60048D9")]
			[Address(RVA = "0x182F564", Offset = "0x182F564", VA = "0x182F564", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40055A4")]
		[FieldOffset(Offset = "0x34")]
		public float rotationTime;

		[Token(Token = "0x40055A5")]
		[FieldOffset(Offset = "0x38")]
		public bool rotateClockwise;

		[Token(Token = "0x40055A6")]
		[FieldOffset(Offset = "0x3C")]
		private float nextHitTime;

		[Token(Token = "0x40055A7")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine routine;

		[Token(Token = "0x40055A8")]
		[FieldOffset(Offset = "0x48")]
		public RandomAudioClips turnClips;

		[Token(Token = "0x60048CF")]
		[Address(RVA = "0x16310D8", Offset = "0x16310D8", VA = "0x16310D8")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60048D0")]
		[Address(RVA = "0x1631408", Offset = "0x1631408", VA = "0x1631408")]
		private IEnumerator Rotate(Rigidbody2D rb)
		{
			return null;
		}

		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x163147C", Offset = "0x163147C", VA = "0x163147C")]
		public PuzzleRotatableBox()
		{
		}
	}
}
