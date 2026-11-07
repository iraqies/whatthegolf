using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E77")]
public class CycleMaterial : MonoBehaviour
{
	[Token(Token = "0x2000E78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45088", Offset = "0x45088")]
	private sealed class _003CChangeMaterial_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E43")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E44")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E45")]
		[FieldOffset(Offset = "0x20")]
		public CycleMaterial _003C_003E4__this;

		[Token(Token = "0x170006EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600439F")]
			[Address(RVA = "0x1793D18", Offset = "0x1793D18", VA = "0x1793D18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60043A1")]
			[Address(RVA = "0x1793D60", Offset = "0x1793D60", VA = "0x1793D60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600439C")]
		[Address(RVA = "0x1793BF0", Offset = "0x1793BF0", VA = "0x1793BF0")]
		[DebuggerHidden]
		public _003CChangeMaterial_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600439D")]
		[Address(RVA = "0x1793C1C", Offset = "0x1793C1C", VA = "0x1793C1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600439E")]
		[Address(RVA = "0x1793C20", Offset = "0x1793C20", VA = "0x1793C20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600439F")]
		[Address(RVA = "0x1793D18", Offset = "0x1793D18", VA = "0x1793D18", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x1793D20", Offset = "0x1793D20", VA = "0x1793D20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x1793D60", Offset = "0x1793D60", VA = "0x1793D60", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E3E")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer meshrenderer;

	[Token(Token = "0x4004E3F")]
	[FieldOffset(Offset = "0x20")]
	public Material[] materialList;

	[Token(Token = "0x4004E40")]
	[FieldOffset(Offset = "0x28")]
	private float nextActionTime;

	[Token(Token = "0x4004E41")]
	[FieldOffset(Offset = "0x2C")]
	public float interval;

	[Token(Token = "0x4004E42")]
	[FieldOffset(Offset = "0x30")]
	private int materialIndex;

	[Token(Token = "0x6004399")]
	[Address(RVA = "0x18C78BC", Offset = "0x18C78BC", VA = "0x18C78BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600439A")]
	[Address(RVA = "0x18C7970", Offset = "0x18C7970", VA = "0x18C7970")]
	private IEnumerator ChangeMaterial()
	{
		return null;
	}

	[Token(Token = "0x600439B")]
	[Address(RVA = "0x18C79E4", Offset = "0x18C79E4", VA = "0x18C79E4")]
	public CycleMaterial()
	{
	}
}
