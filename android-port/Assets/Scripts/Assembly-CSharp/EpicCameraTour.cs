using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B6F")]
public class EpicCameraTour : MonoBehaviour
{
	[Token(Token = "0x2000B70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x438E0", Offset = "0x438E0")]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003F74")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x20")]
		public EpicCameraTour _003C_003E4__this;

		[Token(Token = "0x170005CC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003708")]
			[Address(RVA = "0x179F484", Offset = "0x179F484", VA = "0x179F484", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005CD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600370A")]
			[Address(RVA = "0x179F4CC", Offset = "0x179F4CC", VA = "0x179F4CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003705")]
		[Address(RVA = "0x179F14C", Offset = "0x179F14C", VA = "0x179F14C")]
		[DebuggerHidden]
		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003706")]
		[Address(RVA = "0x179F178", Offset = "0x179F178", VA = "0x179F178", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003707")]
		[Address(RVA = "0x179F17C", Offset = "0x179F17C", VA = "0x179F17C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003708")]
		[Address(RVA = "0x179F484", Offset = "0x179F484", VA = "0x179F484", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003709")]
		[Address(RVA = "0x179F48C", Offset = "0x179F48C", VA = "0x179F48C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600370A")]
		[Address(RVA = "0x179F4CC", Offset = "0x179F4CC", VA = "0x179F4CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003F6F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 startRotation;

	[Token(Token = "0x4003F70")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 endRotation;

	[Token(Token = "0x4003F71")]
	[FieldOffset(Offset = "0x30")]
	public float time;

	[Token(Token = "0x4003F72")]
	[FieldOffset(Offset = "0x38")]
	public Rigidbody toast;

	[Token(Token = "0x4003F73")]
	[FieldOffset(Offset = "0x40")]
	public Rigidbody cat;

	[Token(Token = "0x6003702")]
	[Address(RVA = "0x1445448", Offset = "0x1445448", VA = "0x1445448")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003703")]
	[Address(RVA = "0x14454BC", Offset = "0x14454BC", VA = "0x14454BC")]
	public EpicCameraTour()
	{
	}

	[Token(Token = "0x6003704")]
	[Address(RVA = "0x14454C4", Offset = "0x14454C4", VA = "0x14454C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AB24", Offset = "0x6AB24")]
	private void _003CStart_003Eb__5_0(float t)
	{
	}
}
