using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CFD")]
public class FishStickSpawnOnColision : MonoBehaviour
{
	[Token(Token = "0x2000CFE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44628", Offset = "0x44628")]
	private sealed class _003CFoodEjectionRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004693")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004694")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004695")]
		[FieldOffset(Offset = "0x20")]
		public FishStickSpawnOnColision _003C_003E4__this;

		[Token(Token = "0x17000647")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003D63")]
			[Address(RVA = "0x17A7480", Offset = "0x17A7480", VA = "0x17A7480", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000648")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003D65")]
			[Address(RVA = "0x17A74C8", Offset = "0x17A74C8", VA = "0x17A74C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x17A72BC", Offset = "0x17A72BC", VA = "0x17A72BC")]
		[DebuggerHidden]
		public _003CFoodEjectionRoutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x17A72E8", Offset = "0x17A72E8", VA = "0x17A72E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003D62")]
		[Address(RVA = "0x17A72EC", Offset = "0x17A72EC", VA = "0x17A72EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003D63")]
		[Address(RVA = "0x17A7480", Offset = "0x17A7480", VA = "0x17A7480", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003D64")]
		[Address(RVA = "0x17A7488", Offset = "0x17A7488", VA = "0x17A7488", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003D65")]
		[Address(RVA = "0x17A74C8", Offset = "0x17A74C8", VA = "0x17A74C8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004688")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] EjectableFoodPrefabs;

	[Token(Token = "0x4004689")]
	[FieldOffset(Offset = "0x20")]
	public float EjectForce;

	[Token(Token = "0x400468A")]
	[FieldOffset(Offset = "0x24")]
	public float EjectForceAngular;

	[Token(Token = "0x400468B")]
	[FieldOffset(Offset = "0x28")]
	private bool onCooldown;

	[Token(Token = "0x400468C")]
	[FieldOffset(Offset = "0x2C")]
	public float FoodDecayTime;

	[Token(Token = "0x400468D")]
	[FieldOffset(Offset = "0x30")]
	public int FoodLeft;

	[Token(Token = "0x400468E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float SpawnDelay;

	[Token(Token = "0x400468F")]
	[FieldOffset(Offset = "0x38")]
	public Transform FoodEjectPosition;

	[Token(Token = "0x4004690")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioEventAsset clickBeepSFX;

	[Token(Token = "0x4004691")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioEventAsset ejectionSFX;

	[Token(Token = "0x4004692")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioEventAsset foodOutSFX;

	[Token(Token = "0x6003D5B")]
	[Address(RVA = "0x14687A4", Offset = "0x14687A4", VA = "0x14687A4")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003D5C")]
	[Address(RVA = "0x1468948", Offset = "0x1468948", VA = "0x1468948")]
	private IEnumerator FoodEjectionRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003D5D")]
	[Address(RVA = "0x14689BC", Offset = "0x14689BC", VA = "0x14689BC")]
	private void PlaySFX(AudioEventAsset _event)
	{
	}

	[Token(Token = "0x6003D5E")]
	[Address(RVA = "0x1468A7C", Offset = "0x1468A7C", VA = "0x1468A7C")]
	private void EjectFood()
	{
	}

	[Token(Token = "0x6003D5F")]
	[Address(RVA = "0x1468C28", Offset = "0x1468C28", VA = "0x1468C28")]
	public FishStickSpawnOnColision()
	{
	}
}
