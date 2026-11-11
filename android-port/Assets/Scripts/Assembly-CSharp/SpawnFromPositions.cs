using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class SpawnFromPositions : MonoBehaviour
{
	public enum SpawnPositionMode
	{
		Random = 0,
		RandomNonRepeating = 1,
		Sequence = 2
	}

	public enum SpawnMethodEnum
	{
		SpawnNew = 0,
		EnableBehaviour = 1
	}

	[SerializeField]
	private GameObject Prefab;

	[SerializeField]
	private List<GameObject> Additional_Prefabs = new List<GameObject>();

	[SerializeField]
	private ClipSettingsCollection clipCollection;

	[SerializeField]
	private Transform[] Positions;

	[SerializeField]
	private SpawnPositionMode m_SpawnPositionMode;

	[SerializeField]
	private bool StartOnAwake = true;

	[SerializeField]
	private ParticleSystem SpawnParticles;

	[SerializeField]
	private int SpawnAmount = 10;

	[SerializeField]
	private int SimultaneousSpawnedObjects = 5;

	[SerializeField]
	private bool m_UseTransformChildCountAsSpawnAmount;

	private List<GameObject> objectsInScene = new List<GameObject>();

	public float SpawnStartDelay;

	public float DefaultInterval = 1f;

	public bool UseCustomInterval;

	public List<float> CustomIntervals;

	public SpawnMethodEnum SpawnMethod;

	public List<MonoBehaviour> Behaviours;

	public UnityEvent OnAllEnabled;

	public UnityEvent OnSpawn;

	private int m_IntervalIndex;

	private int m_PositionIndex = -1;

	private int m_SpawnCount;

	public bool IsRunning;

	private void Awake()
	{
		if (Additional_Prefabs == null)
		{
			Additional_Prefabs = new List<GameObject>();
		}
		if (Prefab != null && !Additional_Prefabs.Contains(Prefab))
		{
			Additional_Prefabs.Add(Prefab);
		}
		if (StartOnAwake)
		{
			StartSpawner();
		}
	}

	public void StartSpawner()
	{
		StartCoroutine(SpawnRoutine());
	}

	private IEnumerator SpawnRoutine()
	{
		IsRunning = true;
		m_SpawnCount = 0;
		if (SpawnStartDelay > 0f)
		{
			yield return new WaitForSeconds(SpawnStartDelay);
		}
		while (SpawnAmount <= 0 || m_SpawnCount < SpawnAmount)
		{
			CheckForDestroyedObjects();
			Spawn();
			float wait = DefaultInterval;
			if (UseCustomInterval && CustomIntervals != null && CustomIntervals.Count > 0)
			{
				wait = CustomIntervals[m_IntervalIndex % CustomIntervals.Count];
				m_IntervalIndex = (m_IntervalIndex + 1) % CustomIntervals.Count;
			}
			yield return new WaitForSeconds(Mathf.Max(0.05f, wait));
		}
		IsRunning = false;
	}

	private bool CanSpawn()
	{
		int count = m_UseTransformChildCountAsSpawnAmount ? transform.childCount : m_SpawnCount;
		if (SpawnAmount > 0 && count >= SpawnAmount)
		{
			return false;
		}
		if (SimultaneousSpawnedObjects > 0 && objectsInScene.Count >= SimultaneousSpawnedObjects)
		{
			return false;
		}
		return true;
	}

	private void CheckForDestroyedObjects()
	{
		if (objectsInScene == null)
		{
			return;
		}
		for (int i = objectsInScene.Count - 1; i >= 0; i--)
		{
			if (objectsInScene[i] == null)
			{
				objectsInScene.RemoveAt(i);
			}
		}
	}

	public void Spawn()
	{
		if (!CanSpawn())
		{
			return;
		}
		Transform posTrans = transform;
		if (Positions != null && Positions.Length > 0)
		{
			if (m_SpawnPositionMode == SpawnPositionMode.Sequence)
			{
				m_PositionIndex = (m_PositionIndex + 1) % Positions.Length;
			}
			else if (m_SpawnPositionMode == SpawnPositionMode.RandomNonRepeating && Positions.Length > 1)
			{
				int next = Random.Range(0, Positions.Length);
				if (next == m_PositionIndex)
				{
					next = (next + 1) % Positions.Length;
				}
				m_PositionIndex = next;
			}
			else
			{
				m_PositionIndex = Random.Range(0, Positions.Length);
			}
			if (Positions[m_PositionIndex] != null)
			{
				posTrans = Positions[m_PositionIndex];
			}
		}
		if (SpawnMethod == SpawnMethodEnum.EnableBehaviour)
		{
			if (Behaviours != null && Behaviours.Count > 0)
			{
				int idx = Random.Range(0, Behaviours.Count);
				if (Behaviours[idx] != null)
				{
					Behaviours[idx].enabled = true;
				}
				Behaviours.RemoveAt(idx);
				if (Behaviours.Count == 0)
				{
					OnAllEnabled?.Invoke();
					StopAllCoroutines();
				}
			}
		}
		else if (Additional_Prefabs != null && Additional_Prefabs.Count > 0)
		{
			GameObject chosenPrefab = Additional_Prefabs[Random.Range(0, Additional_Prefabs.Count)];
			if (chosenPrefab != null)
			{
				GameObject go = Object.Instantiate(chosenPrefab, posTrans.position, posTrans.rotation, transform);
				go.SetActive(true);
				objectsInScene.Add(go);
				if (clipCollection != null)
				{
					clipCollection.Play(null, go.transform.position, 1f, 1f);
				}
				OnSpawn?.Invoke();
			}
		}
		m_SpawnCount++;
		if (SpawnParticles != null)
		{
			SpawnParticles.transform.position = posTrans.position;
			SpawnParticles.Emit(20);
		}
	}
}
