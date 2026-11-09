using Chronos;
using UnityEngine;

public class TimedCarAgent : CarAgent
{
	public Vector3 timedGravity;

	private Timeline timeline;

	private void OnEnable()
	{
		timeline = GetComponent<Timeline>();
	}

	protected override void Unlock()
	{
		if (isLocked && Time.time > startLockTime)
		{
			if (timeline != null && timeline.rigidbody != null)
				timeline.rigidbody.useGravity = true;
			else if (rigid != null)
				rigid.useGravity = true;
			isLocked = false;
			_onCarCrashed?.Invoke();
		}
	}

	protected override void FixedUpdate()
	{
		float dt = timeline != null ? timeline.fixedDeltaTime : Time.fixedDeltaTime;
		if (IsGrounded())
		{
			nonGroundTime = 0f;
		}
		else
		{
			nonGroundTime += dt;
			if (nonGroundTime > 0.1f && hasBeenFlat)
				isFalling = true;
		}

		if (isLocked)
		{
			if (rigid != null)
			{
				rigid.velocity = transform.forward * Speed - smoothedNormal * Gravity;
			}
			Vector3 normal = GetNormal();
			smoothedNormal = Vector3.MoveTowards(smoothedNormal, normal, dt * RotateSpeed);
			Vector3 projForward = Vector3.ProjectOnPlane(transform.forward, smoothedNormal);
			smoothedFlatForward = Vector3.MoveTowards(smoothedFlatForward, projForward, dt * 3f * RotateSpeed);
			if (smoothedFlatForward.sqrMagnitude > 0.0001f)
			{
				Quaternion targetRot = Quaternion.LookRotation(smoothedFlatForward, smoothedNormal);
				if (rigid != null)
				{
					rigid.angularVelocity = Vector3.zero;
					rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, targetRot, dt * 3f * RotateSpeed));
				}
			}

			if (Vector3.Angle(transform.up, Vector3.up) < 5f && IsGrounded())
			{
				hasBeenFlat = true;
			}

			float downAngle = Vector3.Angle(transform.forward, Vector3.down);
			if (hasBeenFlat && (downAngle < 60f || nonGroundTime > 0.08f))
			{
				if (downAngle < 60f && rigid != null)
				{
					Vector3 torque = transform.right * rigid.velocity.magnitude * 100f;
					if (timeline != null && timeline.rigidbody != null)
						timeline.rigidbody.AddTorque(torque, ForceMode.Acceleration);
					else
						rigid.AddTorque(torque, ForceMode.Acceleration);
				}
				Unlock();
			}
		}
		else
		{
			if (timeline != null && timeline.rigidbody != null)
				timeline.rigidbody.AddForce(timedGravity * dt, ForceMode.Acceleration);
			else if (rigid != null)
				rigid.AddForce(timedGravity * dt, ForceMode.Acceleration);

			if (IsGrounded() && !isFalling && transform.forward.y > -0.2f)
			{
				Vector3 force = transform.forward * dt * unlockedForce;
				if (timeline != null && timeline.rigidbody != null)
					timeline.rigidbody.AddForce(force, ForceMode.Acceleration);
				else if (rigid != null)
					rigid.AddForce(force, ForceMode.Acceleration);
			}
		}
	}
}
