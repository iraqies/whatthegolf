using System.Collections;
using Core;
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
		StartCoroutine(SpawnBarrelRoutine());
	}

	private IEnumerator SpawnBarrelRoutine()
	{
		FrogeyKongController.SetTrigger("Throw");
		yield return new WaitForSeconds(BarrelSpawnDelay);
		SpawnBarrel();
		yield return new WaitForSeconds(DelayBetweenBarrels);
		StartCoroutine(SpawnBarrelRoutine());
	}

	private void SpawnBarrel()
	{
		ExplosionBarrel2D explosionBarrel2D = Object.Instantiate(barrelPrefab, barrelSpawnPoint.position, Quaternion.identity);
		explosionBarrel2D.OnExplode += OnExplode;
		activeBarrel = explosionBarrel2D.transform;
	}

	private void OnExplode(Collider2D col)
	{
		Level.Instance.Fail(true, true, null, 0f, true, "");
	}
}
