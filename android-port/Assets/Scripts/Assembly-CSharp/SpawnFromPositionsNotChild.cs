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
	}

	public void StartSpawner()
	{
	}

	private IEnumerator SpawnRoutine()
	{
		return null;
	}

	public void Spawn()
	{
	}
}
