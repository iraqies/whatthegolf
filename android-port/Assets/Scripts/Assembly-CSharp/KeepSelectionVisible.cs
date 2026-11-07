using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Triband.Core;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A3")]
public class KeepSelectionVisible : MonoBehaviour
{
	[Token(Token = "0x20001A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF70", Offset = "0x3DF70")]
	private sealed class _003CAnimateToPositionCR_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x20")]
		public KeepSelectionVisible _003C_003E4__this;

		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 targetPos;

		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cduration_003E5__2;

		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x34")]
		private float _003Ct_003E5__3;

		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 _003CoriginalPos_003E5__4;

		[Token(Token = "0x170000FC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x17CCC90", Offset = "0x17CCC90", VA = "0x17CCC90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000FD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x17CCCD8", Offset = "0x17CCCD8", VA = "0x17CCCD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x17CCB40", Offset = "0x17CCB40", VA = "0x17CCB40")]
		[DebuggerHidden]
		public _003CAnimateToPositionCR_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x17CCB6C", Offset = "0x17CCB6C", VA = "0x17CCB6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x17CCB70", Offset = "0x17CCB70", VA = "0x17CCB70", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x17CCC90", Offset = "0x17CCC90", VA = "0x17CCC90", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x17CCC98", Offset = "0x17CCC98", VA = "0x17CCC98", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x17CCCD8", Offset = "0x17CCCD8", VA = "0x17CCCD8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ScrollRect _scrollRect;

	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurveScriptableObj _animCurve;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _isHorizontal;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x30")]
	private GameObject _selected;

	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine _animateToPositionCR;

	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x40")]
	private int _layoutWaitHack;

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x14FCE70", Offset = "0x14FCE70", VA = "0x14FCE70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x14FD158", Offset = "0x14FD158", VA = "0x14FD158")]
	public void SnapToHorizontal(RectTransform target)
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x14FD608", Offset = "0x14FD608", VA = "0x14FD608")]
	private float GetOffset()
	{
		return default;
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x14FD3F0", Offset = "0x14FD3F0", VA = "0x14FD3F0")]
	public void SnapToVertical(RectTransform target)
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x14FD6D0", Offset = "0x14FD6D0", VA = "0x14FD6D0")]
	private IEnumerator AnimateToPositionCR(Vector2 targetPos)
	{
		return null;
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x14FD758", Offset = "0x14FD758", VA = "0x14FD758")]
	public KeepSelectionVisible()
	{
	}
}
