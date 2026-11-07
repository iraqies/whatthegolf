using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAF")]
[ExecuteAlways]
public class AlignObjectWithScreenEdge : MonoBehaviour
{
	[Token(Token = "0x2000BB0")]
	public enum EdgeEnum
	{
		[Token(Token = "0x400412E")]
		Top = 0,
		[Token(Token = "0x400412F")]
		Bottom = 1,
		[Token(Token = "0x4004130")]
		Left = 2,
		[Token(Token = "0x4004131")]
		Right = 3
	}

	[Token(Token = "0x2000BB1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43BE0", Offset = "0x43BE0")]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004132")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004133")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004134")]
		[FieldOffset(Offset = "0x20")]
		public AlignObjectWithScreenEdge _003C_003E4__this;

		[Token(Token = "0x170005EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600386A")]
			[Address(RVA = "0x1768FE0", Offset = "0x1768FE0", VA = "0x1768FE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600386C")]
			[Address(RVA = "0x1769028", Offset = "0x1769028", VA = "0x1769028", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003867")]
		[Address(RVA = "0x1768F50", Offset = "0x1768F50", VA = "0x1768F50")]
		[DebuggerHidden]
		public _003CStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003868")]
		[Address(RVA = "0x1768F7C", Offset = "0x1768F7C", VA = "0x1768F7C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003869")]
		[Address(RVA = "0x1768F80", Offset = "0x1768F80", VA = "0x1768F80", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600386A")]
		[Address(RVA = "0x1768FE0", Offset = "0x1768FE0", VA = "0x1768FE0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600386B")]
		[Address(RVA = "0x1768FE8", Offset = "0x1768FE8", VA = "0x1768FE8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600386C")]
		[Address(RVA = "0x1769028", Offset = "0x1769028", VA = "0x1769028", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400412B")]
	[FieldOffset(Offset = "0x18")]
	public EdgeEnum EdgeToAlignTo;

	[Token(Token = "0x400412C")]
	[FieldOffset(Offset = "0x1C")]
	public bool ForceUpdate;

	[Token(Token = "0x6003863")]
	[Address(RVA = "0x140D0A0", Offset = "0x140D0A0", VA = "0x140D0A0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003864")]
	[Address(RVA = "0x140D114", Offset = "0x140D114", VA = "0x140D114")]
	private void Update()
	{
	}

	[Token(Token = "0x6003865")]
	[Address(RVA = "0x140D144", Offset = "0x140D144", VA = "0x140D144")]
	private void SetPosition()
	{
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0x140D234", Offset = "0x140D234", VA = "0x140D234")]
	public AlignObjectWithScreenEdge()
	{
	}
}
