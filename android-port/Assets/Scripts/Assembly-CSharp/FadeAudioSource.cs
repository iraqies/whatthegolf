using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D77")]
public static class FadeAudioSource
{
	[Token(Token = "0x2000D78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x449E0", Offset = "0x449E0")]
	private sealed class _003CStartFade_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400493F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004940")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004941")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x4004942")]
		[FieldOffset(Offset = "0x28")]
		public float targetVolume;

		[Token(Token = "0x4004943")]
		[FieldOffset(Offset = "0x2C")]
		public float duration;

		[Token(Token = "0x4004944")]
		[FieldOffset(Offset = "0x30")]
		private float _003CcurrentTime_003E5__2;

		[Token(Token = "0x4004945")]
		[FieldOffset(Offset = "0x34")]
		private float _003Cstart_003E5__3;

		[Token(Token = "0x17000673")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F58")]
			[Address(RVA = "0x17A2C14", Offset = "0x17A2C14", VA = "0x17A2C14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000674")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F5A")]
			[Address(RVA = "0x17A2C5C", Offset = "0x17A2C5C", VA = "0x17A2C5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x17A2B28", Offset = "0x17A2B28", VA = "0x17A2B28")]
		[DebuggerHidden]
		public _003CStartFade_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x17A2B54", Offset = "0x17A2B54", VA = "0x17A2B54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x17A2B58", Offset = "0x17A2B58", VA = "0x17A2B58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x17A2C14", Offset = "0x17A2C14", VA = "0x17A2C14", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x17A2C1C", Offset = "0x17A2C1C", VA = "0x17A2C1C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x17A2C5C", Offset = "0x17A2C5C", VA = "0x17A2C5C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x6003F54")]
	[Address(RVA = "0x145A8F8", Offset = "0x145A8F8", VA = "0x145A8F8")]
	public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
	{
		return null;
	}
}
