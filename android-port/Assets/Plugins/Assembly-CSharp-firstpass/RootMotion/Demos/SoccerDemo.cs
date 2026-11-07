using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000212")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x33D44", Offset = "0x33D44")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000213")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33DAC", Offset = "0x33DAC")]
		private sealed class _003CResetDelayed_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DDB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000DDC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000DDD")]
			[FieldOffset(Offset = "0x20")]
			public SoccerDemo _003C_003E4__this;

			[Token(Token = "0x170001C4")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000E55")]
				[Address(RVA = "0x13563AC", Offset = "0x13563AC", VA = "0x13563AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001C5")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000E57")]
				[Address(RVA = "0x13563F4", Offset = "0x13563F4", VA = "0x13563F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x135624C", Offset = "0x135624C", VA = "0x135624C")]
			[DebuggerHidden]
			public _003CResetDelayed_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x1356278", Offset = "0x1356278", VA = "0x1356278", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x135627C", Offset = "0x135627C", VA = "0x135627C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x13563AC", Offset = "0x13563AC", VA = "0x13563AC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x13563B4", Offset = "0x13563B4", VA = "0x13563B4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x13563F4", Offset = "0x13563F4", VA = "0x13563F4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x13FC028", Offset = "0x13FC028", VA = "0x13FC028")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x13FC11C", Offset = "0x13FC11C", VA = "0x13FC11C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x13FC190", Offset = "0x13FC190", VA = "0x13FC190")]
		public SoccerDemo()
		{
		}
	}
}
