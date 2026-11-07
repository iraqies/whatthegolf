using System.Collections;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
	public GameObject[] EjectableFoodPrefabs;

	public float EjectForce;

	public float EjectForceAngular;

	public int FoodEjectedPerHit;

	public float CooldownBetweenEachFood;

	public float EjectCooldown;

	private bool onCooldown;

	public int FoodLeft;

	public Transform FoodEjectPosition;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private IEnumerator FoodEjectionRoutine()
	{
		return null;
	}

	private void EjectFood()
	{
	}
}
