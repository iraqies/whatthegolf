using UnityEngine;

public class SleepVelocity : MonoBehaviour
{
	public Vector3 up = Vector3.up;

	public float threshold = 0.05f;

	public float breakAmount = 0.95f;

	private Rigidbody rigid;

	private float currentVelocity;

	private float timer;

	public float timerThreshold = 1f;

	public float yThreshold = 0.02f;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (rigid == null) return;
		currentVelocity = Vector3.ProjectOnPlane(rigid.velocity, up).magnitude;
		float verticalSpeed = Vector3.Project(rigid.velocity, up).magnitude;
		if (currentVelocity < threshold && verticalSpeed <= yThreshold)
		{
			timer += Time.fixedDeltaTime;
		}
		else
		{
			timer = 0f;
		}

		if (timer > timerThreshold && currentVelocity > Physics.sleepThreshold * 2f && !rigid.IsSleeping())
		{
			Vector3 vUp = Vector3.Project(rigid.velocity, up);
			Vector3 vPlane = Vector3.ProjectOnPlane(rigid.velocity, up);
			rigid.velocity = vUp + vPlane * breakAmount;
		}
	}
}
