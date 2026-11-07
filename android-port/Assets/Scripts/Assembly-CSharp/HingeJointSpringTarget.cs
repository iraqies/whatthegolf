using System;
using UnityEngine;

public class HingeJointSpringTarget : MonoBehaviour, IHitscanTarget
{
	public LayerMask AcceptedHitLayers;

	private HingeJoint joint;

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

	public void OnHit(Vector3 point)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
