using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20002FD")]
public class HotdogCannonTargets : MonoBehaviour
{
	[Token(Token = "0x20002FE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EDEC", Offset = "0x3EDEC")]
	private sealed class _003CDo_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x20")]
		public HotdogCannonTargets _003C_003E4__this;

		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody _003Crigid_003E5__2;

		[Token(Token = "0x170001A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x17BFCD8", Offset = "0x17BFCD8", VA = "0x17BFCD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x17BFD20", Offset = "0x17BFD20", VA = "0x17BFD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x17BFB24", Offset = "0x17BFB24", VA = "0x17BFB24")]
		[DebuggerHidden]
		public _003CDo_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x17BFB50", Offset = "0x17BFB50", VA = "0x17BFB50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x17BFB54", Offset = "0x17BFB54", VA = "0x17BFB54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x17BFCD8", Offset = "0x17BFCD8", VA = "0x17BFCD8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x17BFCE0", Offset = "0x17BFCE0", VA = "0x17BFCE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x17BFD20", Offset = "0x17BFD20", VA = "0x17BFD20", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody Rigidbody;

	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform root;

	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float force;

	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform cannon;

	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator Animator;

	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent OnCollapse;

	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ToggleGenericRagdoll RagdollToggle;

	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioEventAsset sfxEventOnCollapse;

	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AudioEventAsset sfxOnSpeedup;

	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x60")]
	private bool hasCollapsed;

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x14DA6DC", Offset = "0x14DA6DC", VA = "0x14DA6DC")]
	public bool Collapse()
	{
		return default;
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x14DA834", Offset = "0x14DA834", VA = "0x14DA834")]
	private IEnumerator Do()
	{
		return null;
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x14DA8A8", Offset = "0x14DA8A8", VA = "0x14DA8A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x14DA934", Offset = "0x14DA934", VA = "0x14DA934")]
	public HotdogCannonTargets()
	{
	}
}
