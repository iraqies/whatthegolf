using System.Collections;
using UnityEngine;

public class DPIspawnObjectsAround : BaseDailyPrizeInteractions
{
	public GameObject[] objectToSpawnList;

	public float[] customStrengthList;

	public float[] customScale;

	public GameObject spawnFX;

	public float shootCooldown = 0.5f;

	public float forceMultiplier = 1f;

	public float spawnDist = 30f;

	public float minThreshold;

	public float maxThreshold = 1f;

	public float randomRotation = 1f;

	private GameObject currentObject;

	private Vector3 currentBoost;

	private bool canSpawn = true;

	private int currentIndex;

	public override void OnShootNotWrapped(Vector3 b)
	{
		if (!isInRange(b) || !canSpawn || objectToSpawnList == null || objectToSpawnList.Length == 0)
			return;

		if (b.magnitude < 0.3f)
		{
			b = new Vector3(0.4f, 0f, 0.9f);
		}
		currentIndex = Random.Range(0, objectToSpawnList.Length);
		Vector3 pos = transform.position;
		float r1 = Random.Range(-0.5f, 0.5f);
		float r2 = Random.Range(-0.1f, 0.1f);
		Vector3 camPos = Camera.main != null ? Camera.main.transform.position : Vector3.zero;
		currentBoost = b;

		Vector3 spawnPos = new Vector3(
			pos.x - b.x * spawnDist,
			pos.y + spawnDist * b.y * -1.2f + 20f,
			pos.z - spawnDist * b.z
		);
		Vector3 lookTarget = new Vector3(
			camPos.x + r1 * randomRotation,
			camPos.y + r2 * randomRotation,
			camPos.z
		);
		Quaternion rot = Quaternion.LookRotation(lookTarget - spawnPos, Vector3.up);
		currentObject = Instantiate(objectToSpawnList[currentIndex], spawnPos, rot);

		if (spawnFX != null)
		{
			GameObject fx = Instantiate(spawnFX, spawnPos, Quaternion.identity);
			if (fx != null)
			{
				Destroy(fx, 3f);
			}
		}

		if (customScale != null && currentIndex < customScale.Length && currentObject != null)
		{
			currentObject.transform.localScale = Vector3.one * customScale[currentIndex];
		}

		StartCoroutine(ActivateRagdollAndForce());
	}

	private IEnumerator ActivateRagdollAndForce()
	{
		canSpawn = false;
		yield return new WaitForEndOfFrame();

		if (currentObject != null)
		{
			ToggleGenericRagdoll ragdoll = currentObject.GetComponent<ToggleGenericRagdoll>();
			Rigidbody rb = currentObject.GetComponentInChildren<Rigidbody>();

			if (ragdoll != null)
			{
				ragdoll.RagdollOn();
				float customStr = (customStrengthList != null && currentIndex < customStrengthList.Length) ? customStrengthList[currentIndex] : 1f;
				ragdoll.SetVelocity(currentBoost * forceMultiplier * customStr + Vector3.up * 10f);
			}
			else if (rb != null)
			{
				float customStr = (customStrengthList != null && currentIndex < customStrengthList.Length) ? customStrengthList[currentIndex] : 1f;
				rb.AddForce(currentBoost * forceMultiplier * 10f * customStr + Vector3.up * 10f, ForceMode.VelocityChange);
			}
		}

		yield return new WaitForSeconds(shootCooldown);
		canSpawn = true;
	}

	private bool isInRange(Vector3 boost)
	{
		float m = boost.magnitude;
		return m >= minThreshold && m <= maxThreshold;
	}
}
