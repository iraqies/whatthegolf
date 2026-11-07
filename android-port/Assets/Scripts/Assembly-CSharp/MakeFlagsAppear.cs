using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002DF")]
public class MakeFlagsAppear : MonoBehaviour
{
	[Token(Token = "0x20002E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED1C", Offset = "0x3ED1C")]
	private sealed class _003CAppearCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x20")]
		public MakeFlagsAppear _003C_003E4__this;

		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x28")]
		private List<Animator>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000192")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x17F2E2C", Offset = "0x17F2E2C", VA = "0x17F2E2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000193")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x17F2E74", Offset = "0x17F2E74", VA = "0x17F2E74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x17F2A4C", Offset = "0x17F2A4C", VA = "0x17F2A4C")]
		[DebuggerHidden]
		public _003CAppearCR_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x17F2A78", Offset = "0x17F2A78", VA = "0x17F2A78", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x17F2B4C", Offset = "0x17F2B4C", VA = "0x17F2B4C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x17F2AF0", Offset = "0x17F2AF0", VA = "0x17F2AF0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x17F2E2C", Offset = "0x17F2E2C", VA = "0x17F2E2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x17F2E34", Offset = "0x17F2E34", VA = "0x17F2E34", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x17F2E74", Offset = "0x17F2E74", VA = "0x17F2E74", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform AppearingThingsContainer;

	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x20")]
	private List<Animator> appearingAnimators;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection FlagAppearSound;

	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x155A034", Offset = "0x155A034", VA = "0x155A034")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x155A0CC", Offset = "0x155A0CC", VA = "0x155A0CC")]
	public void Appear()
	{
	}

	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x155A148", Offset = "0x155A148", VA = "0x155A148")]
	private IEnumerator AppearCR()
	{
		return null;
	}

	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x155A1BC", Offset = "0x155A1BC", VA = "0x155A1BC")]
	public MakeFlagsAppear()
	{
	}
}
