using System.Collections;
using UnityEngine;

public class DonkeyKongLevel : MonoBehaviour
{
	[SerializeField]
	private Transform barrelSpawnPoint;

	[SerializeField]
	private ExplosionBarrel2D barrelPrefab;

	[SerializeField]
	private float spawnY;

	private Transform activeBarrel;

	public Animator FrogeyKongController;

	public float BarrelSpawnDelay;

	public float DelayBetweenBarrels;

	private void Start()
	{
	}

	private IEnumerator SpawnBarrelRoutine()
	{
		return null;
	}

	private void SpawnBarrel()
	{
	}

	private void OnExplode(Collider2D col)
	{
	}
}
