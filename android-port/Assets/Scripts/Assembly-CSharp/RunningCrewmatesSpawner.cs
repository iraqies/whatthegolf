using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E28")]
public class RunningCrewmatesSpawner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000E29")]
	public class SpawnPos
	{
		[Token(Token = "0x4004CD1")]
		[FieldOffset(Offset = "0x10")]
		public Transform spawnTransform;

		[Token(Token = "0x4004CD2")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bossPrefab;

		[Token(Token = "0x600426D")]
		[Address(RVA = "0x18373FC", Offset = "0x18373FC", VA = "0x18373FC")]
		public SpawnPos()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E2A")]
	public class Wave
	{
		[Token(Token = "0x4004CD3")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObject> m_prefabsToSpawn;

		[Token(Token = "0x4004CD4")]
		[FieldOffset(Offset = "0x18")]
		public List<int> m_spawnOrderList;

		[Token(Token = "0x4004CD5")]
		[FieldOffset(Offset = "0x20")]
		public float delayBetweenSpawns;

		[Token(Token = "0x4004CD6")]
		[FieldOffset(Offset = "0x24")]
		public float finalDelay;

		[Token(Token = "0x600426E")]
		[Address(RVA = "0x1837404", Offset = "0x1837404", VA = "0x1837404")]
		public Wave()
		{
		}
	}

	[Token(Token = "0x2000E2B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44EA8", Offset = "0x44EA8")]
	private sealed class _003CSpawnDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004CD7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004CD8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004CD9")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4004CDA")]
		[FieldOffset(Offset = "0x28")]
		public RunningCrewmatesSpawner _003C_003E4__this;

		[Token(Token = "0x170006D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x18369CC", Offset = "0x18369CC", VA = "0x18369CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004274")]
			[Address(RVA = "0x1836A14", Offset = "0x1836A14", VA = "0x1836A14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600426F")]
		[Address(RVA = "0x18368C8", Offset = "0x18368C8", VA = "0x18368C8")]
		[DebuggerHidden]
		public _003CSpawnDelay_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004270")]
		[Address(RVA = "0x18368F4", Offset = "0x18368F4", VA = "0x18368F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004271")]
		[Address(RVA = "0x18368F8", Offset = "0x18368F8", VA = "0x18368F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004272")]
		[Address(RVA = "0x18369CC", Offset = "0x18369CC", VA = "0x18369CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004273")]
		[Address(RVA = "0x18369D4", Offset = "0x18369D4", VA = "0x18369D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004274")]
		[Address(RVA = "0x1836A14", Offset = "0x1836A14", VA = "0x1836A14", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000E2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44EB8", Offset = "0x44EB8")]
	private sealed class _003CSpawnWaves_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004CDB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004CDC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004CDD")]
		[FieldOffset(Offset = "0x20")]
		public RunningCrewmatesSpawner _003C_003E4__this;

		[Token(Token = "0x4004CDE")]
		[FieldOffset(Offset = "0x28")]
		private int _003CspawnCount_003E5__2;

		[Token(Token = "0x4004CDF")]
		[FieldOffset(Offset = "0x2C")]
		private int _003CtotalSpawns_003E5__3;

		[Token(Token = "0x4004CE0")]
		[FieldOffset(Offset = "0x30")]
		private int _003Cj_003E5__4;

		[Token(Token = "0x4004CE1")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x170006D2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004278")]
			[Address(RVA = "0x18373AC", Offset = "0x18373AC", VA = "0x18373AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600427A")]
			[Address(RVA = "0x18373F4", Offset = "0x18373F4", VA = "0x18373F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004275")]
		[Address(RVA = "0x1836A1C", Offset = "0x1836A1C", VA = "0x1836A1C")]
		[DebuggerHidden]
		public _003CSpawnWaves_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004276")]
		[Address(RVA = "0x1836A48", Offset = "0x1836A48", VA = "0x1836A48", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004277")]
		[Address(RVA = "0x1836A4C", Offset = "0x1836A4C", VA = "0x1836A4C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004278")]
		[Address(RVA = "0x18373AC", Offset = "0x18373AC", VA = "0x18373AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004279")]
		[Address(RVA = "0x18373B4", Offset = "0x18373B4", VA = "0x18373B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600427A")]
		[Address(RVA = "0x18373F4", Offset = "0x18373F4", VA = "0x18373F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004CCC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float startDelay;

	[Token(Token = "0x4004CCD")]
	[FieldOffset(Offset = "0x20")]
	public List<SpawnPos> spawnPositionsList;

	[Token(Token = "0x4004CCE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Transform> targetsForCrewmates;

	[Token(Token = "0x4004CCF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Wave> m_waves;

	[Token(Token = "0x4004CD0")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine enemyWaves;

	[Token(Token = "0x6004269")]
	[Address(RVA = "0x1664834", Offset = "0x1664834", VA = "0x1664834")]
	private void Start()
	{
	}

	[Token(Token = "0x600426A")]
	[Address(RVA = "0x16648C0", Offset = "0x16648C0", VA = "0x16648C0")]
	private IEnumerator SpawnDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600426B")]
	[Address(RVA = "0x1664944", Offset = "0x1664944", VA = "0x1664944")]
	private IEnumerator SpawnWaves()
	{
		return null;
	}

	[Token(Token = "0x600426C")]
	[Address(RVA = "0x16649B8", Offset = "0x16649B8", VA = "0x16649B8")]
	public RunningCrewmatesSpawner()
	{
	}
}
