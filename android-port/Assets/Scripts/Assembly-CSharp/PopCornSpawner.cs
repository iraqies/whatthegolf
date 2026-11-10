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
		if (!spawned)
		{
			StartCoroutine(SpawnCoroutine());
			spawned = true;
		}
	}

	private void AddPopCorn()
	{
		collectedCorn++;
	}

	private IEnumerator SpawnCoroutine()
	{
		if (m_lid != null)
		{
			m_lid.SetActive(value: true);
		}
		OnLidAppears?.Invoke();
		yield return new WaitForSeconds(0.6f);
		popCornToSpawn = collectedCorn * 8;
		for (int i = 0; i < popCornToSpawn; i++)
		{
			if (m_cornPrefabs != null && m_cornPrefabs.Length > 0 && m_popCornSpawnPosition != null)
			{
				GameObject obj = Object.Instantiate(m_cornPrefabs[Random.Range(0, Mathf.Min(3, m_cornPrefabs.Length))], m_popCornSpawnPosition.position, Quaternion.identity);
				popCorn.Add(obj.transform);
			}
			if (i % 5 == 0)
			{
				OnPopCornPops?.Invoke();
			}
			if (storedCorn != null && i < storedCorn.Count && storedCorn[i] != null)
			{
				Object.Destroy(storedCorn[i]);
			}
			yield return new WaitForSeconds(0.01f);
		}
		if (m_lid != null)
		{
			Rigidbody component = m_lid.GetComponent<Rigidbody>();
			if (component != null && m_popCornSpawnPosition != null)
			{
				component.AddExplosionForce(70f, m_popCornSpawnPosition.position, 10f, 0f, ForceMode.VelocityChange);
			}
		}
		if (m_stoveRb != null)
		{
			m_stoveRb.mass = 10f;
		}
		if (m_multiCameraFollow != null)
		{
			m_multiCameraFollow.objectsToFollow = popCorn;
			m_multiCameraFollow.enabled = true;
		}
		OnPopcornCooked?.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("Corn"))
		{
			storedCorn.Add(other.gameObject);
			collectedCorn++;
		}
	}

	public PopCornSpawner()
	{
		collectedCorn = 1;
		storedCorn = new List<GameObject>();
		popCorn = new List<Transform>();
	}
}
