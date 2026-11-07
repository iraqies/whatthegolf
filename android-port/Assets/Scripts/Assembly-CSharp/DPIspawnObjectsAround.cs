using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F0F")]
public class DPIspawnObjectsAround : BaseDailyPrizeInteractions
{
	[Token(Token = "0x2000F10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45650", Offset = "0x45650")]
	private sealed class _003CActivateRagdollAndForce_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005148")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005149")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400514A")]
		[FieldOffset(Offset = "0x20")]
		public DPIspawnObjectsAround _003C_003E4__this;

		[Token(Token = "0x1700074E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600466A")]
			[Address(RVA = "0x17942B4", Offset = "0x17942B4", VA = "0x17942B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700074F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600466C")]
			[Address(RVA = "0x17942FC", Offset = "0x17942FC", VA = "0x17942FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004667")]
		[Address(RVA = "0x1793EE8", Offset = "0x1793EE8", VA = "0x1793EE8")]
		[DebuggerHidden]
		public _003CActivateRagdollAndForce_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004668")]
		[Address(RVA = "0x1793F14", Offset = "0x1793F14", VA = "0x1793F14", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004669")]
		[Address(RVA = "0x1793F18", Offset = "0x1793F18", VA = "0x1793F18", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600466A")]
		[Address(RVA = "0x17942B4", Offset = "0x17942B4", VA = "0x17942B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600466B")]
		[Address(RVA = "0x17942BC", Offset = "0x17942BC", VA = "0x17942BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600466C")]
		[Address(RVA = "0x17942FC", Offset = "0x17942FC", VA = "0x17942FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400513A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] objectToSpawnList;

	[Token(Token = "0x400513B")]
	[FieldOffset(Offset = "0x30")]
	public float[] customStrengthList;

	[Token(Token = "0x400513C")]
	[FieldOffset(Offset = "0x38")]
	public float[] customScale;

	[Token(Token = "0x400513D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject spawnFX;

	[Token(Token = "0x400513E")]
	[FieldOffset(Offset = "0x48")]
	public float shootCooldown;

	[Token(Token = "0x400513F")]
	[FieldOffset(Offset = "0x4C")]
	public float forceMultiplier;

	[Token(Token = "0x4005140")]
	[FieldOffset(Offset = "0x50")]
	public float spawnDist;

	[Token(Token = "0x4005141")]
	[FieldOffset(Offset = "0x54")]
	public float minThreshold;

	[Token(Token = "0x4005142")]
	[FieldOffset(Offset = "0x58")]
	public float maxThreshold;

	[Token(Token = "0x4005143")]
	[FieldOffset(Offset = "0x5C")]
	public float randomRotation;

	[Token(Token = "0x4005144")]
	[FieldOffset(Offset = "0x60")]
	private GameObject currentObject;

	[Token(Token = "0x4005145")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 currentBoost;

	[Token(Token = "0x4005146")]
	[FieldOffset(Offset = "0x74")]
	private bool canSpawn;

	[Token(Token = "0x4005147")]
	[FieldOffset(Offset = "0x78")]
	private int currentIndex;

	[Token(Token = "0x6004663")]
	[Address(RVA = "0x18C8560", Offset = "0x18C8560", VA = "0x18C8560", Slot = "8")]
	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004664")]
	[Address(RVA = "0x18C89E4", Offset = "0x18C89E4", VA = "0x18C89E4")]
	private IEnumerator ActivateRagdollAndForce()
	{
		return null;
	}

	[Token(Token = "0x6004665")]
	[Address(RVA = "0x18C8980", Offset = "0x18C8980", VA = "0x18C8980")]
	private bool isInRange(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x6004666")]
	[Address(RVA = "0x18C8A58", Offset = "0x18C8A58", VA = "0x18C8A58")]
	public DPIspawnObjectsAround()
	{
	}
}
