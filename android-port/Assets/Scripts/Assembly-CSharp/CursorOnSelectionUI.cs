using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x200018B")]
public class CursorOnSelectionUI : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE40", Offset = "0x3DE40")]
	private sealed class _003CDeselectWhenTouchEndedCR_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x20")]
		public CursorOnSelectionUI _003C_003E4__this;

		[Token(Token = "0x170000EC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1793BA0", Offset = "0x1793BA0", VA = "0x1793BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000ED")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1793BE8", Offset = "0x1793BE8", VA = "0x1793BE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1793954", Offset = "0x1793954", VA = "0x1793954")]
		[DebuggerHidden]
		public _003CDeselectWhenTouchEndedCR_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1793980", Offset = "0x1793980", VA = "0x1793980", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1793984", Offset = "0x1793984", VA = "0x1793984", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1793BA0", Offset = "0x1793BA0", VA = "0x1793BA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1793BA8", Offset = "0x1793BA8", VA = "0x1793BA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1793BE8", Offset = "0x1793BE8", VA = "0x1793BE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE50", Offset = "0x3DE50")]
	private sealed class _003CAnimCR_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x20")]
		public CursorOnSelectionUI _003C_003E4__this;

		[Token(Token = "0x170000EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1793904", Offset = "0x1793904", VA = "0x1793904", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x179394C", Offset = "0x179394C", VA = "0x179394C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x17937FC", Offset = "0x17937FC", VA = "0x17937FC")]
		[DebuggerHidden]
		public _003CAnimCR_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1793828", Offset = "0x1793828", VA = "0x1793828", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x179382C", Offset = "0x179382C", VA = "0x179382C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1793904", Offset = "0x1793904", VA = "0x1793904", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x179390C", Offset = "0x179390C", VA = "0x179390C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x179394C", Offset = "0x179394C", VA = "0x179394C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Graphic _cursor;

	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _offset;

	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x24")]
	private float _speed;

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 _offsetMaxCached;

	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 _offsetMinCached;

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine _animCR;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine _fadeCR;

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x18C5854", Offset = "0x18C5854", VA = "0x18C5854")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x18C58B4", Offset = "0x18C58B4", VA = "0x18C58B4", Slot = "5")]
	public void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x18C58B8", Offset = "0x18C58B8", VA = "0x18C58B8")]
	private void HideCursor()
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x18C597C", Offset = "0x18C597C", VA = "0x18C597C")]
	private void ShowCursor()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x18C5A98", Offset = "0x18C5A98", VA = "0x18C5A98", Slot = "4")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x18C5C28", Offset = "0x18C5C28", VA = "0x18C5C28")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x18C5BB4", Offset = "0x18C5BB4", VA = "0x18C5BB4")]
	private IEnumerator DeselectWhenTouchEndedCR()
	{
		return null;
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x18C5A24", Offset = "0x18C5A24", VA = "0x18C5A24")]
	private IEnumerator AnimCR()
	{
		return null;
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x18C5C2C", Offset = "0x18C5C2C", VA = "0x18C5C2C", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x18C5D20", Offset = "0x18C5D20", VA = "0x18C5D20", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x18C5ECC", Offset = "0x18C5ECC", VA = "0x18C5ECC")]
	public CursorOnSelectionUI()
	{
	}
}
