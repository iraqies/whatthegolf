using System.Collections;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
	public GameObject[] EjectableFoodPrefabs;

	public float EjectForce = 8f;

	public float EjectForceAngular = 180f;

	public int FoodEjectedPerHit = 3;

	public float CooldownBetweenEachFood = 0.1f;

	public float EjectCooldown = 0.5f;

	private bool onCooldown;

	public int FoodLeft = 15;

	public Transform FoodEjectPosition;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!onCooldown && FoodLeft > 0 && collision != null)
		{
			StartCoroutine(FoodEjectionRoutine());
		}
	}

	private IEnumerator FoodEjectionRoutine()
	{
		onCooldown = true;
		int count = Mathf.Min(Mathf.Max(1, FoodEjectedPerHit), FoodLeft);
		for (int i = 0; i < count; i++)
		{
			EjectFood();
			FoodLeft--;
			if (CooldownBetweenEachFood > 0f)
			{
				yield return new WaitForSeconds(CooldownBetweenEachFood);
			}
		}
		if (EjectCooldown > 0f)
		{
			yield return new WaitForSeconds(EjectCooldown);
		}
		onCooldown = false;
	}

	private void EjectFood()
	{
		if (EjectableFoodPrefabs == null || EjectableFoodPrefabs.Length == 0)
		{
			return;
		}
		GameObject prefab = EjectableFoodPrefabs[Random.Range(0, EjectableFoodPrefabs.Length)];
		if (prefab == null)
		{
			return;
		}
		Vector3 pos = FoodEjectPosition != null ? FoodEjectPosition.position : transform.position;
		GameObject spawned = Object.Instantiate(prefab, pos, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
		spawned.SetActive(true);
		Rigidbody2D rb = spawned.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			Vector2 dir = Random.insideUnitCircle.normalized;
			if (dir.sqrMagnitude < 0.01f)
			{
				dir = Vector2.up;
			}
			rb.AddForce(dir * EjectForce, ForceMode2D.Impulse);
			rb.angularVelocity = Random.Range(-EjectForceAngular, EjectForceAngular);
		}
	}
}
