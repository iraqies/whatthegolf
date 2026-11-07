using UnityEngine;

public class SpawnParticlesOnHitPosition : MonoBehaviour
{
	public string acceptedTag;

	public GameObject particlePrefab;

	public Transform staticSpawnPos;

	private Vector3 particleDir;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void SpawnParticles(Vector3 spawnPos)
	{
	}
}
