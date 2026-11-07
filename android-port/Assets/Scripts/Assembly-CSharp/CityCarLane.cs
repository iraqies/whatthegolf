using UnityEngine;

public class CityCarLane : MonoBehaviour
{
	[SerializeField]
	private float minDelay;

	[SerializeField]
	private float maxDelay;

	[SerializeField]
	private float startDelay;

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
	}

	private void Update()
	{
	}

	private void Car_OnEnterEnd(CityCar car)
	{
	}
}
