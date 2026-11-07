using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000113")]
public class WaveController : MonoBehaviour
{
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB40", Offset = "0x3DB40")]
	private sealed class _003CStartWaves_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x20")]
		public WaveController _003C_003E4__this;

		[Token(Token = "0x170000A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x1876FE4", Offset = "0x1876FE4", VA = "0x1876FE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x187702C", Offset = "0x187702C", VA = "0x187702C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1876F18", Offset = "0x1876F18", VA = "0x1876F18")]
		[DebuggerHidden]
		public _003CStartWaves_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1876F44", Offset = "0x1876F44", VA = "0x1876F44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1876F48", Offset = "0x1876F48", VA = "0x1876F48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1876FE4", Offset = "0x1876FE4", VA = "0x1876FE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1876FEC", Offset = "0x1876FEC", VA = "0x1876FEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x187702C", Offset = "0x187702C", VA = "0x187702C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB50", Offset = "0x3DB50")]
	private sealed class _003CWaveRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x20")]
		public WaveController _003C_003E4__this;

		[Token(Token = "0x170000AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x187729C", Offset = "0x187729C", VA = "0x187729C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x18772E4", Offset = "0x18772E4", VA = "0x18772E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1877034", Offset = "0x1877034", VA = "0x1877034")]
		[DebuggerHidden]
		public _003CWaveRoutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1877060", Offset = "0x1877060", VA = "0x1877060", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1877064", Offset = "0x1877064", VA = "0x1877064", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x187729C", Offset = "0x187729C", VA = "0x187729C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x18772A4", Offset = "0x18772A4", VA = "0x18772A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x18772E4", Offset = "0x18772E4", VA = "0x18772E4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x18")]
	public int Waves;

	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x20")]
	public Animator Animator;

	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x28")]
	private int lastWaveIndex;

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x1750EEC", Offset = "0x1750EEC", VA = "0x1750EEC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x1750F94", Offset = "0x1750F94", VA = "0x1750F94")]
	public IEnumerator StartWaves()
	{
		return null;
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x1751008", Offset = "0x1751008", VA = "0x1751008")]
	private IEnumerator WaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x175107C", Offset = "0x175107C", VA = "0x175107C")]
	public WaveController()
	{
	}
}
