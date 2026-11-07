using System.Collections.Generic;
using Core;
using UnityEngine;
using VFX;

public class FreezeOnHittingFallingObject : MonoBehaviour
{
	private Rigidbody rigidbody;

	private FixedJoint joint;

	private Collider collider;

	private List<Collider> ignoreColliders;

	private TrajectoryProjector trajectory;

	private GolfBallShooterBase shooter;

	private float origShootingThreshold;

	private void Awake()
	{
	}

	private void InstanceOnOnOutOfBounds()
	{
	}

	private void BallOnOnShoot(Vector3 vector3)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
