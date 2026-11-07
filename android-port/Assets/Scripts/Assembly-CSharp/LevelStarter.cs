using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004D7")]
public class LevelStarter : MonoBehaviour
{
	[Token(Token = "0x20004D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FEE4", Offset = "0x3FEE4")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x10")]
		public LevelDataContainer levels;

		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x18")]
		public int i;

		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__2;

		[Token(Token = "0x6001664")]
		[Address(RVA = "0x17E8840", Offset = "0x17E8840", VA = "0x17E8840")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6001665")]
		[Address(RVA = "0x17E8848", Offset = "0x17E8848", VA = "0x17E8848")]
		internal void _003CPlayLevels_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20004D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FEF4", Offset = "0x3FEF4")]
	private sealed class _003C_003Ec__DisplayClass2_1
	{
		[Token(Token = "0x4001978")]
		[FieldOffset(Offset = "0x10")]
		public LevelData nextLevel;

		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x17E88A4", Offset = "0x17E88A4", VA = "0x17E88A4")]
		public _003C_003Ec__DisplayClass2_1()
		{
		}

		[Token(Token = "0x6001667")]
		[Address(RVA = "0x17E88AC", Offset = "0x17E88AC", VA = "0x17E88AC")]
		internal void _003CPlayLevels_003Eb__1(Level.CompletedState s)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20004DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF04", Offset = "0x3FF04")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__2_0;

		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x10")]
		public static Action<bool> _003C_003E9__2_3;

		[Token(Token = "0x6001669")]
		[Address(RVA = "0x17E87D8", Offset = "0x17E87D8", VA = "0x17E87D8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600166A")]
		[Address(RVA = "0x17E87E0", Offset = "0x17E87E0", VA = "0x17E87E0")]
		internal void _003CPlayLevels_003Eb__2_0()
		{
		}

		[Token(Token = "0x600166B")]
		[Address(RVA = "0x17E883C", Offset = "0x17E883C", VA = "0x17E883C")]
		internal void _003CPlayLevels_003Eb__2_3(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x20004DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF14", Offset = "0x3FF14")]
	private sealed class _003CPlayLevels_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x20")]
		public LevelDataContainer levels;

		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x28")]
		public LevelStarter _003C_003E4__this;

		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x38")]
		public Action onDoneAction;

		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0x40")]
		private List<LevelData> _003ClevelsToPlay_003E5__2;

		[Token(Token = "0x17000279")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600166F")]
			[Address(RVA = "0x17E916C", Offset = "0x17E916C", VA = "0x17E916C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700027A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001671")]
			[Address(RVA = "0x17E91B4", Offset = "0x17E91B4", VA = "0x17E91B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600166C")]
		[Address(RVA = "0x17E896C", Offset = "0x17E896C", VA = "0x17E896C")]
		[DebuggerHidden]
		public _003CPlayLevels_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600166D")]
		[Address(RVA = "0x17E8998", Offset = "0x17E8998", VA = "0x17E8998", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600166E")]
		[Address(RVA = "0x17E899C", Offset = "0x17E899C", VA = "0x17E899C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600166F")]
		[Address(RVA = "0x17E916C", Offset = "0x17E916C", VA = "0x17E916C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001670")]
		[Address(RVA = "0x17E9174", Offset = "0x17E9174", VA = "0x17E9174", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001671")]
		[Address(RVA = "0x17E91B4", Offset = "0x17E91B4", VA = "0x17E91B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x6001660")]
	[Address(RVA = "0x15308BC", Offset = "0x15308BC", VA = "0x15308BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001661")]
	[Address(RVA = "0x1530A34", Offset = "0x1530A34", VA = "0x1530A34")]
	public void StartLevels(LevelDataContainer levels, Action onDoneAction)
	{
	}

	[Token(Token = "0x6001662")]
	[Address(RVA = "0x1530AC4", Offset = "0x1530AC4", VA = "0x1530AC4")]
	private IEnumerator PlayLevels(LevelDataContainer levels, Action onDoneAction)
	{
		return null;
	}

	[Token(Token = "0x6001663")]
	[Address(RVA = "0x1530B4C", Offset = "0x1530B4C", VA = "0x1530B4C")]
	public LevelStarter()
	{
	}
}
