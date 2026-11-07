using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004E5")]
public class LocalizationDelayedResizer : MonoBehaviour
{
	[Token(Token = "0x20004E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF84", Offset = "0x3FF84")]
	private sealed class _003CResizeCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001999")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400199A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x20")]
		public LocalizationDelayedResizer _003C_003E4__this;

		[Token(Token = "0x1700027C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600169E")]
			[Address(RVA = "0x17ED144", Offset = "0x17ED144", VA = "0x17ED144", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700027D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60016A0")]
			[Address(RVA = "0x17ED18C", Offset = "0x17ED18C", VA = "0x17ED18C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600169B")]
		[Address(RVA = "0x17ED010", Offset = "0x17ED010", VA = "0x17ED010")]
		[DebuggerHidden]
		public _003CResizeCR_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600169C")]
		[Address(RVA = "0x17ED03C", Offset = "0x17ED03C", VA = "0x17ED03C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600169D")]
		[Address(RVA = "0x17ED040", Offset = "0x17ED040", VA = "0x17ED040", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600169E")]
		[Address(RVA = "0x17ED144", Offset = "0x17ED144", VA = "0x17ED144", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600169F")]
		[Address(RVA = "0x17ED14C", Offset = "0x17ED14C", VA = "0x17ED14C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x17ED18C", Offset = "0x17ED18C", VA = "0x17ED18C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProLocalized _text;

	[Token(Token = "0x4001998")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform _rebuildTransform;

	[Token(Token = "0x6001696")]
	[Address(RVA = "0x153D42C", Offset = "0x153D42C", VA = "0x153D42C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001697")]
	[Address(RVA = "0x153D5E8", Offset = "0x153D5E8", VA = "0x153D5E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001698")]
	[Address(RVA = "0x153D56C", Offset = "0x153D56C", VA = "0x153D56C")]
	private void Resize()
	{
	}

	[Token(Token = "0x6001699")]
	[Address(RVA = "0x153D6E0", Offset = "0x153D6E0", VA = "0x153D6E0")]
	private IEnumerator ResizeCR()
	{
		return null;
	}

	[Token(Token = "0x600169A")]
	[Address(RVA = "0x153D754", Offset = "0x153D754", VA = "0x153D754")]
	public LocalizationDelayedResizer()
	{
	}
}
