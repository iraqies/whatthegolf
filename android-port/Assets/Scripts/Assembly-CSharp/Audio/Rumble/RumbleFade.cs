using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013FD")]
	public class RumbleFade : MonoBehaviour
	{
		[Token(Token = "0x20013FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4900C", Offset = "0x4900C")]
		private sealed class _003CFadeRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006B53")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006B54")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000A88")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005D12")]
				[Address(RVA = "0x18367B4", Offset = "0x18367B4", VA = "0x18367B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A89")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005D14")]
				[Address(RVA = "0x18367FC", Offset = "0x18367FC", VA = "0x18367FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005D0F")]
			[Address(RVA = "0x183674C", Offset = "0x183674C", VA = "0x183674C")]
			[DebuggerHidden]
			public _003CFadeRoutine_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005D10")]
			[Address(RVA = "0x1836778", Offset = "0x1836778", VA = "0x1836778", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005D11")]
			[Address(RVA = "0x183677C", Offset = "0x183677C", VA = "0x183677C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005D12")]
			[Address(RVA = "0x18367B4", Offset = "0x18367B4", VA = "0x18367B4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005D13")]
			[Address(RVA = "0x18367BC", Offset = "0x18367BC", VA = "0x18367BC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005D14")]
			[Address(RVA = "0x18367FC", Offset = "0x18367FC", VA = "0x18367FC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006B4D")]
		[FieldOffset(Offset = "0x18")]
		public float amplitudeLow;

		[Token(Token = "0x4006B4E")]
		[FieldOffset(Offset = "0x1C")]
		public float frequencyLow;

		[Token(Token = "0x4006B4F")]
		[FieldOffset(Offset = "0x20")]
		public float amplitudeHigh;

		[Token(Token = "0x4006B50")]
		[FieldOffset(Offset = "0x24")]
		public float frequencyHigh;

		[Token(Token = "0x4006B51")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine fadeRoutine;

		[Token(Token = "0x4006B52")]
		[FieldOffset(Offset = "0x30")]
		private float gain;

		[Token(Token = "0x6005D0B")]
		[Address(RVA = "0x1661C28", Offset = "0x1661C28", VA = "0x1661C28")]
		public void FadeInRumble(float duration)
		{
		}

		[Token(Token = "0x6005D0C")]
		[Address(RVA = "0x1661C2C", Offset = "0x1661C2C", VA = "0x1661C2C")]
		public void FadeOutRumble(float duration)
		{
		}

		[Token(Token = "0x6005D0D")]
		[Address(RVA = "0x1661C30", Offset = "0x1661C30", VA = "0x1661C30")]
		private IEnumerator FadeRoutine(float duration, bool fadeIn)
		{
			return null;
		}

		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0x1661C8C", Offset = "0x1661C8C", VA = "0x1661C8C")]
		public RumbleFade()
		{
		}
	}
}
