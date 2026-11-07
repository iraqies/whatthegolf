using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x200104A")]
	public class PuzzleSwitchOnStay : PuzzleSwitchBase
	{
		[Token(Token = "0x200104B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47714", Offset = "0x47714")]
		private sealed class _003CDampenVelocity_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40055D8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40055D9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40055DA")]
			[FieldOffset(Offset = "0x20")]
			public Rigidbody2D rb;

			[Token(Token = "0x40055DB")]
			[FieldOffset(Offset = "0x28")]
			public PuzzleSwitchOnStay _003C_003E4__this;

			[Token(Token = "0x40055DC")]
			[FieldOffset(Offset = "0x30")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x170007B7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600490A")]
				[Address(RVA = "0x182F6CC", Offset = "0x182F6CC", VA = "0x182F6CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007B8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600490C")]
				[Address(RVA = "0x182F714", Offset = "0x182F714", VA = "0x182F714", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004907")]
			[Address(RVA = "0x182F5D8", Offset = "0x182F5D8", VA = "0x182F5D8")]
			[DebuggerHidden]
			public _003CDampenVelocity_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004908")]
			[Address(RVA = "0x182F604", Offset = "0x182F604", VA = "0x182F604", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004909")]
			[Address(RVA = "0x182F608", Offset = "0x182F608", VA = "0x182F608", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600490A")]
			[Address(RVA = "0x182F6CC", Offset = "0x182F6CC", VA = "0x182F6CC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600490B")]
			[Address(RVA = "0x182F6D4", Offset = "0x182F6D4", VA = "0x182F6D4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600490C")]
			[Address(RVA = "0x182F714", Offset = "0x182F714", VA = "0x182F714", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40055D5")]
		[FieldOffset(Offset = "0x49")]
		public bool continuousTrigger;

		[Token(Token = "0x40055D6")]
		[FieldOffset(Offset = "0x4C")]
		public float velocityDamp;

		[Token(Token = "0x40055D7")]
		private const float time = 0.2f;

		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x1631CAC", Offset = "0x1631CAC", VA = "0x1631CAC")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x1631E10", Offset = "0x1631E10", VA = "0x1631E10")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6004900")]
		[Address(RVA = "0x1632014", Offset = "0x1632014", VA = "0x1632014")]
		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		[Token(Token = "0x6004901")]
		[Address(RVA = "0x1632068", Offset = "0x1632068", VA = "0x1632068")]
		private void OnCollisionStay2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6004902")]
		[Address(RVA = "0x16320BC", Offset = "0x16320BC", VA = "0x16320BC")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6004903")]
		[Address(RVA = "0x16320F8", Offset = "0x16320F8", VA = "0x16320F8")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6004904")]
		[Address(RVA = "0x1631CE8", Offset = "0x1631CE8", VA = "0x1631CE8")]
		private void OnObjectAnyTrigger(GameObject go, bool active)
		{
		}

		[Token(Token = "0x6004905")]
		[Address(RVA = "0x1631F9C", Offset = "0x1631F9C", VA = "0x1631F9C")]
		private IEnumerator DampenVelocity(Rigidbody2D rb)
		{
			return null;
		}

		[Token(Token = "0x6004906")]
		[Address(RVA = "0x1632134", Offset = "0x1632134", VA = "0x1632134")]
		public PuzzleSwitchOnStay()
		{
		}
	}
}
