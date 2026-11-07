using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C3")]
public class LobbyCrownStack : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D860", Offset = "0x3D860")]
	private sealed class _003CCollapseRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x20")]
		public LobbyCrownStack _003C_003E4__this;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody[] _003C_003E7__wrap1;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x30")]
		private int _003C_003E7__wrap2;

		[Token(Token = "0x17000087")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x17ECA2C", Offset = "0x17ECA2C", VA = "0x17ECA2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000088")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x17ECA74", Offset = "0x17ECA74", VA = "0x17ECA74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x17EC89C", Offset = "0x17EC89C", VA = "0x17EC89C")]
		[DebuggerHidden]
		public _003CCollapseRoutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x17EC8C8", Offset = "0x17EC8C8", VA = "0x17EC8C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x17EC8CC", Offset = "0x17EC8CC", VA = "0x17EC8CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17ECA2C", Offset = "0x17ECA2C", VA = "0x17ECA2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17ECA34", Offset = "0x17ECA34", VA = "0x17ECA34", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x17ECA74", Offset = "0x17ECA74", VA = "0x17ECA74", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody[] StackRigidbodies;

	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x20")]
	public bool StackCollapsed;

	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x28")]
	public Transform ContainerTransform;

	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x30")]
	public int CrownsOnStack;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x1539D78", Offset = "0x1539D78", VA = "0x1539D78")]
	public void StartCollapse()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1539E60", Offset = "0x1539E60", VA = "0x1539E60")]
	private IEnumerator CollapseRoutine()
	{
		return null;
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1539ED4", Offset = "0x1539ED4", VA = "0x1539ED4")]
	public LobbyCrownStack()
	{
	}
}
