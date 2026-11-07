using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E79")]
public class CycleMaterialOrder : MonoBehaviour
{
	[Token(Token = "0x2000E7A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45098", Offset = "0x45098")]
	private sealed class _003CChangeMaterial_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E4C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E4D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E4E")]
		[FieldOffset(Offset = "0x20")]
		public CycleMaterialOrder _003C_003E4__this;

		[Token(Token = "0x170006F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60043A8")]
			[Address(RVA = "0x1793E98", Offset = "0x1793E98", VA = "0x1793E98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60043AA")]
			[Address(RVA = "0x1793EE0", Offset = "0x1793EE0", VA = "0x1793EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x1793D68", Offset = "0x1793D68", VA = "0x1793D68")]
		[DebuggerHidden]
		public _003CChangeMaterial_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x1793D94", Offset = "0x1793D94", VA = "0x1793D94", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x1793D98", Offset = "0x1793D98", VA = "0x1793D98", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x1793E98", Offset = "0x1793E98", VA = "0x1793E98", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x1793EA0", Offset = "0x1793EA0", VA = "0x1793EA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x1793EE0", Offset = "0x1793EE0", VA = "0x1793EE0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E46")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer meshrenderer;

	[Token(Token = "0x4004E47")]
	[FieldOffset(Offset = "0x20")]
	public Material[] materialList;

	[Token(Token = "0x4004E48")]
	[FieldOffset(Offset = "0x28")]
	private float nextActionTime;

	[Token(Token = "0x4004E49")]
	[FieldOffset(Offset = "0x2C")]
	public float interval;

	[Token(Token = "0x4004E4A")]
	[FieldOffset(Offset = "0x30")]
	public int startOffset;

	[Token(Token = "0x4004E4B")]
	[FieldOffset(Offset = "0x34")]
	private int materialIndex;

	[Token(Token = "0x60043A2")]
	[Address(RVA = "0x18C79F4", Offset = "0x18C79F4", VA = "0x18C79F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60043A3")]
	[Address(RVA = "0x18C7AB0", Offset = "0x18C7AB0", VA = "0x18C7AB0")]
	private IEnumerator ChangeMaterial()
	{
		return null;
	}

	[Token(Token = "0x60043A4")]
	[Address(RVA = "0x18C7B24", Offset = "0x18C7B24", VA = "0x18C7B24")]
	public CycleMaterialOrder()
	{
	}
}
