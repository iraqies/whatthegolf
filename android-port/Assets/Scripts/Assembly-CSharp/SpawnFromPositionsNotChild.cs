using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class SpawnFromPositionsNotChild : MonoBehaviour
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

	public GameObject Prefab;

	public List<GameObject> Additional_Prefabs;

	[SerializeField]
	private ClipSettingsCollection clipCollection;

	public Transform[] Positions;

	public SpawnPositionMode m_SpawnPositionMode;

	public bool StartOnAwake;

	[SerializeField]
	private ParticleSystem SpawnParticles;

	public int SpawnAmount;

	public int maxSpawned;

	public float SpawnStartDelay;

	public float DefaultInterval;

	public bool UseCustomInterval;

	public List<float> CustomIntervals;

	public SpawnMethodEnum SpawnMethod;

	public List<MonoBehaviour> Behaviours;

	public UnityEvent OnAllEnabled;

	public UnityEvent OnSpawn;

	private int m_IntervalIndex;

	private int m_PositionIndex;

	private int m_SpawnCount;

	public bool IsRunning;

	private void Awake()
	{
		if (Additional_Prefabs != null)
		{
			Additional_Prefabs.Add(Prefab);
		}
		if (StartOnAwake)
		{
			StartCoroutine(SpawnRoutine());
		}
	}

	public void StartSpawner()
	{
		StartCoroutine(SpawnRoutine());
	}

	private IEnumerator SpawnRoutine()
	{
		IsRunning = true;
		yield return new WaitForSeconds(SpawnStartDelay);
		while (SpawnAmount == -1 || m_SpawnCount < SpawnAmount)
		{
			float seconds;
			if (UseCustomInterval && CustomIntervals != null && CustomIntervals.Count > 0)
			{
				seconds = CustomIntervals[m_IntervalIndex];
				m_IntervalIndex = (m_IntervalIndex + 1) % CustomIntervals.Count;
			}
			else
			{
				seconds = DefaultInterval;
			}
			Spawn();
			yield return new WaitForSeconds(seconds);
		}
		IsRunning = false;
	}

	public void Spawn()
	{
		if (Positions == null || Positions.Length == 0)
		{
			return;
		}
		switch (m_SpawnPositionMode)
		{
		case SpawnPositionMode.Random:
			m_PositionIndex = Random.Range(0, Positions.Length);
			break;
		case SpawnPositionMode.RandomNonRepeating:
		{
			int num;
			do
			{
				num = Random.Range(0, Positions.Length);
			}
			while (Positions.Length >= 2 && num == m_PositionIndex);
			m_PositionIndex = num;
			break;
		}
		case SpawnPositionMode.Sequence:
			m_PositionIndex = (m_PositionIndex + 1) % Positions.Length;
			break;
		}
		Transform transform = Positions[m_PositionIndex];
		if (SpawnMethod != SpawnMethodEnum.SpawnNew)
		{
			if (Behaviours == null || Behaviours.Count == 0)
			{
				OnAllEnabled?.Invoke();
				StopAllCoroutines();
			}
			else
			{
				int index = Random.Range(0, Behaviours.Count);
				if (Behaviours[index] != null)
				{
					Behaviours[index].enabled = true;
				}
				Behaviours.RemoveAt(index);
			}
		}
		else if (Additional_Prefabs != null && Additional_Prefabs.Count > 0 && transform != null)
		{
			int index2 = Random.Range(0, Additional_Prefabs.Count);
			GameObject gameObject = Object.Instantiate(Additional_Prefabs[index2], transform.position, transform.rotation);
			if (gameObject != null)
			{
				gameObject.SetActive(value: true);
				if (clipCollection != null)
				{
					clipCollection.Play(gameObject.transform.position);
				}
			}
			OnSpawn?.Invoke();
		}
		m_SpawnCount++;
		if (SpawnParticles != null && transform != null)
		{
			SpawnParticles.transform.position = transform.position;
			SpawnParticles.Emit(50);
		}
	}

	public SpawnFromPositionsNotChild()
	{
		SpawnAmount = -1;
		m_PositionIndex = -1;
	}
}
