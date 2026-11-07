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
	private List<GameObject> Additional_Prefabs;

	[SerializeField]
	private ClipSettingsCollection clipCollection;

	[SerializeField]
	private Transform[] Positions;

	[SerializeField]
	private SpawnPositionMode m_SpawnPositionMode;

	[SerializeField]
	private bool StartOnAwake;

	[SerializeField]
	private ParticleSystem SpawnParticles;

	[SerializeField]
	private int SpawnAmount;

	[SerializeField]
	private int SimultaneousSpawnedObjects;

	[SerializeField]
	private bool m_UseTransformChildCountAsSpawnAmount;

	private List<GameObject> objectsInScene;

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
	}

	public void StartSpawner()
	{
	}

	private IEnumerator SpawnRoutine()
	{
		return null;
	}

	private bool CanSpawn()
	{
		return false;
	}

	private void CheckForDestroyedObjects()
	{
	}

	public void Spawn()
	{
	}
}
