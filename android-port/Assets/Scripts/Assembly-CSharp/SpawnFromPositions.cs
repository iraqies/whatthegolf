using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000C48")]
public class SpawnFromPositions : MonoBehaviour
{
	[Token(Token = "0x2000C49")]
	public enum SpawnPositionMode
	{
		[Token(Token = "0x4004383")]
		Random = 0,
		[Token(Token = "0x4004384")]
		RandomNonRepeating = 1,
		[Token(Token = "0x4004385")]
		Sequence = 2
	}

	[Token(Token = "0x2000C4A")]
	public enum SpawnMethodEnum
	{
		[Token(Token = "0x4004387")]
		SpawnNew = 0,
		[Token(Token = "0x4004388")]
		EnableBehaviour = 1
	}

	[Token(Token = "0x2000C4B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440B8", Offset = "0x440B8")]
	private sealed class _003CSpawnRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004389")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400438A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400438B")]
		[FieldOffset(Offset = "0x20")]
		public SpawnFromPositions _003C_003E4__this;

		[Token(Token = "0x17000605")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x18533E4", Offset = "0x18533E4", VA = "0x18533E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000606")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x185342C", Offset = "0x185342C", VA = "0x185342C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x18531E4", Offset = "0x18531E4", VA = "0x18531E4")]
		[DebuggerHidden]
		public _003CSpawnRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x1853210", Offset = "0x1853210", VA = "0x1853210", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x1853214", Offset = "0x1853214", VA = "0x1853214", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003A82")]
		[Address(RVA = "0x18533E4", Offset = "0x18533E4", VA = "0x18533E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x18533EC", Offset = "0x18533EC", VA = "0x18533EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003A84")]
		[Address(RVA = "0x185342C", Offset = "0x185342C", VA = "0x185342C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400436B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject Prefab;

	[Token(Token = "0x400436C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> Additional_Prefabs;

	[Token(Token = "0x400436D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection clipCollection;

	[Token(Token = "0x400436E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform[] Positions;

	[Token(Token = "0x400436F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SpawnPositionMode m_SpawnPositionMode;

	[Token(Token = "0x4004370")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool StartOnAwake;

	[Token(Token = "0x4004371")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem SpawnParticles;

	[Token(Token = "0x4004372")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int SpawnAmount;

	[Token(Token = "0x4004373")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int SimultaneousSpawnedObjects;

	[Token(Token = "0x4004374")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool m_UseTransformChildCountAsSpawnAmount;

	[Token(Token = "0x4004375")]
	[FieldOffset(Offset = "0x58")]
	private List<GameObject> objectsInScene;

	[Token(Token = "0x4004376")]
	[FieldOffset(Offset = "0x60")]
	public float SpawnStartDelay;

	[Token(Token = "0x4004377")]
	[FieldOffset(Offset = "0x64")]
	public float DefaultInterval;

	[Token(Token = "0x4004378")]
	[FieldOffset(Offset = "0x68")]
	public bool UseCustomInterval;

	[Token(Token = "0x4004379")]
	[FieldOffset(Offset = "0x70")]
	public List<float> CustomIntervals;

	[Token(Token = "0x400437A")]
	[FieldOffset(Offset = "0x78")]
	public SpawnMethodEnum SpawnMethod;

	[Token(Token = "0x400437B")]
	[FieldOffset(Offset = "0x80")]
	public List<MonoBehaviour> Behaviours;

	[Token(Token = "0x400437C")]
	[FieldOffset(Offset = "0x88")]
	public UnityEvent OnAllEnabled;

	[Token(Token = "0x400437D")]
	[FieldOffset(Offset = "0x90")]
	public UnityEvent OnSpawn;

	[Token(Token = "0x400437E")]
	[FieldOffset(Offset = "0x98")]
	private int m_IntervalIndex;

	[Token(Token = "0x400437F")]
	[FieldOffset(Offset = "0x9C")]
	private int m_PositionIndex;

	[Token(Token = "0x4004380")]
	[FieldOffset(Offset = "0xA0")]
	private int m_SpawnCount;

	[Token(Token = "0x4004381")]
	[FieldOffset(Offset = "0xA4")]
	public bool IsRunning;

	[Token(Token = "0x6003A78")]
	[Address(RVA = "0x16C5700", Offset = "0x16C5700", VA = "0x16C5700")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A79")]
	[Address(RVA = "0x16C57D4", Offset = "0x16C57D4", VA = "0x16C57D4")]
	public void StartSpawner()
	{
	}

	[Token(Token = "0x6003A7A")]
	[Address(RVA = "0x16C5850", Offset = "0x16C5850", VA = "0x16C5850")]
	private IEnumerator SpawnRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003A7B")]
	[Address(RVA = "0x16C58C4", Offset = "0x16C58C4", VA = "0x16C58C4")]
	private bool CanSpawn()
	{
		return default;
	}

	[Token(Token = "0x6003A7C")]
	[Address(RVA = "0x16C596C", Offset = "0x16C596C", VA = "0x16C596C")]
	private void CheckForDestroyedObjects()
	{
	}

	[Token(Token = "0x6003A7D")]
	[Address(RVA = "0x16C5A84", Offset = "0x16C5A84", VA = "0x16C5A84")]
	public void Spawn()
	{
	}

	[Token(Token = "0x6003A7E")]
	[Address(RVA = "0x16C5EC8", Offset = "0x16C5EC8", VA = "0x16C5EC8")]
	public SpawnFromPositions()
	{
	}
}
