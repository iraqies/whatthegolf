using System.Collections;
using UnityEngine;

public class HoleProjectile : MonoBehaviour
{
	public GameObject holeToInstantiate;

	public MeshRenderer holeRender;

	[SerializeField]
	private float distThres;

	private Transform closest;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Spawn()
	{
	}

	private void DestroyHole()
	{
	}

	private IEnumerator DestoryCR()
	{
		return null;
	}

	private float GetDistToClosestHole(Transform[] enemies)
	{
		return 0f;
	}
}
