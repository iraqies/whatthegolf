using UnityEngine;

public class CityCarLane : MonoBehaviour
{
	[SerializeField]
	private float minDelay = 1.8f;

	[SerializeField]
	private float maxDelay = 3f;

	[SerializeField]
	private float startDelay = 1f;

	[SerializeField]
	private Collider enterCollider;

	[SerializeField]
	private Collider exitCollider;

	[SerializeField]
	private CityCar[] cars;

	private int index;

	private float nextSpawnTime;

	private void Awake()
	{
		CityCar[] array = cars;
		foreach (CityCar cityCar in array)
		{
			cityCar.Init(enterCollider, exitCollider);
			cityCar.OnEnterEnd += Car_OnEnterEnd;
			cityCar.gameObject.SetActive(false);
		}
		nextSpawnTime = Time.time + startDelay;
	}

	private void Update()
	{
		if (Time.time >= nextSpawnTime && !cars[index].gameObject.activeSelf)
		{
			CityCar cityCar = cars[index];
			cityCar.transform.position = enterCollider.transform.position;
			cityCar.transform.rotation = enterCollider.transform.rotation;
			cityCar.gameObject.SetActive(true);
			index = (index + 1) % cars.Length;
			nextSpawnTime = Time.time + Random.Range(minDelay, maxDelay);
		}
	}

	private void Car_OnEnterEnd(CityCar car)
	{
		car.gameObject.SetActive(false);
		Vector3 center = enterCollider.bounds.center;
		car.transform.position = new Vector3(center.x, car.transform.position.y, center.z);
	}
}
