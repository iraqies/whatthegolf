using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsFromPipe : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> ObjectToSpawn;

	[SerializeField]
	private Transform PositionToSpawnFrom;

	[SerializeField]
	private float ejectForce;

	[SerializeField]
	private ForceMode ejectForceMode;

	[SerializeField]
	private float ejectTorque;

	[SerializeField]
	private int numberToSpawn;

	private Vector3 forceDirection;

	private WaitForSeconds wait;

	public float delay;

	public void Spawn()
	{
		StartCoroutine(SpawnCR());
	}

	private IEnumerator SpawnCR()
	{
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < numberToSpawn; i++)
		{
			if (ObjectToSpawn != null && ObjectToSpawn.Count > 0 && PositionToSpawnFrom != null)
			{
				GameObject gameObject = Object.Instantiate(ObjectToSpawn[Random.Range(0, ObjectToSpawn.Count)]);
				gameObject.transform.position = PositionToSpawnFrom.position;
				gameObject.transform.localRotation = PositionToSpawnFrom.rotation;
				Rigidbody component = gameObject.GetComponent<Rigidbody>();
				if (component != null)
				{
					Vector3 forward = gameObject.transform.forward;
					float num = Random.Range(-0.2f, 0.2f);
					float num2 = Random.Range(-0.2f, 0.2f);
					component.AddForce(new Vector3((forward.x + num) * ejectForce, forward.y * ejectForce, (forward.z + num2) * ejectForce), ejectForceMode);
					component.AddTorque(new Vector3(ejectTorque, ejectTorque, ejectTorque), ejectForceMode);
				}
			}
			yield return wait;
		}
	}

	public SpawnObjectsFromPipe()
	{
		wait = new WaitForSeconds(0.01f);
	}
}
