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
		shooter = GetComponent<GolfBallShooterBase>();
		origShootingThreshold = shooter.sqrVelocityShootingThreshold;
		trajectory = GetComponent<TrajectoryProjector>();
		ignoreColliders = new List<Collider>();
		rigidbody = GetComponent<Rigidbody>();
		collider = GetComponent<Collider>();
		Level.Instance.Ball.OnShoot += BallOnOnShoot;
		Level.Instance.OnOutOfBounds += InstanceOnOnOutOfBounds;
	}

	private void InstanceOnOnOutOfBounds()
	{
		Object.Destroy(joint);
		joint = null;
		foreach (Collider ignoreCollider in ignoreColliders)
		{
			trajectory.RemoveIgnoreObject(ignoreCollider);
			Physics.IgnoreCollision(collider, ignoreCollider, ignore: false);
		}
		ignoreColliders.Clear();
	}

	private void BallOnOnShoot(Vector3 vector3)
	{
		Object.Destroy(joint);
		joint = null;
		shooter.sqrVelocityShootingThreshold = origShootingThreshold;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("Car"))
		{
			foreach (Collider ignoreCollider in ignoreColliders)
			{
				trajectory.RemoveIgnoreObject(ignoreCollider);
				Physics.IgnoreCollision(collider, ignoreCollider, ignore: false);
			}
			ignoreColliders.Clear();
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			joint = base.gameObject.AddComponent<FixedJoint>();
			joint.connectedBody = other.rigidbody;
			Physics.IgnoreCollision(collider, other.collider, ignore: true);
			ignoreColliders.Add(other.collider);
			trajectory.AddIgnoreObject(other.collider);
			shooter.sqrVelocityShootingThreshold = float.PositiveInfinity;
		}
	}
}
