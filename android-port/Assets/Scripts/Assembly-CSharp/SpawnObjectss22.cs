using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectss22 : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> ObjectToSpawn;

	[SerializeField]
	private List<Transform> PositionsToSpawnFrom;

	[SerializeField]
	private float ejectForce;

	[SerializeField]
	private float ejectTouqe;

	[SerializeField]
	private int numberToSpawn;

	private WaitForSeconds wait;

	public void Spawn()
	{
		StartCoroutine(SpawnCR());
	}

	private IEnumerator SpawnCR()
	{
		for (int i = 0; i < numberToSpawn; i++)
		{
			if (ObjectToSpawn != null && ObjectToSpawn.Count > 0 && PositionsToSpawnFrom != null && PositionsToSpawnFrom.Count > 0)
			{
				GameObject original = ObjectToSpawn[Random.Range(0, ObjectToSpawn.Count)];
				Transform transform = PositionsToSpawnFrom[Random.Range(0, PositionsToSpawnFrom.Count)];
				if (original != null && transform != null)
				{
					GameObject gameObject = Object.Instantiate(original);
					gameObject.transform.position = transform.position;
					gameObject.transform.localRotation = transform.rotation;
					Rigidbody component = gameObject.GetComponent<Rigidbody>();
					if (component != null)
					{
						component.AddForce(gameObject.transform.forward * ejectForce);
						component.AddTorque(gameObject.transform.forward * ejectTouqe);
					}
				}
			}
			yield return wait;
		}
	}

	public SpawnObjectss22()
	{
		wait = new WaitForSeconds(0.01f);
	}
}
