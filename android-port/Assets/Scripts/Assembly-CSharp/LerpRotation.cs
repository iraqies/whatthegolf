using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000077")]
public class LerpRotation : MonoBehaviour
{
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D5C8", Offset = "0x3D5C8")]
	private sealed class _003CStartRotating_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x20")]
		public LerpRotation _003C_003E4__this;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x28")]
		private float _003CmovementTime_003E5__2;

		[Token(Token = "0x17000051")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x17D071C", Offset = "0x17D071C", VA = "0x17D071C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000052")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x17D0764", Offset = "0x17D0764", VA = "0x17D0764", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x17D05BC", Offset = "0x17D05BC", VA = "0x17D05BC")]
		[DebuggerHidden]
		public _003CStartRotating_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x17D05E8", Offset = "0x17D05E8", VA = "0x17D05E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x17D05EC", Offset = "0x17D05EC", VA = "0x17D05EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x17D071C", Offset = "0x17D071C", VA = "0x17D071C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x17D0724", Offset = "0x17D0724", VA = "0x17D0724", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x17D0764", Offset = "0x17D0764", VA = "0x17D0764", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x18")]
	private Quaternion startRotation;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x28")]
	public Quaternion endRotation;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x38")]
	public float movementSpeed;

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1522C0C", Offset = "0x1522C0C", VA = "0x1522C0C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1522C48", Offset = "0x1522C48", VA = "0x1522C48")]
	public void Rotate()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1522CC4", Offset = "0x1522CC4", VA = "0x1522CC4")]
	private IEnumerator StartRotating()
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1522D38", Offset = "0x1522D38", VA = "0x1522D38")]
	public LerpRotation()
	{
	}
}
