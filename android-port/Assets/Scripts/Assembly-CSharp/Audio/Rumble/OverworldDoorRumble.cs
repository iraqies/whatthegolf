using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013F4")]
	public class OverworldDoorRumble : MonoBehaviour
	{
		[Token(Token = "0x20013F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48FEC", Offset = "0x48FEC")]
		private sealed class _003COpenRumbleCoroutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006B3E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006B3F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000A83")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005CF7")]
				[Address(RVA = "0x1810684", Offset = "0x1810684", VA = "0x1810684", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A84")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005CF9")]
				[Address(RVA = "0x18106CC", Offset = "0x18106CC", VA = "0x18106CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005CF4")]
			[Address(RVA = "0x181061C", Offset = "0x181061C", VA = "0x181061C")]
			[DebuggerHidden]
			public _003COpenRumbleCoroutine_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005CF5")]
			[Address(RVA = "0x1810648", Offset = "0x1810648", VA = "0x1810648", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005CF6")]
			[Address(RVA = "0x181064C", Offset = "0x181064C", VA = "0x181064C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005CF7")]
			[Address(RVA = "0x1810684", Offset = "0x1810684", VA = "0x1810684", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005CF8")]
			[Address(RVA = "0x181068C", Offset = "0x181068C", VA = "0x181068C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005CF9")]
			[Address(RVA = "0x18106CC", Offset = "0x18106CC", VA = "0x18106CC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006B3D")]
		[FieldOffset(Offset = "0x18")]
		public RumbleEventAsset rumble;

		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0x15B3E58", Offset = "0x15B3E58", VA = "0x15B3E58")]
		public void OpenDoorRumble(float duration)
		{
		}

		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0x15B3F54", Offset = "0x15B3F54", VA = "0x15B3F54")]
		private IEnumerator OpenRumbleCoroutine(float openDuration)
		{
			return null;
		}

		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0x15B3FB0", Offset = "0x15B3FB0", VA = "0x15B3FB0")]
		public OverworldDoorRumble()
		{
		}
	}
}
