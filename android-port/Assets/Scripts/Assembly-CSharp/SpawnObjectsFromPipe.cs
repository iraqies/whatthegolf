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
	}

	private IEnumerator SpawnCR()
	{
		return null;
	}
}
