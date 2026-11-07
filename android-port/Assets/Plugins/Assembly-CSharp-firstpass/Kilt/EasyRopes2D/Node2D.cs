using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000A9")]
	public class Node2D : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x335CC", Offset = "0x335CC")]
		private sealed class _003CRequestApplyIgnoreRopeCollision_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x20")]
			public Node2D _003C_003E4__this;

			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x28")]
			public bool p_force;

			[Token(Token = "0x4000314")]
			[FieldOffset(Offset = "0x30")]
			private List<Collider2D> _003Cv_selfColliders_003E5__2;

			[Token(Token = "0x4000315")]
			[FieldOffset(Offset = "0x38")]
			private List<GameObject>.Enumerator _003C_003E7__wrap2;

			[Token(Token = "0x4000316")]
			[FieldOffset(Offset = "0x50")]
			private GameObject _003Cv_object_003E5__4;

			[Token(Token = "0x1700008A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0x1350AD0", Offset = "0x1350AD0", VA = "0x1350AD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700008B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x1350B18", Offset = "0x1350B18", VA = "0x1350B18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x13501E4", Offset = "0x13501E4", VA = "0x13501E4")]
			[DebuggerHidden]
			public _003CRequestApplyIgnoreRopeCollision_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1350210", Offset = "0x1350210", VA = "0x1350210", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x13502E4", Offset = "0x13502E4", VA = "0x13502E4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1350288", Offset = "0x1350288", VA = "0x1350288")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1350AD0", Offset = "0x1350AD0", VA = "0x1350AD0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1350AD8", Offset = "0x1350AD8", VA = "0x1350AD8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1350B18", Offset = "0x1350B18", VA = "0x1350B18", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x18")]
		private Rope2D _ropeParent;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x20")]
		private bool _needApplyIgnore;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x21")]
		private bool _started;

		[Token(Token = "0x17000087")]
		public Rope2D RopeParent
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x13BC478", Offset = "0x13BC478", VA = "0x13BC478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		protected virtual bool NeedApplyIgnore
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x13BC524", Offset = "0x13BC524", VA = "0x13BC524", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x13BC52C", Offset = "0x13BC52C", VA = "0x13BC52C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		protected virtual bool Started
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x13BC540", Offset = "0x13BC540", VA = "0x13BC540", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x13BC548", Offset = "0x13BC548", VA = "0x13BC548", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x13BC55C", Offset = "0x13BC55C", VA = "0x13BC55C", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x13BC5A4", Offset = "0x13BC5A4", VA = "0x13BC5A4", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x13BC600", Offset = "0x13BC600", VA = "0x13BC600", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x13BC610", Offset = "0x13BC610", VA = "0x13BC610", Slot = "11")]
		public virtual void ApplyIgnoreRopeCollision(bool p_force = false)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x13BC690", Offset = "0x13BC690", VA = "0x13BC690", Slot = "12")]
		protected virtual IEnumerator RequestApplyIgnoreRopeCollision(bool p_force)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x13BC70C", Offset = "0x13BC70C", VA = "0x13BC70C")]
		public bool Cut()
		{
			return default;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x13BC7F8", Offset = "0x13BC7F8", VA = "0x13BC7F8")]
		public Node2D()
		{
		}
	}
}
