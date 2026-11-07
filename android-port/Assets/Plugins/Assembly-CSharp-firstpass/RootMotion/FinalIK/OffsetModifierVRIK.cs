using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001CE")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3396C", Offset = "0x3396C")]
		private sealed class _003CInitiate_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C3B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000C3C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000C3D")]
			[FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK _003C_003E4__this;

			[Token(Token = "0x170001B1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000D5A")]
				[Address(RVA = "0x1351478", Offset = "0x1351478", VA = "0x1351478", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001B2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000D5C")]
				[Address(RVA = "0x13514C0", Offset = "0x13514C0", VA = "0x13514C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x13512E8", Offset = "0x13512E8", VA = "0x13512E8")]
			[DebuggerHidden]
			public _003CInitiate_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x1351314", Offset = "0x1351314", VA = "0x1351314", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000D59")]
			[Address(RVA = "0x1351318", Offset = "0x1351318", VA = "0x1351318", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000D5A")]
			[Address(RVA = "0x1351478", Offset = "0x1351478", VA = "0x1351478", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000D5B")]
			[Address(RVA = "0x1351480", Offset = "0x1351480", VA = "0x1351480", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0x13514C0", Offset = "0x13514C0", VA = "0x13514C0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170001B0")]
		protected float deltaTime
		{
			[Token(Token = "0x6000D50")]
			[Address(RVA = "0x13BD46C", Offset = "0x13BD46C", VA = "0x13BD46C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000D51")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x13BD498", Offset = "0x13BD498", VA = "0x13BD498", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x13BD514", Offset = "0x13BD514", VA = "0x13BD514")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x13BD588", Offset = "0x13BD588", VA = "0x13BD588")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x13BD66C", Offset = "0x13BD66C", VA = "0x13BD66C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x13BD788", Offset = "0x13BD788", VA = "0x13BD788")]
		protected OffsetModifierVRIK()
		{
		}
	}
}
