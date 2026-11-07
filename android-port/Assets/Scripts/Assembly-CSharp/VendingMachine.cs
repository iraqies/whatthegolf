using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A88")]
public class VendingMachine : MonoBehaviour
{
	[Token(Token = "0x2000A89")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E60", Offset = "0x42E60")]
	private sealed class _003CFoodEjectionRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003A81")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003A82")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003A83")]
		[FieldOffset(Offset = "0x20")]
		public VendingMachine _003C_003E4__this;

		[Token(Token = "0x17000531")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003251")]
			[Address(RVA = "0x18749D4", Offset = "0x18749D4", VA = "0x18749D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000532")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003253")]
			[Address(RVA = "0x1874A1C", Offset = "0x1874A1C", VA = "0x1874A1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600324E")]
		[Address(RVA = "0x18747C8", Offset = "0x18747C8", VA = "0x18747C8")]
		[DebuggerHidden]
		public _003CFoodEjectionRoutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600324F")]
		[Address(RVA = "0x18747F4", Offset = "0x18747F4", VA = "0x18747F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003250")]
		[Address(RVA = "0x18747F8", Offset = "0x18747F8", VA = "0x18747F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003251")]
		[Address(RVA = "0x18749D4", Offset = "0x18749D4", VA = "0x18749D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003252")]
		[Address(RVA = "0x18749DC", Offset = "0x18749DC", VA = "0x18749DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003253")]
		[Address(RVA = "0x1874A1C", Offset = "0x1874A1C", VA = "0x1874A1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003A76")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] EjectableFoodPrefabs;

	[Token(Token = "0x4003A77")]
	[FieldOffset(Offset = "0x20")]
	public float EjectForce;

	[Token(Token = "0x4003A78")]
	[FieldOffset(Offset = "0x24")]
	public float EjectForceAngular;

	[Token(Token = "0x4003A79")]
	[FieldOffset(Offset = "0x28")]
	private bool onCooldown;

	[Token(Token = "0x4003A7A")]
	[FieldOffset(Offset = "0x2C")]
	public float FoodDecayTime;

	[Token(Token = "0x4003A7B")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer KeypadSuccessRenderer;

	[Token(Token = "0x4003A7C")]
	[FieldOffset(Offset = "0x38")]
	public int FoodLeft;

	[Token(Token = "0x4003A7D")]
	[FieldOffset(Offset = "0x40")]
	public Transform FoodEjectPosition;

	[Token(Token = "0x4003A7E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioEventAsset clickBeepSFX;

	[Token(Token = "0x4003A7F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioEventAsset ejectionSFX;

	[Token(Token = "0x4003A80")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AudioEventAsset foodOutSFX;

	[Token(Token = "0x6003249")]
	[Address(RVA = "0x174A4DC", Offset = "0x174A4DC", VA = "0x174A4DC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600324A")]
	[Address(RVA = "0x174A680", Offset = "0x174A680", VA = "0x174A680")]
	private IEnumerator FoodEjectionRoutine()
	{
		return null;
	}

	[Token(Token = "0x600324B")]
	[Address(RVA = "0x174A6F4", Offset = "0x174A6F4", VA = "0x174A6F4")]
	private void PlaySFX(AudioEventAsset _event)
	{
	}

	[Token(Token = "0x600324C")]
	[Address(RVA = "0x174A7B4", Offset = "0x174A7B4", VA = "0x174A7B4")]
	private void EjectFood()
	{
	}

	[Token(Token = "0x600324D")]
	[Address(RVA = "0x174A960", Offset = "0x174A960", VA = "0x174A960")]
	public VendingMachine()
	{
	}
}
