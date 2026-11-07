using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008E4")]
public class StatisticsBackgroundResizer : MonoBehaviour
{
	[Token(Token = "0x20008E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41DB8", Offset = "0x41DB8")]
	private sealed class _003CRecalculateWithDelay_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0x20")]
		public int frameDelay;

		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0x28")]
		public StatisticsBackgroundResizer _003C_003E4__this;

		[Token(Token = "0x17000457")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600292E")]
			[Address(RVA = "0x185ABD4", Offset = "0x185ABD4", VA = "0x185ABD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000458")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002930")]
			[Address(RVA = "0x185AC1C", Offset = "0x185AC1C", VA = "0x185AC1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600292B")]
		[Address(RVA = "0x185AAE4", Offset = "0x185AAE4", VA = "0x185AAE4")]
		[DebuggerHidden]
		public _003CRecalculateWithDelay_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600292C")]
		[Address(RVA = "0x185AB10", Offset = "0x185AB10", VA = "0x185AB10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600292D")]
		[Address(RVA = "0x185AB14", Offset = "0x185AB14", VA = "0x185AB14", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600292E")]
		[Address(RVA = "0x185ABD4", Offset = "0x185ABD4", VA = "0x185ABD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600292F")]
		[Address(RVA = "0x185ABDC", Offset = "0x185ABDC", VA = "0x185ABDC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002930")]
		[Address(RVA = "0x185AC1C", Offset = "0x185AC1C", VA = "0x185AC1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40030B0")]
	[FieldOffset(Offset = "0x18")]
	public float Padding;

	[Token(Token = "0x40030B1")]
	[FieldOffset(Offset = "0x20")]
	public HorizontalLayoutGroup Complete;

	[Token(Token = "0x40030B2")]
	[FieldOffset(Offset = "0x28")]
	public HorizontalLayoutGroup Playtime;

	[Token(Token = "0x40030B3")]
	[FieldOffset(Offset = "0x30")]
	public HorizontalLayoutGroup Strokes;

	[Token(Token = "0x40030B4")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform rectTransform;

	[Token(Token = "0x40030B5")]
	[FieldOffset(Offset = "0x40")]
	private float minimumWidth;

	[Token(Token = "0x40030B6")]
	[FieldOffset(Offset = "0x44")]
	private bool isFirst;

	[Token(Token = "0x40030B7")]
	[FieldOffset(Offset = "0x45")]
	private bool isSecond;

	[Token(Token = "0x6002923")]
	[Address(RVA = "0x16DD554", Offset = "0x16DD554", VA = "0x16DD554")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002924")]
	[Address(RVA = "0x16DD5D4", Offset = "0x16DD5D4", VA = "0x16DD5D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002925")]
	[Address(RVA = "0x16DD6D4", Offset = "0x16DD6D4", VA = "0x16DD6D4")]
	private void Recalculate(string language)
	{
	}

	[Token(Token = "0x6002926")]
	[Address(RVA = "0x16DD658", Offset = "0x16DD658", VA = "0x16DD658")]
	private IEnumerator RecalculateWithDelay(int frameDelay)
	{
		return null;
	}

	[Token(Token = "0x6002927")]
	[Address(RVA = "0x16DD758", Offset = "0x16DD758", VA = "0x16DD758")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002928")]
	[Address(RVA = "0x16DD86C", Offset = "0x16DD86C", VA = "0x16DD86C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002929")]
	[Address(RVA = "0x16DD980", Offset = "0x16DD980", VA = "0x16DD980")]
	private void Recalculate()
	{
	}

	[Token(Token = "0x600292A")]
	[Address(RVA = "0x16DDAB0", Offset = "0x16DDAB0", VA = "0x16DDAB0")]
	public StatisticsBackgroundResizer()
	{
	}
}
