using Core;
using UnityEngine;

public class LivingCarpet : MonoBehaviour
{
	[SerializeField]
	private HingeJoint _joint;

	[SerializeField]
	private float _targetVel = 500f;

	[SerializeField]
	private float _forceStrengh = 25f;

	[SerializeField]
	private float _timeDown = 1.5f;

	[SerializeField]
	private Transform _forceDir;

	private bool move;

	private double time;

	private void OnDrawGizmos()
	{
	}

	private void Start()
	{
	}

	private void CollisionEnterTrigger(Rigidbody obj)
	{
		if (obj == null)
		{
			return;
		}
		OnCatapultedByCarpet cat = obj.GetComponent<OnCatapultedByCarpet>();
		if (cat != null)
		{
			cat.Catapult();
		}
		if (_forceDir != null)
		{
			obj.AddForce(_forceDir.forward * _forceStrengh, ForceMode.Impulse);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || _joint == null)
		{
			return;
		}
		GolfBallController ctrl = other.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
		{
			JointMotor motor = _joint.motor;
			motor.targetVelocity = _targetVel;
			_joint.motor = motor;
			_joint.useMotor = true;
			time = Time.time;
			move = true;
			Rigidbody rb = other.attachedRigidbody;
			if (rb != null)
			{
				CollisionEnterTrigger(rb);
			}
		}
	}

	private void Update()
	{
		if (_joint == null)
		{
			return;
		}
		if (Time.time - time > _timeDown)
		{
			JointMotor motor = _joint.motor;
			motor.targetVelocity = -_targetVel;
			_joint.motor = motor;
		}
	}
}
