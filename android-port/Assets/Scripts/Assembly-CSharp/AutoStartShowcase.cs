using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000B6D")]
public class AutoStartShowcase : MonoBehaviour
{
	[Token(Token = "0x2000B6E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x438D0", Offset = "0x438D0")]
	private sealed class _003CAutoStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003F6C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003F6D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003F6E")]
		[FieldOffset(Offset = "0x20")]
		public AutoStartShowcase _003C_003E4__this;

		[Token(Token = "0x170005CA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60036FF")]
			[Address(RVA = "0x177084C", Offset = "0x177084C", VA = "0x177084C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005CB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003701")]
			[Address(RVA = "0x1770894", Offset = "0x1770894", VA = "0x1770894", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x177070C", Offset = "0x177070C", VA = "0x177070C")]
		[DebuggerHidden]
		public _003CAutoStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x1770738", Offset = "0x1770738", VA = "0x1770738", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x177073C", Offset = "0x177073C", VA = "0x177073C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x177084C", Offset = "0x177084C", VA = "0x177084C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003700")]
		[Address(RVA = "0x1770854", Offset = "0x1770854", VA = "0x1770854", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003701")]
		[Address(RVA = "0x1770894", Offset = "0x1770894", VA = "0x1770894", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003F6A")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent AutostartEvent;

	[Token(Token = "0x4003F6B")]
	[FieldOffset(Offset = "0x20")]
	private string activeSceneName;

	[Token(Token = "0x60036F8")]
	[Address(RVA = "0x1515A70", Offset = "0x1515A70", VA = "0x1515A70")]
	private void Start()
	{
	}

	[Token(Token = "0x60036F9")]
	[Address(RVA = "0x1515B98", Offset = "0x1515B98", VA = "0x1515B98")]
	private IEnumerator AutoStart()
	{
		return null;
	}

	[Token(Token = "0x60036FA")]
	[Address(RVA = "0x1515C0C", Offset = "0x1515C0C", VA = "0x1515C0C")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x60036FB")]
	[Address(RVA = "0x1515CE4", Offset = "0x1515CE4", VA = "0x1515CE4")]
	public AutoStartShowcase()
	{
	}
}
