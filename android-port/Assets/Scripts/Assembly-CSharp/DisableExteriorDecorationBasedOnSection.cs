using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009A5")]
public class DisableExteriorDecorationBasedOnSection : MonoBehaviour
{
	[Token(Token = "0x20009A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42650", Offset = "0x42650")]
	private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x20")]
		public DisableExteriorDecorationBasedOnSection _003C_003E4__this;

		[Token(Token = "0x170004B2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D63")]
			[Address(RVA = "0x179C3BC", Offset = "0x179C3BC", VA = "0x179C3BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004B3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D65")]
			[Address(RVA = "0x179C404", Offset = "0x179C404", VA = "0x179C404", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x179C16C", Offset = "0x179C16C", VA = "0x179C16C")]
		[DebuggerHidden]
		public _003CStart_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x179C198", Offset = "0x179C198", VA = "0x179C198", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x179C19C", Offset = "0x179C19C", VA = "0x179C19C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x179C3BC", Offset = "0x179C3BC", VA = "0x179C3BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x179C3C4", Offset = "0x179C3C4", VA = "0x179C3C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x179C404", Offset = "0x179C404", VA = "0x179C404", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003523")]
	[FieldOffset(Offset = "0x18")]
	public HubSection section;

	[Token(Token = "0x4003524")]
	[FieldOffset(Offset = "0x20")]
	private RotateAxis2D[] fans;

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x18DD22C", Offset = "0x18DD22C", VA = "0x18DD22C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x18DD2A0", Offset = "0x18DD2A0", VA = "0x18DD2A0")]
	private void Section_OnSectionCullingUpdate(bool active)
	{
	}

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x18DD2A4", Offset = "0x18DD2A4", VA = "0x18DD2A4")]
	private void SetFanStatus(bool active)
	{
	}

	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x18DD3C0", Offset = "0x18DD3C0", VA = "0x18DD3C0")]
	public DisableExteriorDecorationBasedOnSection()
	{
	}
}
