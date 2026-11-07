using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DE0")]
public class SpawnFromPositionsNotChild : MonoBehaviour
{
	[Token(Token = "0x2000DE1")]
	public enum SpawnPositionMode
	{
		[Token(Token = "0x4004BAD")]
		Random = 0,
		[Token(Token = "0x4004BAE")]
		RandomNonRepeating = 1,
		[Token(Token = "0x4004BAF")]
		Sequence = 2
	}

	[Token(Token = "0x2000DE2")]
	public enum SpawnMethodEnum
	{
		[Token(Token = "0x4004BB1")]
		SpawnNew = 0,
		[Token(Token = "0x4004BB2")]
		EnableBehaviour = 1
	}

	[Token(Token = "0x2000DE3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44DC8", Offset = "0x44DC8")]
	private sealed class _003CSpawnRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004BB3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004BB4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004BB5")]
		[FieldOffset(Offset = "0x20")]
		public SpawnFromPositionsNotChild _003C_003E4__this;

		[Token(Token = "0x170006BE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600416C")]
			[Address(RVA = "0x1853614", Offset = "0x1853614", VA = "0x1853614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006BF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600416E")]
			[Address(RVA = "0x185365C", Offset = "0x185365C", VA = "0x185365C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004169")]
		[Address(RVA = "0x1853434", Offset = "0x1853434", VA = "0x1853434")]
		[DebuggerHidden]
		public _003CSpawnRoutine_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600416A")]
		[Address(RVA = "0x1853460", Offset = "0x1853460", VA = "0x1853460", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600416B")]
		[Address(RVA = "0x1853464", Offset = "0x1853464", VA = "0x1853464", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600416C")]
		[Address(RVA = "0x1853614", Offset = "0x1853614", VA = "0x1853614", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600416D")]
		[Address(RVA = "0x185361C", Offset = "0x185361C", VA = "0x185361C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600416E")]
		[Address(RVA = "0x185365C", Offset = "0x185365C", VA = "0x185365C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004B97")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Prefab;

	[Token(Token = "0x4004B98")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> Additional_Prefabs;

	[Token(Token = "0x4004B99")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection clipCollection;

	[Token(Token = "0x4004B9A")]
	[FieldOffset(Offset = "0x30")]
	public Transform[] Positions;

	[Token(Token = "0x4004B9B")]
	[FieldOffset(Offset = "0x38")]
	public SpawnPositionMode m_SpawnPositionMode;

	[Token(Token = "0x4004B9C")]
	[FieldOffset(Offset = "0x3C")]
	public bool StartOnAwake;

	[Token(Token = "0x4004B9D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem SpawnParticles;

	[Token(Token = "0x4004B9E")]
	[FieldOffset(Offset = "0x48")]
	public int SpawnAmount;

	[Token(Token = "0x4004B9F")]
	[FieldOffset(Offset = "0x4C")]
	public int maxSpawned;

	[Token(Token = "0x4004BA0")]
	[FieldOffset(Offset = "0x50")]
	public float SpawnStartDelay;

	[Token(Token = "0x4004BA1")]
	[FieldOffset(Offset = "0x54")]
	public float DefaultInterval;

	[Token(Token = "0x4004BA2")]
	[FieldOffset(Offset = "0x58")]
	public bool UseCustomInterval;

	[Token(Token = "0x4004BA3")]
	[FieldOffset(Offset = "0x60")]
	public List<float> CustomIntervals;

	[Token(Token = "0x4004BA4")]
	[FieldOffset(Offset = "0x68")]
	public SpawnMethodEnum SpawnMethod;

	[Token(Token = "0x4004BA5")]
	[FieldOffset(Offset = "0x70")]
	public List<MonoBehaviour> Behaviours;

	[Token(Token = "0x4004BA6")]
	[FieldOffset(Offset = "0x78")]
	public UnityEvent OnAllEnabled;

	[Token(Token = "0x4004BA7")]
	[FieldOffset(Offset = "0x80")]
	public UnityEvent OnSpawn;

	[Token(Token = "0x4004BA8")]
	[FieldOffset(Offset = "0x88")]
	private int m_IntervalIndex;

	[Token(Token = "0x4004BA9")]
	[FieldOffset(Offset = "0x8C")]
	private int m_PositionIndex;

	[Token(Token = "0x4004BAA")]
	[FieldOffset(Offset = "0x90")]
	private int m_SpawnCount;

	[Token(Token = "0x4004BAB")]
	[FieldOffset(Offset = "0x94")]
	public bool IsRunning;

	[Token(Token = "0x6004164")]
	[Address(RVA = "0x16C5F58", Offset = "0x16C5F58", VA = "0x16C5F58")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004165")]
	[Address(RVA = "0x16C602C", Offset = "0x16C602C", VA = "0x16C602C")]
	public void StartSpawner()
	{
	}

	[Token(Token = "0x6004166")]
	[Address(RVA = "0x16C60A8", Offset = "0x16C60A8", VA = "0x16C60A8")]
	private IEnumerator SpawnRoutine()
	{
		return null;
	}

	[Token(Token = "0x6004167")]
	[Address(RVA = "0x16C611C", Offset = "0x16C611C", VA = "0x16C611C")]
	public void Spawn()
	{
	}

	[Token(Token = "0x6004168")]
	[Address(RVA = "0x16C651C", Offset = "0x16C651C", VA = "0x16C651C")]
	public SpawnFromPositionsNotChild()
	{
	}
}
