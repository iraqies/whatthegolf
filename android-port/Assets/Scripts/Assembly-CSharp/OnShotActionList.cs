using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200030A")]
public class OnShotActionList : MonoBehaviour
{
	[Token(Token = "0x200030B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EE2C", Offset = "0x3EE2C")]
	private sealed class _003CDo_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x20")]
		public OnShotActionList _003C_003E4__this;

		[Token(Token = "0x170001A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E05")]
			[Address(RVA = "0x180ABC0", Offset = "0x180ABC0", VA = "0x180ABC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E07")]
			[Address(RVA = "0x180AC08", Offset = "0x180AC08", VA = "0x180AC08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x180AA94", Offset = "0x180AA94", VA = "0x180AA94")]
		[DebuggerHidden]
		public _003CDo_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x180AAC0", Offset = "0x180AAC0", VA = "0x180AAC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x180AAC4", Offset = "0x180AAC4", VA = "0x180AAC4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x180ABC0", Offset = "0x180ABC0", VA = "0x180ABC0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x180ABC8", Offset = "0x180ABC8", VA = "0x180ABC8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x180AC08", Offset = "0x180AC08", VA = "0x180AC08", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController controller;

	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x28")]
	public List<UnityEvent> events;

	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x30")]
	private int indx;

	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x159A8F4", Offset = "0x159A8F4", VA = "0x159A8F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x159A9D8", Offset = "0x159A9D8", VA = "0x159A9D8")]
	public void UpdateController(GolfBallController newController)
	{
	}

	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x159AB14", Offset = "0x159AB14", VA = "0x159AB14")]
	private void OnShoot(Vector3 v)
	{
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x159ABD4", Offset = "0x159ABD4", VA = "0x159ABD4")]
	private IEnumerator Do()
	{
		return null;
	}

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x159AC48", Offset = "0x159AC48", VA = "0x159AC48")]
	public OnShotActionList()
	{
	}
}
