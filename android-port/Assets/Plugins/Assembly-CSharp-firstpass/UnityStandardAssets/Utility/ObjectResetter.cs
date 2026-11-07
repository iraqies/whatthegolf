using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000053")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3327C", Offset = "0x3327C")]
		private sealed class _003CResetCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400014F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000150")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000151")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000152")]
			[FieldOffset(Offset = "0x28")]
			public ObjectResetter _003C_003E4__this;

			[Token(Token = "0x17000027")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000157")]
				[Address(RVA = "0x1350DA8", Offset = "0x1350DA8", VA = "0x1350DA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000028")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000159")]
				[Address(RVA = "0x1350DF0", Offset = "0x1350DF0", VA = "0x1350DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1350B20", Offset = "0x1350B20", VA = "0x1350B20")]
			[DebuggerHidden]
			public _003CResetCoroutine_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1350B4C", Offset = "0x1350B4C", VA = "0x1350B4C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1350B50", Offset = "0x1350B50", VA = "0x1350B50", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1350DA8", Offset = "0x1350DA8", VA = "0x1350DA8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1350DB0", Offset = "0x1350DB0", VA = "0x1350DB0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1350DF0", Offset = "0x1350DF0", VA = "0x1350DF0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x13BCB10", Offset = "0x13BCB10", VA = "0x13BCB10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x13BCC20", Offset = "0x13BCC20", VA = "0x13BCC20")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x13BCCAC", Offset = "0x13BCCAC", VA = "0x13BCCAC")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x13BCD30", Offset = "0x13BCD30", VA = "0x13BCD30")]
		public ObjectResetter()
		{
		}
	}
}
