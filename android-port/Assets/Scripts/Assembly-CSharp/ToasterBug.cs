using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C57")]
public class ToasterBug : MonoBehaviour
{
	[Token(Token = "0x2000C58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440F8", Offset = "0x440F8")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x40043D6")]
		[FieldOffset(Offset = "0x10")]
		public ToasterBug _003C_003E4__this;

		[Token(Token = "0x40043D7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 handleStartPos;

		[Token(Token = "0x6003AB5")]
		[Address(RVA = "0x18684C4", Offset = "0x18684C4", VA = "0x18684C4")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6003AB6")]
		[Address(RVA = "0x18684CC", Offset = "0x18684CC", VA = "0x18684CC")]
		internal void _003CToastRoutine_003Eb__1(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C59")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44108", Offset = "0x44108")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40043D8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40043D9")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__8_0;

		[Token(Token = "0x6003AB8")]
		[Address(RVA = "0x18684B8", Offset = "0x18684B8", VA = "0x18684B8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003AB9")]
		[Address(RVA = "0x18684C0", Offset = "0x18684C0", VA = "0x18684C0")]
		internal void _003CToastRoutine_003Eb__8_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x2000C5A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44118", Offset = "0x44118")]
	private sealed class _003CToastRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40043DA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40043DB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40043DC")]
		[FieldOffset(Offset = "0x20")]
		public ToasterBug _003C_003E4__this;

		[Token(Token = "0x40043DD")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ctoasts_003E5__2;

		[Token(Token = "0x17000609")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x1868E54", Offset = "0x1868E54", VA = "0x1868E54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700060A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003ABF")]
			[Address(RVA = "0x1868E9C", Offset = "0x1868E9C", VA = "0x1868E9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003ABA")]
		[Address(RVA = "0x18685C4", Offset = "0x18685C4", VA = "0x18685C4")]
		[DebuggerHidden]
		public _003CToastRoutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003ABB")]
		[Address(RVA = "0x18685F0", Offset = "0x18685F0", VA = "0x18685F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003ABC")]
		[Address(RVA = "0x18685F4", Offset = "0x18685F4", VA = "0x18685F4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x1868E54", Offset = "0x1868E54", VA = "0x1868E54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x1868E5C", Offset = "0x1868E5C", VA = "0x1868E5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003ABF")]
		[Address(RVA = "0x1868E9C", Offset = "0x1868E9C", VA = "0x1868E9C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40043D0")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> Toasts;

	[Token(Token = "0x40043D1")]
	[FieldOffset(Offset = "0x20")]
	public Transform Handle;

	[Token(Token = "0x40043D2")]
	[FieldOffset(Offset = "0x28")]
	public float HandleEndHeight;

	[Token(Token = "0x40043D3")]
	[FieldOffset(Offset = "0x2C")]
	public float ToastForce;

	[Token(Token = "0x40043D4")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> ToastClip;

	[Token(Token = "0x40043D5")]
	[FieldOffset(Offset = "0x38")]
	private bool hasSprung;

	[Token(Token = "0x6003AB1")]
	[Address(RVA = "0x17199A4", Offset = "0x17199A4", VA = "0x17199A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AB2")]
	[Address(RVA = "0x1719B10", Offset = "0x1719B10", VA = "0x1719B10")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6B5AC", Offset = "0x6B5AC")]
	public void ToastBread()
	{
	}

	[Token(Token = "0x6003AB3")]
	[Address(RVA = "0x1719BA8", Offset = "0x1719BA8", VA = "0x1719BA8")]
	private IEnumerator ToastRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003AB4")]
	[Address(RVA = "0x1719C1C", Offset = "0x1719C1C", VA = "0x1719C1C")]
	public ToasterBug()
	{
	}
}
