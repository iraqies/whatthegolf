using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopCornSpawner : MonoBehaviour
{
	public int collectedCorn;

	[SerializeField]
	private MultiplePlayerCameraFollow m_multiCameraFollow;

	[SerializeField]
	private Transform m_popCornSpawnPosition;

	[SerializeField]
	private GameObject[] m_cornPrefabs;

	[SerializeField]
	private GameObject m_lid;

	[SerializeField]
	private Rigidbody m_stoveRb;

	[SerializeField]
	private UnityEvent OnPopCornPops;

	[SerializeField]
	private UnityEvent OnLidAppears;

	[SerializeField]
	private UnityEvent OnPopcornCooked;

	private bool spawned;

	private int popCornToSpawn;

	private List<GameObject> storedCorn;

	private List<Transform> popCorn;

	public void SpawnpopCorn()
	{
	}

	private void AddPopCorn()
	{
	}

	private IEnumerator SpawnCoroutine()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
