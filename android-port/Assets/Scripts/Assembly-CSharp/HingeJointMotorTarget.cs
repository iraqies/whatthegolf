using System;
using UnityEngine;

public class HingeJointMotorTarget : MonoBehaviour, IHitscanTarget
{
	public float StayDuration;

	public float ShowInterval;

	public float TargetVelocitySize;

	public float StartyDelay;

	public LayerMask AcceptedHitLayers;

	private HingeJoint joint;

	private float timer;

	public Action<IHitscanTarget> OnHitscanHit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnHit(Vector3 point)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
