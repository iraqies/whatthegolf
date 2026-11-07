using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000941")]
public class HotdogVendor : MonoBehaviour
{
	[Token(Token = "0x2000942")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42160", Offset = "0x42160")]
	private sealed class _003CSpawnHotdogs_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x20")]
		public HotdogVendor _003C_003E4__this;

		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x28")]
		public GolfBallController controller;

		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x30")]
		private WaitForSeconds _003Cwait_003E5__2;

		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x3C")]
		private int _003Cc_003E5__4;

		[Token(Token = "0x1700046A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B08")]
			[Address(RVA = "0x17C0594", Offset = "0x17C0594", VA = "0x17C0594", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700046B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B0A")]
			[Address(RVA = "0x17C05DC", Offset = "0x17C05DC", VA = "0x17C05DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B05")]
		[Address(RVA = "0x17C02A8", Offset = "0x17C02A8", VA = "0x17C02A8")]
		[DebuggerHidden]
		public _003CSpawnHotdogs_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B06")]
		[Address(RVA = "0x17C02D4", Offset = "0x17C02D4", VA = "0x17C02D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x17C02D8", Offset = "0x17C02D8", VA = "0x17C02D8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x17C0594", Offset = "0x17C0594", VA = "0x17C0594", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x17C059C", Offset = "0x17C059C", VA = "0x17C059C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x17C05DC", Offset = "0x17C05DC", VA = "0x17C05DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003297")]
	[FieldOffset(Offset = "0x18")]
	public CollisionEvents hotdogStand;

	[Token(Token = "0x4003298")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody hotdogPrefab;

	[Token(Token = "0x4003299")]
	[FieldOffset(Offset = "0x28")]
	public Transform spawnPositions;

	[Token(Token = "0x400329A")]
	[FieldOffset(Offset = "0x30")]
	public float spawnForce;

	[Token(Token = "0x400329B")]
	[FieldOffset(Offset = "0x34")]
	public int spawnCountPerCollision;

	[Token(Token = "0x400329C")]
	[FieldOffset(Offset = "0x38")]
	public float spawnInterval;

	[Token(Token = "0x400329D")]
	[FieldOffset(Offset = "0x3C")]
	public float impactThreshold;

	[Token(Token = "0x400329E")]
	[FieldOffset(Offset = "0x40")]
	public RandomAudioClips spawnClips;

	[Token(Token = "0x400329F")]
	[FieldOffset(Offset = "0x48")]
	public Action<GolfBallController> OnHotdogSpawned;

	[Token(Token = "0x40032A0")]
	[FieldOffset(Offset = "0x50")]
	public GolfBallController player;

	[Token(Token = "0x40032A1")]
	[FieldOffset(Offset = "0x58")]
	private float nextSpawn;

	[Token(Token = "0x6002AFE")]
	[Address(RVA = "0x14DD7BC", Offset = "0x14DD7BC", VA = "0x14DD7BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x14DD8E4", Offset = "0x14DD8E4", VA = "0x14DD8E4")]
	private void HotdogStand_OnCollisionEnterTrigger(Rigidbody obj)
	{
	}

	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x14DDAC8", Offset = "0x14DDAC8", VA = "0x14DDAC8")]
	public void CallSpawnHotdogs()
	{
	}

	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x14DDB80", Offset = "0x14DDB80", VA = "0x14DDB80")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x14DDCB4", Offset = "0x14DDCB4", VA = "0x14DDCB4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x14DDA50", Offset = "0x14DDA50", VA = "0x14DDA50")]
	private IEnumerator SpawnHotdogs(GolfBallController controller)
	{
		return null;
	}

	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x14DDDF4", Offset = "0x14DDDF4", VA = "0x14DDDF4")]
	public HotdogVendor()
	{
	}
}
