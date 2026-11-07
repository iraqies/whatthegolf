using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D8")]
public class DonkeyKongLevel : MonoBehaviour
{
	[Token(Token = "0x20006D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41140", Offset = "0x41140")]
	private sealed class _003CSpawnBarrelRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x20")]
		public DonkeyKongLevel _003C_003E4__this;

		[Token(Token = "0x170003A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F9E")]
			[Address(RVA = "0x179D4D0", Offset = "0x179D4D0", VA = "0x179D4D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001FA0")]
			[Address(RVA = "0x179D518", Offset = "0x179D518", VA = "0x179D518", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0x179D344", Offset = "0x179D344", VA = "0x179D344")]
		[DebuggerHidden]
		public _003CSpawnBarrelRoutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x179D370", Offset = "0x179D370", VA = "0x179D370", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x179D374", Offset = "0x179D374", VA = "0x179D374", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x179D4D0", Offset = "0x179D4D0", VA = "0x179D4D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x179D4D8", Offset = "0x179D4D8", VA = "0x179D4D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x179D518", Offset = "0x179D518", VA = "0x179D518", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40023D6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform barrelSpawnPoint;

	[Token(Token = "0x40023D7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ExplosionBarrel2D barrelPrefab;

	[Token(Token = "0x40023D8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float spawnY;

	[Token(Token = "0x40023D9")]
	[FieldOffset(Offset = "0x30")]
	private Transform activeBarrel;

	[Token(Token = "0x40023DA")]
	[FieldOffset(Offset = "0x38")]
	public Animator FrogeyKongController;

	[Token(Token = "0x40023DB")]
	[FieldOffset(Offset = "0x40")]
	public float BarrelSpawnDelay;

	[Token(Token = "0x40023DC")]
	[FieldOffset(Offset = "0x44")]
	public float DelayBetweenBarrels;

	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x1431B84", Offset = "0x1431B84", VA = "0x1431B84")]
	private void Start()
	{
	}

	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x1431C00", Offset = "0x1431C00", VA = "0x1431C00")]
	private IEnumerator SpawnBarrelRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x1431C74", Offset = "0x1431C74", VA = "0x1431C74")]
	private void SpawnBarrel()
	{
	}

	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x1431E00", Offset = "0x1431E00", VA = "0x1431E00")]
	private void OnExplode(Collider2D col)
	{
	}

	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x1431E6C", Offset = "0x1431E6C", VA = "0x1431E6C")]
	public DonkeyKongLevel()
	{
	}
}
