using Chronos;
using UnityEngine;

public class SleepVelocityTimeline : MonoBehaviour
{
	public Vector3 up = Vector3.up;

	public float threshold = 0.05f;

	public float breakAmount = 0.95f;

	private float currentVelocity;

	private float timer;

	public float timerThreshold = 1f;

	public float yThreshold = 0.02f;

	private Timeline timeline;

	private void Start()
	{
		timeline = GetComponent<Timeline>();
	}

	private void FixedUpdate()
	{
		if (timeline == null || timeline.rigidbody == null)
		{
			return;
		}
		Vector3 vel = timeline.rigidbody.velocity;
		currentVelocity = Vector3.ProjectOnPlane(vel, up).magnitude;
		float vertVel = Vector3.Project(vel, up).magnitude;
		if (currentVelocity < threshold && vertVel <= yThreshold)
		{
			timer += timeline.fixedDeltaTime;
		}
		else
		{
			timer = 0f;
		}
		if (timer > timerThreshold && currentVelocity > Physics.sleepThreshold * 2f)
		{
			Vector3 v = timeline.rigidbody.velocity;
			timeline.rigidbody.velocity = Vector3.Project(v, up) + Vector3.ProjectOnPlane(v, up) * breakAmount;
		}
	}
}
