using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005EE")]
public class CrabEyes : MonoBehaviour
{
	[Token(Token = "0x20005EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40900", Offset = "0x40900")]
	private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E59")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E5A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E5B")]
		[FieldOffset(Offset = "0x20")]
		public CrabEyes _003C_003E4__this;

		[Token(Token = "0x170002F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B02")]
			[Address(RVA = "0x179172C", Offset = "0x179172C", VA = "0x179172C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B04")]
			[Address(RVA = "0x1791774", Offset = "0x1791774", VA = "0x1791774", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x1791564", Offset = "0x1791564", VA = "0x1791564")]
		[DebuggerHidden]
		public _003CStart_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x1791590", Offset = "0x1791590", VA = "0x1791590", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x1791594", Offset = "0x1791594", VA = "0x1791594", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x179172C", Offset = "0x179172C", VA = "0x179172C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x1791734", Offset = "0x1791734", VA = "0x1791734", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x1791774", Offset = "0x1791774", VA = "0x1791774", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001E58")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] eyes;

	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x18BB3DC", Offset = "0x18BB3DC", VA = "0x18BB3DC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x18BB450", Offset = "0x18BB450", VA = "0x18BB450")]
	public CrabEyes()
	{
	}
}
