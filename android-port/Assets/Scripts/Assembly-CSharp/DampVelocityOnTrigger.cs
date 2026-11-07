using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200012D")]
public class DampVelocityOnTrigger : MonoBehaviour
{
	[Token(Token = "0x200012E")]
	[Flags]
	public enum TriggerMode
	{
		[Token(Token = "0x400053A")]
		None = 0,
		[Token(Token = "0x400053B")]
		OnEnter = 1,
		[Token(Token = "0x400053C")]
		OnExit = 2
	}

	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DBC0", Offset = "0x3DBC0")]
	private sealed class _003CDampCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody rigid;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x28")]
		public DampVelocityOnTrigger _003C_003E4__this;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x30")]
		private float _003C_t_003E5__2;

		[Token(Token = "0x170000B0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1799DD4", Offset = "0x1799DD4", VA = "0x1799DD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000B1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1799E1C", Offset = "0x1799E1C", VA = "0x1799E1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1799CBC", Offset = "0x1799CBC", VA = "0x1799CBC")]
		[DebuggerHidden]
		public _003CDampCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1799CE8", Offset = "0x1799CE8", VA = "0x1799CE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1799CEC", Offset = "0x1799CEC", VA = "0x1799CEC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1799DD4", Offset = "0x1799DD4", VA = "0x1799DD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1799DDC", Offset = "0x1799DDC", VA = "0x1799DDC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1799E1C", Offset = "0x1799E1C", VA = "0x1799E1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask affectLayer;

	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float dampDuration;

	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x499B0", Offset = "0x499B0")]
	private float dampFactor;

	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private TriggerMode dampOnTrigger;

	[Token(Token = "0x170000AF")]
	public float DampFactor
	{
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x18D3EBC", Offset = "0x18D3EBC", VA = "0x18D3EBC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x18D3ECC", Offset = "0x18D3ECC", VA = "0x18D3ECC")]
	private IEnumerator DampCoroutine(Rigidbody rigid)
	{
		return null;
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x18D3F44", Offset = "0x18D3F44", VA = "0x18D3F44")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x18D4114", Offset = "0x18D4114", VA = "0x18D4114")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x18D408C", Offset = "0x18D408C", VA = "0x18D408C")]
	private bool IsInLayer(GameObject go)
	{
		return default;
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x18D425C", Offset = "0x18D425C", VA = "0x18D425C")]
	public DampVelocityOnTrigger()
	{
	}
}
