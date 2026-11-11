using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossObjectSpawner : MonoBehaviour
{
	public Transform SpawnOriginPosition;

	public List<GameObject> ObjectsToSpawn;

	public Vector2 AmountToSpawn = new Vector2(1f, 2f);

	public Vector2 SpawnPositionRangeX = new Vector2(-4f, 4f);

	public float SpawnForce = 10f;

	public Vector2 SpawnIntervalRange = new Vector2(1.5f, 3f);

	public float InitialDelay = 1f;

	public ParticleSystem RiseParticles;

	public BossStage BossStage;

	public Vector2 ScaleModRange = new Vector2(0.8f, 1.2f);

	public int MaxSpawns = 20;

	private float spawnTimer;

	private int currentSpawns;

	private void Awake()
	{
		enabled = false;
		if (BossStage != null)
		{
			BossStage.OnChallengeBegin += () => enabled = true;
			BossStage.OnChallengeEnd += () => enabled = false;
		}
	}

	private void Start()
	{
		spawnTimer = InitialDelay;
	}

	private void Update()
	{
		spawnTimer -= Time.deltaTime;
		if (spawnTimer <= 0f)
		{
			SpawnNew();
			spawnTimer = Random.Range(SpawnIntervalRange.x, SpawnIntervalRange.y);
		}
	}

	private void SpawnNew()
	{
		if (ObjectsToSpawn == null || ObjectsToSpawn.Count == 0 || SpawnOriginPosition == null)
		{
			return;
		}
		int count = Random.Range(Mathf.RoundToInt(AmountToSpawn.x), Mathf.RoundToInt(AmountToSpawn.y) + 1);
		for (int i = 0; i < count; i++)
		{
			if (MaxSpawns > 0 && currentSpawns >= MaxSpawns)
			{
				enabled = false;
				return;
			}
			GameObject prefab = ObjectsToSpawn[Random.Range(0, ObjectsToSpawn.Count)];
			if (prefab == null)
			{
				continue;
			}
			Vector3 pos = SpawnOriginPosition.position + Vector3.right * Random.Range(SpawnPositionRangeX.x, SpawnPositionRangeX.y);
			Quaternion rot = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
			GameObject instance = Object.Instantiate(prefab, pos, rot, transform);
			instance.transform.localScale *= Random.Range(ScaleModRange.x, ScaleModRange.y);
			if (RiseParticles != null)
			{
				RiseParticles.transform.position = pos;
				RiseParticles.Emit(30);
			}
			StartCoroutine(RiseRoutine(instance));
			currentSpawns++;
		}
	}

	private IEnumerator RiseRoutine(GameObject go)
	{
		if (go == null)
		{
			yield break;
		}
		Vector3 targetScale = go.transform.localScale;
		float t = 0f;
		while (t < 0.25f && go != null)
		{
			t += Time.deltaTime;
			go.transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, t / 0.25f);
			yield return null;
		}
		if (go != null)
		{
			go.transform.localScale = targetScale;
			Rigidbody rb = go.GetComponent<Rigidbody>();
			if (rb != null && SpawnForce != 0f)
			{
				rb.AddForce(Vector3.up * SpawnForce, ForceMode.Impulse);
			}
		}
	}
}
