using Chronos;
using UnityEngine;

public class SleepVelocityTimeline : MonoBehaviour
{
	public Vector3 up;

	public float threshold;

	public float breakAmount;

	private float currentVelocity;

	private float timer;

	public float timerThreshold;

	public float yThreshold;

	private Timeline timeline;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
