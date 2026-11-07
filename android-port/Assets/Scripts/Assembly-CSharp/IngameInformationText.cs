using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000155")]
public class IngameInformationText : MonoBehaviour
{
	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DCA0", Offset = "0x3DCA0")]
	private sealed class _003CHideRoutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x28")]
		public IngameInformationText _003C_003E4__this;

		[Token(Token = "0x170000BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x17C63FC", Offset = "0x17C63FC", VA = "0x17C63FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x17C6444", Offset = "0x17C6444", VA = "0x17C6444", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x17C6310", Offset = "0x17C6310", VA = "0x17C6310")]
		[DebuggerHidden]
		public _003CHideRoutine_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x17C633C", Offset = "0x17C633C", VA = "0x17C633C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x17C6340", Offset = "0x17C6340", VA = "0x17C6340", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x17C63FC", Offset = "0x17C63FC", VA = "0x17C63FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x17C6404", Offset = "0x17C6404", VA = "0x17C6404", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x17C6444", Offset = "0x17C6444", VA = "0x17C6444", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x18")]
	public List<TextMeshProLocalized> Texts;

	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine hideRoutine;

	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x28")]
	public Camera UICamera;

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x14EC19C", Offset = "0x14EC19C", VA = "0x14EC19C")]
	public void ShowText(string textId, float duration, bool aboveTransition = false, params object[] arguments)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x14ED6E4", Offset = "0x14ED6E4", VA = "0x14ED6E4")]
	private IEnumerator HideRoutine(float duration)
	{
		return null;
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x14EB13C", Offset = "0x14EB13C", VA = "0x14EB13C")]
	public void ClearText()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x14ED768", Offset = "0x14ED768", VA = "0x14ED768")]
	public IngameInformationText()
	{
	}
}
