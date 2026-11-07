using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007C5")]
public class MagicCupSorter : MonoBehaviour
{
	[Token(Token = "0x20007C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x415E0", Offset = "0x415E0")]
	private sealed class _003CStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400292F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002930")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002931")]
		[FieldOffset(Offset = "0x20")]
		public MagicCupSorter _003C_003E4__this;

		[Token(Token = "0x4002932")]
		[FieldOffset(Offset = "0x28")]
		private GolfBallController _003Ccontroller_003E5__2;

		[Token(Token = "0x4002933")]
		[FieldOffset(Offset = "0x30")]
		private List<MagicCup>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x170003E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023A3")]
			[Address(RVA = "0x17F0648", Offset = "0x17F0648", VA = "0x17F0648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023A5")]
			[Address(RVA = "0x17F0690", Offset = "0x17F0690", VA = "0x17F0690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600239F")]
		[Address(RVA = "0x17EFFB0", Offset = "0x17EFFB0", VA = "0x17EFFB0")]
		[DebuggerHidden]
		public _003CStart_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x17EFFDC", Offset = "0x17EFFDC", VA = "0x17EFFDC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x17F00B0", Offset = "0x17F00B0", VA = "0x17F00B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x17F0054", Offset = "0x17F0054", VA = "0x17F0054")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x17F0648", Offset = "0x17F0648", VA = "0x17F0648", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x17F0650", Offset = "0x17F0650", VA = "0x17F0650", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x17F0690", Offset = "0x17F0690", VA = "0x17F0690", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20007C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x415F0", Offset = "0x415F0")]
	private sealed class _003CSortRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002934")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002935")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002936")]
		[FieldOffset(Offset = "0x20")]
		public MagicCupSorter _003C_003E4__this;

		[Token(Token = "0x4002937")]
		[FieldOffset(Offset = "0x28")]
		private int _003Csorts_003E5__2;

		[Token(Token = "0x170003E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023A9")]
			[Address(RVA = "0x17EFF60", Offset = "0x17EFF60", VA = "0x17EFF60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023AB")]
			[Address(RVA = "0x17EFFA8", Offset = "0x17EFFA8", VA = "0x17EFFA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x17EFE94", Offset = "0x17EFE94", VA = "0x17EFE94")]
		[DebuggerHidden]
		public _003CSortRoutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x17EFEC0", Offset = "0x17EFEC0", VA = "0x17EFEC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x17EFEC4", Offset = "0x17EFEC4", VA = "0x17EFEC4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x17EFF60", Offset = "0x17EFF60", VA = "0x17EFF60", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x17EFF68", Offset = "0x17EFF68", VA = "0x17EFF68", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x17EFFA8", Offset = "0x17EFFA8", VA = "0x17EFFA8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20007C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41600", Offset = "0x41600")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4002938")]
		[FieldOffset(Offset = "0x10")]
		public MagicCupSorter _003C_003E4__this;

		[Token(Token = "0x4002939")]
		[FieldOffset(Offset = "0x18")]
		public int firstCupIndex;

		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0x20")]
		public Transform firstCupStartPosition;

		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 middleOffset;

		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x34")]
		public float firstCupDirection;

		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x38")]
		public Transform secondCupStartPosition;

		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x40")]
		public int secondCupIndex;

		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x44")]
		public float secondCupDirection;

		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x17EF78C", Offset = "0x17EF78C", VA = "0x17EF78C")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x17EF794", Offset = "0x17EF794", VA = "0x17EF794")]
		internal void _003CSingleSortRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20007C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41610", Offset = "0x41610")]
	private sealed class _003CSingleSortRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x20")]
		public MagicCupSorter _003C_003E4__this;

		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x170003E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023B1")]
			[Address(RVA = "0x17EFE44", Offset = "0x17EFE44", VA = "0x17EFE44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023B3")]
			[Address(RVA = "0x17EFE8C", Offset = "0x17EFE8C", VA = "0x17EFE8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x17EF9C8", Offset = "0x17EF9C8", VA = "0x17EF9C8")]
		[DebuggerHidden]
		public _003CSingleSortRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x17EF9F4", Offset = "0x17EF9F4", VA = "0x17EF9F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x17EF9F8", Offset = "0x17EF9F8", VA = "0x17EF9F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x17EFE44", Offset = "0x17EFE44", VA = "0x17EFE44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x17EFE4C", Offset = "0x17EFE4C", VA = "0x17EFE4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x17EFE8C", Offset = "0x17EFE8C", VA = "0x17EFE8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20007CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41620", Offset = "0x41620")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x10")]
		public MagicCupSorter _003C_003E4__this;

		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x4002946")]
		[FieldOffset(Offset = "0x20")]
		public Transform start;

		[Token(Token = "0x4002947")]
		[FieldOffset(Offset = "0x28")]
		public Transform end;

		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x17EF5A0", Offset = "0x17EF5A0", VA = "0x17EF5A0")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x17EF5A8", Offset = "0x17EF5A8", VA = "0x17EF5A8")]
		internal void _003CToggleCup_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20007CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41630", Offset = "0x41630")]
	private sealed class _003CToggleCup_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002949")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400294A")]
		[FieldOffset(Offset = "0x20")]
		public MagicCupSorter _003C_003E4__this;

		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0x28")]
		public MagicCup cupHit;

		[Token(Token = "0x400294C")]
		[FieldOffset(Offset = "0x30")]
		public bool showContents;

		[Token(Token = "0x400294D")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		[Token(Token = "0x170003EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023B9")]
			[Address(RVA = "0x17F0A5C", Offset = "0x17F0A5C", VA = "0x17F0A5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023BB")]
			[Address(RVA = "0x17F0AA4", Offset = "0x17F0AA4", VA = "0x17F0AA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x17F0698", Offset = "0x17F0698", VA = "0x17F0698")]
		[DebuggerHidden]
		public _003CToggleCup_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x17F06C4", Offset = "0x17F06C4", VA = "0x17F06C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x17F06C8", Offset = "0x17F06C8", VA = "0x17F06C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x17F0A5C", Offset = "0x17F0A5C", VA = "0x17F0A5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x17F0A64", Offset = "0x17F0A64", VA = "0x17F0A64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x17F0AA4", Offset = "0x17F0AA4", VA = "0x17F0AA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002928")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> ShowPositions;

	[Token(Token = "0x4002929")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> HidePositions;

	[Token(Token = "0x400292A")]
	[FieldOffset(Offset = "0x28")]
	public List<MagicCup> MagicCups;

	[Token(Token = "0x400292B")]
	[FieldOffset(Offset = "0x30")]
	public int Iterations;

	[Token(Token = "0x400292C")]
	[FieldOffset(Offset = "0x34")]
	public float Speed;

	[Token(Token = "0x400292D")]
	[FieldOffset(Offset = "0x38")]
	public float MoveRange;

	[Token(Token = "0x400292E")]
	[FieldOffset(Offset = "0x3C")]
	private bool routineRunning;

	[Token(Token = "0x6002399")]
	[Address(RVA = "0x15529F0", Offset = "0x15529F0", VA = "0x15529F0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600239A")]
	[Address(RVA = "0x1552A64", Offset = "0x1552A64", VA = "0x1552A64")]
	private IEnumerator SortRoutine()
	{
		return null;
	}

	[Token(Token = "0x600239B")]
	[Address(RVA = "0x1552AD8", Offset = "0x1552AD8", VA = "0x1552AD8")]
	private IEnumerator SingleSortRoutine()
	{
		return null;
	}

	[Token(Token = "0x600239C")]
	[Address(RVA = "0x1552460", Offset = "0x1552460", VA = "0x1552460")]
	public void TryShow(MagicCup cupHit)
	{
	}

	[Token(Token = "0x600239D")]
	[Address(RVA = "0x1552B4C", Offset = "0x1552B4C", VA = "0x1552B4C")]
	private IEnumerator ToggleCup(MagicCup cupHit, bool showContents)
	{
		return null;
	}

	[Token(Token = "0x600239E")]
	[Address(RVA = "0x1552BD4", Offset = "0x1552BD4", VA = "0x1552BD4")]
	public MagicCupSorter()
	{
	}
}
