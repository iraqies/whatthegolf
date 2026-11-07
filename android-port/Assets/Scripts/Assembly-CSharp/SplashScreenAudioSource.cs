using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A2")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3D738", Offset = "0x3D738")]
public class SplashScreenAudioSource : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D7A0", Offset = "0x3D7A0")]
	private sealed class _003CFadeAndDestroy_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x28")]
		public SplashScreenAudioSource _003C_003E4__this;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cdecrement_003E5__2;

		[Token(Token = "0x17000078")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x185977C", Offset = "0x185977C", VA = "0x185977C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000079")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x18597C4", Offset = "0x18597C4", VA = "0x18597C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1859628", Offset = "0x1859628", VA = "0x1859628")]
		[DebuggerHidden]
		public _003CFadeAndDestroy_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1859654", Offset = "0x1859654", VA = "0x1859654", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1859658", Offset = "0x1859658", VA = "0x1859658", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x185977C", Offset = "0x185977C", VA = "0x185977C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1859784", Offset = "0x1859784", VA = "0x1859784", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x18597C4", Offset = "0x18597C4", VA = "0x18597C4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_QuickFadeTime;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_NormalFadeTime;

	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine fadeCoroutine;

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x28")]
	private AudioSource source;

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x16D7E60", Offset = "0x16D7E60", VA = "0x16D7E60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x16D7EBC", Offset = "0x16D7EBC", VA = "0x16D7EBC")]
	public void Play()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x16D7ED8", Offset = "0x16D7ED8", VA = "0x16D7ED8")]
	public void OnSplashScreenComplete(bool skip)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x16D7FA8", Offset = "0x16D7FA8", VA = "0x16D7FA8")]
	private IEnumerator FadeAndDestroy(float time)
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x16D802C", Offset = "0x16D802C", VA = "0x16D802C")]
	public SplashScreenAudioSource()
	{
	}
}
