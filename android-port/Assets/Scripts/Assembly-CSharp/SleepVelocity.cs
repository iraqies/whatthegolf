using UnityEngine;

public class SleepVelocity : MonoBehaviour
{
	public Vector3 up;

	public float threshold;

	public float breakAmount;

	private Rigidbody rigid;

	private float currentVelocity;

	private float timer;

	public float timerThreshold;

	public float yThreshold;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
