using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F3")]
public class DonutCountyGrow : MonoBehaviour
{
	[Token(Token = "0x20002F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EDAC", Offset = "0x3EDAC")]
	private sealed class _003CDestroyObject_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x20")]
		public GameObject go;

		[Token(Token = "0x170001A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x179D630", Offset = "0x179D630", VA = "0x179D630", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x179D678", Offset = "0x179D678", VA = "0x179D678", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x179D520", Offset = "0x179D520", VA = "0x179D520")]
		[DebuggerHidden]
		public _003CDestroyObject_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x179D54C", Offset = "0x179D54C", VA = "0x179D54C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x179D550", Offset = "0x179D550", VA = "0x179D550", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x179D630", Offset = "0x179D630", VA = "0x179D630", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x179D638", Offset = "0x179D638", VA = "0x179D638", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x179D678", Offset = "0x179D678", VA = "0x179D678", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x18")]
	public Transform holeToGrow;

	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x20")]
	public Transform wallColliders;

	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x28")]
	public Animator holeToAnimate;

	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x30")]
	public float maxSize;

	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x34")]
	public float growthFactor;

	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x38")]
	private GameObject lastObject;

	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem dustFX;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve boundsSizeToGrowthSize;

	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x50")]
	public float maxVolSize;

	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x54")]
	public float minVolSize;

	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x1431E7C", Offset = "0x1431E7C", VA = "0x1431E7C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x1432234", Offset = "0x1432234", VA = "0x1432234")]
	private IEnumerator DestroyObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x14322A8", Offset = "0x14322A8", VA = "0x14322A8")]
	public DonutCountyGrow()
	{
	}
}
