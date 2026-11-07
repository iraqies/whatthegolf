using System.Collections;
using UnityEngine;

public class DPIspawnObjectsAround : BaseDailyPrizeInteractions
{
	public GameObject[] objectToSpawnList;

	public float[] customStrengthList;

	public float[] customScale;

	public GameObject spawnFX;

	public float shootCooldown;

	public float forceMultiplier;

	public float spawnDist;

	public float minThreshold;

	public float maxThreshold;

	public float randomRotation;

	private GameObject currentObject;

	private Vector3 currentBoost;

	private bool canSpawn;

	private int currentIndex;

	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	private IEnumerator ActivateRagdollAndForce()
	{
		return null;
	}

	private bool isInRange(Vector3 boost)
	{
		return false;
	}
}
