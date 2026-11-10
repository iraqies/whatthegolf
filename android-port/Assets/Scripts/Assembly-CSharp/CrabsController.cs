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
		public int WaveSpreadInDegrees = 90;

		public int DegreesBetweenSpawns = 15;

		public int HoleSizeInDegrees = 20;

		public float CrabSpeed = 4f;
	}

	private enum WaveSpawnPointEnum
	{
		North = 0,
		East = 1,
		West = 2,
		South = 3
	}

	public float SpawnRadius = 25f;

	public Transform CrabPrefab;

	public AnimationCurve SpawnIntervalsOverTime = AnimationCurve.Linear(0f, 3f, 60f, 1.5f);

	public AnimationCurve SpawnAmountOverTime = AnimationCurve.Linear(0f, 1f, 60f, 3f);

	public float CrabMoveSpeed = 3f;

	public float CrabWaveMoveSpeed = 4f;

	public float CrabFleeSpeed = 8f;

	public Collider BorderCollider;

	public AudioSource CrabMoveSource;

	public ClipSettingsCollection CrabScareClips;

	public float ChanceOfWave = 0.2f;

	public float WaveCooldown = 10f;

	public List<WaveSettings> Waves;

	public float ClearCrabsForce = 15f;

	public float ClearCrabsUpwardsModifier = 1.5f;

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
		crabs = new List<CrabInfo>();
		toBeRemoved = new List<CrabInfo>();
		players = new List<GolfBallController>(UnityEngine.Object.FindObjectsOfType<GolfBallController>());
		waveSpawnPoints = new Dictionary<WaveSpawnPointEnum, Vector3>
		{
			{ WaveSpawnPointEnum.North, transform.position + Vector3.forward * SpawnRadius },
			{ WaveSpawnPointEnum.South, transform.position + Vector3.back * SpawnRadius },
			{ WaveSpawnPointEnum.East, transform.position + Vector3.right * SpawnRadius },
			{ WaveSpawnPointEnum.West, transform.position + Vector3.left * SpawnRadius }
		};
		if (CrabPrefab != null)
		{
			crabPool = new ObjectPool<GameObject>(CrabPrefab.gameObject, 16);
		}
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += InstanceOnOnMultiplayerSetup;
		}
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
		players = new List<GolfBallController>(UnityEngine.Object.FindObjectsOfType<GolfBallController>());
	}

	private Vector3 GetOppositeOf(WaveSpawnPointEnum spawnPoint)
	{
		return spawnPoint switch
		{
			WaveSpawnPointEnum.North => waveSpawnPoints[WaveSpawnPointEnum.South],
			WaveSpawnPointEnum.South => waveSpawnPoints[WaveSpawnPointEnum.North],
			WaveSpawnPointEnum.East => waveSpawnPoints[WaveSpawnPointEnum.West],
			WaveSpawnPointEnum.West => waveSpawnPoints[WaveSpawnPointEnum.East],
			_ => transform.position,
		};
	}

	private void Update()
	{
		if (CrabPrefab == null)
		{
			return;
		}
		timer += Time.deltaTime;
		spawnTimer -= Time.deltaTime;
		waveCooldownTimer -= Time.deltaTime;
		if (spawnTimer <= 0f)
		{
			float interval = SpawnIntervalsOverTime != null && SpawnIntervalsOverTime.length > 0 ? Mathf.Max(0.5f, SpawnIntervalsOverTime.Evaluate(timer)) : 2.5f;
			int amount = SpawnAmountOverTime != null && SpawnAmountOverTime.length > 0 ? Mathf.Max(1, Mathf.RoundToInt(SpawnAmountOverTime.Evaluate(timer))) : 1;
			spawnTimer = interval;
			for (int i = 0; i < amount; i++)
			{
				float angle = UnityEngine.Random.Range(0f, 360f) * Mathf.Deg2Rad;
				Vector3 start = transform.position + new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * SpawnRadius;
				Vector3 goal = transform.position - new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * SpawnRadius;
				GolfBallController chasing = players != null && players.Count > 0 ? players[UnityEngine.Random.Range(0, players.Count)] : null;
				SpawnCrab(start, goal, chasing, CrabMoveSpeed);
			}
		}
	}

	private void SpawnCrab(Vector3 start, Vector3 goal, GolfBallController chasing, float crabSpeed)
	{
		GameObject crabObj = crabPool != null ? crabPool.Get(start, Quaternion.identity) : UnityEngine.Object.Instantiate(CrabPrefab.gameObject, start, Quaternion.identity);
		if (crabObj == null)
		{
			return;
		}
		crabObj.SetActive(true);
		CrabInfo info = new CrabInfo
		{
			Start = start,
			Goal = goal,
			Crab = crabObj,
			Rigid = crabObj.GetComponent<Rigidbody>(),
			Barrel = crabObj.GetComponentInChildren<CrabExplosiveBarrel>(),
			Spider = crabObj.GetComponentInChildren<SpiderLegs>(),
			ChasingPlayer = chasing,
			Speed = crabSpeed
		};
		if (info.Barrel != null)
		{
			info.Barrel.Reset();
		}
		if (info.Spider != null)
		{
			info.Spider.Reset();
		}
		crabs.Add(info);
	}

	private void FixedUpdate()
	{
		if (crabs == null)
		{
			return;
		}
		for (int i = crabs.Count - 1; i >= 0; i--)
		{
			CrabInfo c = crabs[i];
			if (c == null || c.Crab == null || !c.Crab.activeInHierarchy)
			{
				crabs.RemoveAt(i);
				continue;
			}
			Vector3 target = c.ChasingPlayer != null ? c.ChasingPlayer.transform.position : c.Goal;
			Vector3 curPos = c.Rigid != null ? c.Rigid.position : c.Crab.transform.position;
			Vector3 diff = target - curPos;
			diff.y = 0f;
			if (diff.sqrMagnitude > 0.25f)
			{
				Vector3 nextPos = curPos + diff.normalized * (c.Speed * Time.fixedDeltaTime);
				if (c.Rigid != null && c.Rigid.isKinematic)
				{
					c.Rigid.MovePosition(nextPos);
				}
				else if (c.Rigid != null)
				{
					c.Rigid.velocity = new Vector3(diff.normalized.x * c.Speed, c.Rigid.velocity.y, diff.normalized.z * c.Speed);
				}
				else
				{
					c.Crab.transform.position = nextPos;
				}
			}
			else if (c.ChasingPlayer == null)
			{
				if (crabPool != null)
				{
					crabPool.Release(c.Crab);
				}
				else
				{
					c.Crab.SetActive(false);
				}
				crabs.RemoveAt(i);
			}
		}
	}

	public CrabInfo GetCrabWithRigid(Rigidbody rigid)
	{
		if (crabs == null || rigid == null)
		{
			return null;
		}
		for (int i = 0; i < crabs.Count; i++)
		{
			if (crabs[i] != null && crabs[i].Rigid == rigid)
			{
				return crabs[i];
			}
		}
		return null;
	}

	public void ScareCrab(Vector3 hitPos, CrabInfo crabHit)
	{
		if (crabHit == null)
		{
			return;
		}
		if (CrabScareClips != null)
		{
			CrabScareClips.Play(null, hitPos, 1f, 1f);
		}
		if (crabHit.Barrel != null)
		{
			crabHit.Barrel.Explode();
		}
		crabHit.ChasingPlayer = null;
		crabHit.Speed = CrabFleeSpeed;
		Vector3 away = (crabHit.Crab.transform.position - hitPos).normalized;
		away.y = 0f;
		crabHit.Goal = crabHit.Crab.transform.position + away * (SpawnRadius * 2f);
		StartCoroutine(DelayedCrapRelease(crabHit));
	}

	private IEnumerator DelayedCrapRelease(CrabInfo crab)
	{
		yield return new WaitForSeconds(3f);
		if (crab != null && crab.Crab != null)
		{
			if (crabPool != null)
			{
				crabPool.Release(crab.Crab);
			}
			else
			{
				crab.Crab.SetActive(false);
			}
			crabs.Remove(crab);
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
