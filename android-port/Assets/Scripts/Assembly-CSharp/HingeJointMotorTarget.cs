using System;
using UnityEngine;

public class HingeJointMotorTarget : MonoBehaviour, IHitscanTarget
{
	public float StayDuration = 1f;

	public float ShowInterval = 2f;

	public float TargetVelocitySize = 50f;

	public float StartyDelay;

	public LayerMask AcceptedHitLayers;

	private HingeJoint joint;

	private float timer;

	public Action<IHitscanTarget> OnHitscanHit
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	private void Start()
	{
		timer = 0f - StartyDelay;
		joint = GetComponentInChildren<HingeJoint>();
	}

	private void Update()
	{
		timer += Time.deltaTime;
		if (timer >= ShowInterval)
		{
			JointMotor motor = joint.motor;
			motor.targetVelocity = 0f - TargetVelocitySize;
			if (timer >= ShowInterval + StayDuration)
			{
				motor.targetVelocity = TargetVelocitySize;
				timer = 0f;
			}
			joint.motor = motor;
		}
	}

	public void OnHit(Vector3 point)
	{
		if (joint != null)
		{
			joint.useMotor = false;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (base.enabled && (int)AcceptedHitLayers == ((int)AcceptedHitLayers | (1 << other.gameObject.layer)))
		{
			OnHit(other.contacts[0].point);
		}
	}
}
