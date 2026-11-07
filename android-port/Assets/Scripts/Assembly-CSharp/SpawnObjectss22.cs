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
	}

	private IEnumerator SpawnCR()
	{
		return null;
	}
}
