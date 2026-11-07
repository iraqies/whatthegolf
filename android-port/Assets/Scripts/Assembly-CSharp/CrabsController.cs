using System;
using System.Collections;
using System.Collections.Generic;
using Arena;
using Audio;
using Core;
using UnityEngine;
using Utility;

public class CrabsController : MonoBehaviour
{
	[Serializable]
	public class CrabInfo
	{
		public Vector3 Start;

		public Vector3 Goal;

		public Rigidbody Rigid;

		public float Speed;

		public GolfBallController ChasingPlayer;

		public GameObject Crab;

		public CrabExplosiveBarrel Barrel;

		public SpiderLegs Spider;
	}

	[Serializable]
	public class WaveSettings
	{
		public int WaveSpreadInDegrees;

		public int DegreesBetweenSpawns;

		public int HoleSizeInDegrees;

		public float CrabSpeed;
	}

	private enum WaveSpawnPointEnum
	{
		North = 0,
		East = 1,
		West = 2,
		South = 3
	}

	public float SpawnRadius;

	public Transform CrabPrefab;

	public AnimationCurve SpawnIntervalsOverTime;

	public AnimationCurve SpawnAmountOverTime;

	public float CrabMoveSpeed;

	public float CrabWaveMoveSpeed;

	public float CrabFleeSpeed;

	public Collider BorderCollider;

	public AudioSource CrabMoveSource;

	public ClipSettingsCollection CrabScareClips;

	public float ChanceOfWave;

	public float WaveCooldown;

	public List<WaveSettings> Waves;

	public float ClearCrabsForce;

	public float ClearCrabsUpwardsModifier;

	private float timer;

	private float spawnTimer;

	private float waveCooldownTimer;

	private List<CrabInfo> crabs;

	private List<CrabInfo> toBeRemoved;

	private List<GolfBallController> players;

	private Dictionary<WaveSpawnPointEnum, Vector3> waveSpawnPoints;

	private ObjectPool<GameObject> crabPool;

	private FreezeTimescale timeScaleFreezer;

	private void Start()
	{
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	private Vector3 GetOppositeOf(WaveSpawnPointEnum spawnPoint)
	{
		return default;
	}

	private void Update()
	{
	}

	private void SpawnCrab(Vector3 start, Vector3 goal, GolfBallController chasing, float crabSpeed)
	{
	}

	private void FixedUpdate()
	{
	}

	public CrabInfo GetCrabWithRigid(Rigidbody rigid)
	{
		return null;
	}

	public void ScareCrab(Vector3 hitPos, CrabInfo crabHit)
	{
	}

	private IEnumerator DelayedCrapRelease(CrabInfo crab)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
