using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class ExplodeChallenge : Challenge
{
	public FlyingExplosionShooter flyingExplosionShooterPrefab;

	public Transform spawnPoint;

	private FlyingExplosionShooter _currentFlyingExplosion;

	private CBFollow _cbFollow;

	public int destructionToWin;

	private int _destructionCount;

	public List<GameObject> objectsToDestroy;

	public float explosionPower;

	protected override void Activate()
	{
	}

	private void OnOnOutOfBounds(OutOfBoundsTrigger obj)
	{
	}

	private void SpawnNewBarrel()
	{
	}

	private void OnExplode(GameObject explodeObject)
	{
	}
}
