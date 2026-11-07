using UnityEngine;
using UnityEngine.Events;

public class SpawnObject : MonoBehaviour
{
	[SerializeField]
	private GameObject m_prefab;

	[SerializeField]
	private Transform m_spawnPosition;

	[SerializeField]
	private UnityEvent<GameObject> onObjectSpawned;

	public void SpawnTheThing()
	{
	}
}
