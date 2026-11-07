using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008BA")]
public class DialogBase : MonoBehaviour
{
	[Token(Token = "0x20008BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41BE0", Offset = "0x41BE0")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x10")]
		public ButtonSelectInfo b;

		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x18")]
		public DialogBase _003C_003E4__this;

		[Token(Token = "0x6002849")]
		[Address(RVA = "0x179BA74", Offset = "0x179BA74", VA = "0x179BA74")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600284A")]
		[Address(RVA = "0x179BA7C", Offset = "0x179BA7C", VA = "0x179BA7C")]
		internal void _003CStart_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20008BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41BF0", Offset = "0x41BF0")]
	private sealed class _003CWaitForDialogToBeClosed_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x20")]
		public DialogBase _003C_003E4__this;

		[Token(Token = "0x1700043F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600284E")]
			[Address(RVA = "0x179BBA8", Offset = "0x179BBA8", VA = "0x179BBA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000440")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002850")]
			[Address(RVA = "0x179BBF0", Offset = "0x179BBF0", VA = "0x179BBF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600284B")]
		[Address(RVA = "0x179BA9C", Offset = "0x179BA9C", VA = "0x179BA9C")]
		[DebuggerHidden]
		public _003CWaitForDialogToBeClosed_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600284C")]
		[Address(RVA = "0x179BAC8", Offset = "0x179BAC8", VA = "0x179BAC8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600284D")]
		[Address(RVA = "0x179BACC", Offset = "0x179BACC", VA = "0x179BACC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600284E")]
		[Address(RVA = "0x179BBA8", Offset = "0x179BBA8", VA = "0x179BBA8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600284F")]
		[Address(RVA = "0x179BBB0", Offset = "0x179BBB0", VA = "0x179BBB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002850")]
		[Address(RVA = "0x179BBF0", Offset = "0x179BBF0", VA = "0x179BBF0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002FDC")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F6AC", Offset = "0x4F6AC")]
	private static bool IsOpen__BackingField;

	[Token(Token = "0x4002FDD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_DialogContainer;

	[Token(Token = "0x4002FDE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Selectable m_DefaultFocus;

	[Token(Token = "0x4002FDF")]
	[FieldOffset(Offset = "0x28")]
	protected ButtonSelectInfo currentSelection;

	[Token(Token = "0x4002FE0")]
	[FieldOffset(Offset = "0x30")]
	public List<ButtonSelectInfo> selectables;

	[Token(Token = "0x4002FE1")]
	[FieldOffset(Offset = "0x38")]
	private List<bool> submitButtonPressed;

	[Token(Token = "0x4002FE2")]
	[FieldOffset(Offset = "0x40")]
	private bool requestHide;

	[Token(Token = "0x1700043E")]
	public static bool IsOpen
	{
		[Token(Token = "0x600283E")]
		[Address(RVA = "0x18DBB9C", Offset = "0x18DBB9C", VA = "0x18DBB9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x670E4", Offset = "0x670E4")]
		get
		{
			return default;
		}
		[Token(Token = "0x600283F")]
		[Address(RVA = "0x18DBBE8", Offset = "0x18DBBE8", VA = "0x18DBBE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x670F4", Offset = "0x670F4")]
		protected set
		{
		}
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0x18DBC40", Offset = "0x18DBC40", VA = "0x18DBC40")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x67104", Offset = "0x67104")]
	private static void Init()
	{
	}

	[Token(Token = "0x6002841")]
	[Address(RVA = "0x18DBC8C", Offset = "0x18DBC8C", VA = "0x18DBC8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002842")]
	[Address(RVA = "0x18DBE80", Offset = "0x18DBE80", VA = "0x18DBE80")]
	public void Show()
	{
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0x18DC104", Offset = "0x18DC104", VA = "0x18DC104")]
	public void Hide()
	{
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0x18DC1EC", Offset = "0x18DC1EC", VA = "0x18DC1EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002845")]
	[Address(RVA = "0x18DC1F0", Offset = "0x18DC1F0", VA = "0x18DC1F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002846")]
	[Address(RVA = "0x18DC1F4", Offset = "0x18DC1F4", VA = "0x18DC1F4", Slot = "4")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6002847")]
	[Address(RVA = "0x18DC3E0", Offset = "0x18DC3E0", VA = "0x18DC3E0")]
	public IEnumerator WaitForDialogToBeClosed()
	{
		return null;
	}

	[Token(Token = "0x6002848")]
	[Address(RVA = "0x18DC454", Offset = "0x18DC454", VA = "0x18DC454")]
	public DialogBase()
	{
	}
}
