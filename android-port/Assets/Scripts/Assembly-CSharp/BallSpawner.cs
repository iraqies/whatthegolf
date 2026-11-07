using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200010E")]
public class BallSpawner : MonoBehaviour
{
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB20", Offset = "0x3DB20")]
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x20")]
		public BallSpawner _003C_003E4__this;

		[Token(Token = "0x170000A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1771178", Offset = "0x1771178", VA = "0x1771178", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x17711C0", Offset = "0x17711C0", VA = "0x17711C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1771044", Offset = "0x1771044", VA = "0x1771044")]
		[DebuggerHidden]
		public _003CStart_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1771070", Offset = "0x1771070", VA = "0x1771070", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1771074", Offset = "0x1771074", VA = "0x1771074", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1771178", Offset = "0x1771178", VA = "0x1771178", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1771180", Offset = "0x1771180", VA = "0x1771180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x17711C0", Offset = "0x17711C0", VA = "0x17711C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x18")]
	public float FirstSpawnDelay;

	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject StikboldPrefab;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x28")]
	public float SpawnRange;

	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection sfxOnSpawn;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x49828", Offset = "0x49828")]
	public float ChangeToSpawn;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x3C")]
	public int MaxSpawns;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x40")]
	public Collider BoundsCollider;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x48")]
	private int spawns;

	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> spawnedBalls;

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x15193C0", Offset = "0x15193C0", VA = "0x15193C0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x1519434", Offset = "0x1519434", VA = "0x1519434")]
	public void SpawnNewBall()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x1519484", Offset = "0x1519484", VA = "0x1519484")]
	private GameObject SpawnBall()
	{
		return null;
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x151962C", Offset = "0x151962C", VA = "0x151962C")]
	public void PlaySpawnSFX()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x1519678", Offset = "0x1519678", VA = "0x1519678")]
	public List<GameObject> GetBalls()
	{
		return null;
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x1519680", Offset = "0x1519680", VA = "0x1519680")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x15196BC", Offset = "0x15196BC", VA = "0x15196BC")]
	public BallSpawner()
	{
	}
}
