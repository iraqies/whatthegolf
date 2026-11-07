using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Arena;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20000FD")]
public class CrabsController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000FE")]
	public class CrabInfo
	{
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Start;

		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Goal;

		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody Rigid;

		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x30")]
		public float Speed;

		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x38")]
		public GolfBallController ChasingPlayer;

		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Crab;

		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x48")]
		public CrabExplosiveBarrel Barrel;

		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x50")]
		public SpiderLegs Spider;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1791ABC", Offset = "0x1791ABC", VA = "0x1791ABC")]
		public CrabInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000FF")]
	public class WaveSettings
	{
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x10")]
		public int WaveSpreadInDegrees;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x14")]
		public int DegreesBetweenSpawns;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x18")]
		public int HoleSizeInDegrees;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x1C")]
		public float CrabSpeed;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1791AC4", Offset = "0x1791AC4", VA = "0x1791AC4")]
		public WaveSettings()
		{
		}
	}

	[Token(Token = "0x2000100")]
	private enum WaveSpawnPointEnum
	{
		[Token(Token = "0x4000474")]
		North = 0,
		[Token(Token = "0x4000475")]
		East = 1,
		[Token(Token = "0x4000476")]
		West = 2,
		[Token(Token = "0x4000477")]
		South = 3
	}

	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DAD0", Offset = "0x3DAD0")]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController controller;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x179177C", Offset = "0x179177C", VA = "0x179177C")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1791784", Offset = "0x1791784", VA = "0x1791784")]
		internal float _003CUpdate_003Eb__0(KeyValuePair<WaveSpawnPointEnum, Vector3> s)
		{
			return default;
		}
	}

	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DAE0", Offset = "0x3DAE0")]
	private sealed class _003C_003Ec__DisplayClass30_1
	{
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController controller;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1791830", Offset = "0x1791830", VA = "0x1791830")]
		public _003C_003Ec__DisplayClass30_1()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1791838", Offset = "0x1791838", VA = "0x1791838")]
		internal bool _003CUpdate_003Eb__1(CrabInfo c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DAF0", Offset = "0x3DAF0")]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody rigid;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x17918C8", Offset = "0x17918C8", VA = "0x17918C8")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x17918D0", Offset = "0x17918D0", VA = "0x17918D0")]
		internal bool _003CGetCrabWithRigid_003Eb__0(CrabInfo c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB00", Offset = "0x3DB00")]
	private sealed class _003CDelayedCrapRelease_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x20")]
		public CrabsController _003C_003E4__this;

		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x28")]
		public CrabInfo crab;

		[Token(Token = "0x170000A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1791A6C", Offset = "0x1791A6C", VA = "0x1791A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1791AB4", Offset = "0x1791AB4", VA = "0x1791AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1791960", Offset = "0x1791960", VA = "0x1791960")]
		[DebuggerHidden]
		public _003CDelayedCrapRelease_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x179198C", Offset = "0x179198C", VA = "0x179198C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1791990", Offset = "0x1791990", VA = "0x1791990", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1791A6C", Offset = "0x1791A6C", VA = "0x1791A6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1791A74", Offset = "0x1791A74", VA = "0x1791A74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1791AB4", Offset = "0x1791AB4", VA = "0x1791AB4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x18")]
	public float SpawnRadius;

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x20")]
	public Transform CrabPrefab;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve SpawnIntervalsOverTime;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve SpawnAmountOverTime;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x38")]
	public float CrabMoveSpeed;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x3C")]
	public float CrabWaveMoveSpeed;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x40")]
	public float CrabFleeSpeed;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x48")]
	public Collider BorderCollider;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource CrabMoveSource;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection CrabScareClips;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x497C8", Offset = "0x497C8")]
	public float ChanceOfWave;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x64")]
	public float WaveCooldown;

	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x68")]
	public List<WaveSettings> Waves;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x70")]
	public float ClearCrabsForce;

	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x74")]
	public float ClearCrabsUpwardsModifier;

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x78")]
	private float timer;

	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x7C")]
	private float spawnTimer;

	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x80")]
	private float waveCooldownTimer;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x88")]
	private List<CrabInfo> crabs;

	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x90")]
	private List<CrabInfo> toBeRemoved;

	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x98")]
	private List<GolfBallController> players;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<WaveSpawnPointEnum, Vector3> waveSpawnPoints;

	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0xA8")]
	private ObjectPool<GameObject> crabPool;

	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0xB0")]
	private FreezeTimescale timeScaleFreezer;

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x18BB458", Offset = "0x18BB458", VA = "0x18BB458")]
	private void Start()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x18BB750", Offset = "0x18BB750", VA = "0x18BB750")]
	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x18BB784", Offset = "0x18BB784", VA = "0x18BB784")]
	private Vector3 GetOppositeOf(WaveSpawnPointEnum spawnPoint)
	{
		return default;
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x18BB878", Offset = "0x18BB878", VA = "0x18BB878")]
	private void Update()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x18BC2DC", Offset = "0x18BC2DC", VA = "0x18BC2DC")]
	private void SpawnCrab(Vector3 start, Vector3 goal, GolfBallController chasing, float crabSpeed)
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x18BC5F0", Offset = "0x18BC5F0", VA = "0x18BC5F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x18BCA2C", Offset = "0x18BCA2C", VA = "0x18BCA2C")]
	public CrabInfo GetCrabWithRigid(Rigidbody rigid)
	{
		return null;
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x18BCB20", Offset = "0x18BCB20", VA = "0x18BCB20")]
	public void ScareCrab(Vector3 hitPos, CrabInfo crabHit)
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x18BCD44", Offset = "0x18BCD44", VA = "0x18BCD44")]
	private IEnumerator DelayedCrapRelease(CrabInfo crab)
	{
		return null;
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x18BCDBC", Offset = "0x18BCDBC", VA = "0x18BCDBC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x18BD120", Offset = "0x18BD120", VA = "0x18BD120")]
	public CrabsController()
	{
	}
}
