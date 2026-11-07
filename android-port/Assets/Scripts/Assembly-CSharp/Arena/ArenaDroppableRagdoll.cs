using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x200121A")]
	public class ArenaDroppableRagdoll : ArenaDroppable
	{
		[Token(Token = "0x200121B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48514", Offset = "0x48514")]
		private sealed class _003CRemoveRagdollCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40061D7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40061D8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40061D9")]
			[FieldOffset(Offset = "0x20")]
			public ArenaDroppableRagdoll _003C_003E4__this;

			[Token(Token = "0x40061DA")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 _003CstartPos_003E5__2;

			[Token(Token = "0x40061DB")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 _003CundergroundPos_003E5__3;

			[Token(Token = "0x40061DC")]
			[FieldOffset(Offset = "0x40")]
			private float _003Cduration_003E5__4;

			[Token(Token = "0x40061DD")]
			[FieldOffset(Offset = "0x44")]
			private float _003C_time_003E5__5;

			[Token(Token = "0x17000932")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005367")]
				[Address(RVA = "0x176EFBC", Offset = "0x176EFBC", VA = "0x176EFBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000933")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005369")]
				[Address(RVA = "0x176F004", Offset = "0x176F004", VA = "0x176F004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005364")]
			[Address(RVA = "0x176ED70", Offset = "0x176ED70", VA = "0x176ED70")]
			[DebuggerHidden]
			public _003CRemoveRagdollCoroutine_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005365")]
			[Address(RVA = "0x176ED9C", Offset = "0x176ED9C", VA = "0x176ED9C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005366")]
			[Address(RVA = "0x176EDA0", Offset = "0x176EDA0", VA = "0x176EDA0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005367")]
			[Address(RVA = "0x176EFBC", Offset = "0x176EFBC", VA = "0x176EFBC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005368")]
			[Address(RVA = "0x176EFC4", Offset = "0x176EFC4", VA = "0x176EFC4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005369")]
			[Address(RVA = "0x176F004", Offset = "0x176F004", VA = "0x176F004", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40061D4")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody[] limbs;

		[Token(Token = "0x40061D5")]
		[FieldOffset(Offset = "0x58")]
		private Collider[] colliders;

		[Token(Token = "0x40061D6")]
		[FieldOffset(Offset = "0x60")]
		private bool didCheckHits;

		[Token(Token = "0x600535A")]
		[Address(RVA = "0x1422A38", Offset = "0x1422A38", VA = "0x1422A38", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600535B")]
		[Address(RVA = "0x1422AC4", Offset = "0x1422AC4", VA = "0x1422AC4", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600535C")]
		[Address(RVA = "0x1422BC8", Offset = "0x1422BC8", VA = "0x1422BC8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600535D")]
		[Address(RVA = "0x1422C88", Offset = "0x1422C88", VA = "0x1422C88")]
		private void Knockup()
		{
		}

		[Token(Token = "0x600535E")]
		[Address(RVA = "0x1422D10", Offset = "0x1422D10", VA = "0x1422D10")]
		private bool IsAtGround()
		{
			return default;
		}

		[Token(Token = "0x600535F")]
		[Address(RVA = "0x1422D74", Offset = "0x1422D74", VA = "0x1422D74")]
		private bool IsMoving()
		{
			return default;
		}

		[Token(Token = "0x6005360")]
		[Address(RVA = "0x1422DCC", Offset = "0x1422DCC", VA = "0x1422DCC")]
		private IEnumerator RemoveRagdollCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6005361")]
		[Address(RVA = "0x1422B4C", Offset = "0x1422B4C", VA = "0x1422B4C")]
		private void SetColliderActiveStatus(bool active)
		{
		}

		[Token(Token = "0x6005362")]
		[Address(RVA = "0x1422E40", Offset = "0x1422E40", VA = "0x1422E40")]
		private void SetRagdollKinematicStatus(bool active)
		{
		}

		[Token(Token = "0x6005363")]
		[Address(RVA = "0x1422F58", Offset = "0x1422F58", VA = "0x1422F58")]
		public ArenaDroppableRagdoll()
		{
		}
	}
}
