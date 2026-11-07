using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000553")]
public class DailyChallengeCompleted : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000554")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x403F4", Offset = "0x403F4")]
	private struct _003CShow_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4001B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DailyChallengeCompleted _003C_003E4__this;

		[Token(Token = "0x4001B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int strokes;

		[Token(Token = "0x4001B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool scoreOk;

		[Token(Token = "0x4001B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6001852")]
		[Address(RVA = "0x179431C", Offset = "0x179431C", VA = "0x179431C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001853")]
		[Address(RVA = "0x17948B4", Offset = "0x17948B4", VA = "0x17948B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000555")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40404", Offset = "0x40404")]
	private sealed class _003CShowParticles_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyChallengeCompleted _003C_003E4__this;

		[Token(Token = "0x170002AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001857")]
			[Address(RVA = "0x17949BC", Offset = "0x17949BC", VA = "0x17949BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001859")]
			[Address(RVA = "0x1794A04", Offset = "0x1794A04", VA = "0x1794A04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001854")]
		[Address(RVA = "0x17948C0", Offset = "0x17948C0", VA = "0x17948C0")]
		[DebuggerHidden]
		public _003CShowParticles_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001855")]
		[Address(RVA = "0x17948EC", Offset = "0x17948EC", VA = "0x17948EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001856")]
		[Address(RVA = "0x17948F0", Offset = "0x17948F0", VA = "0x17948F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001857")]
		[Address(RVA = "0x17949BC", Offset = "0x17949BC", VA = "0x17949BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001858")]
		[Address(RVA = "0x17949C4", Offset = "0x17949C4", VA = "0x17949C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001859")]
		[Address(RVA = "0x1794A04", Offset = "0x1794A04", VA = "0x1794A04", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000556")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40414", Offset = "0x40414")]
	private sealed class _003CWaitForClose_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyChallengeCompleted _003C_003E4__this;

		[Token(Token = "0x170002AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600185D")]
			[Address(RVA = "0x1794C68", Offset = "0x1794C68", VA = "0x1794C68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600185F")]
			[Address(RVA = "0x1794CB0", Offset = "0x1794CB0", VA = "0x1794CB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600185A")]
		[Address(RVA = "0x1794A0C", Offset = "0x1794A0C", VA = "0x1794A0C")]
		[DebuggerHidden]
		public _003CWaitForClose_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600185B")]
		[Address(RVA = "0x1794A38", Offset = "0x1794A38", VA = "0x1794A38", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600185C")]
		[Address(RVA = "0x1794A3C", Offset = "0x1794A3C", VA = "0x1794A3C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600185D")]
		[Address(RVA = "0x1794C68", Offset = "0x1794C68", VA = "0x1794C68", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600185E")]
		[Address(RVA = "0x1794C70", Offset = "0x1794C70", VA = "0x1794C70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600185F")]
		[Address(RVA = "0x1794CB0", Offset = "0x1794CB0", VA = "0x1794CB0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001B89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI StrokesText;

	[Token(Token = "0x4001B8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI RankText;

	[Token(Token = "0x4001B8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool closing;

	[Token(Token = "0x4001B8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection completeSFX;

	[Token(Token = "0x4001B8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem completeParticles;

	[Token(Token = "0x6001849")]
	[Address(RVA = "0x18C968C", Offset = "0x18C968C", VA = "0x18C968C")]
	public void Show(int strokes, bool scoreOk)
	{
	}

	[Token(Token = "0x600184A")]
	[Address(RVA = "0x18C973C", Offset = "0x18C973C", VA = "0x18C973C")]
	private void OnDeepLinkActivated()
	{
	}

	[Token(Token = "0x600184B")]
	[Address(RVA = "0x18C9890", Offset = "0x18C9890", VA = "0x18C9890")]
	private IEnumerator ShowParticles()
	{
		return null;
	}

	[Token(Token = "0x600184C")]
	[Address(RVA = "0x18C9904", Offset = "0x18C9904", VA = "0x18C9904")]
	public IEnumerator WaitForClose()
	{
		return null;
	}

	[Token(Token = "0x600184D")]
	[Address(RVA = "0x18C9978", Offset = "0x18C9978", VA = "0x18C9978")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600184E")]
	[Address(RVA = "0x18C9740", Offset = "0x18C9740", VA = "0x18C9740")]
	public void Close()
	{
	}

	[Token(Token = "0x600184F")]
	[Address(RVA = "0x18C99D4", Offset = "0x18C99D4", VA = "0x18C99D4")]
	public DailyChallengeCompleted()
	{
	}

	[Token(Token = "0x6001850")]
	[Address(RVA = "0x18C99DC", Offset = "0x18C99DC", VA = "0x18C99DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x630D8", Offset = "0x630D8")]
	private void _003CShow_003Eb__5_0(float t)
	{
	}

	[Token(Token = "0x6001851")]
	[Address(RVA = "0x18C9AAC", Offset = "0x18C9AAC", VA = "0x18C9AAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x630E8", Offset = "0x630E8")]
	private void _003CWaitForClose_003Eb__8_0(float t)
	{
	}
}
