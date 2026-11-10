using System.Collections;
using Core;
using UnityEngine;

public class ForkShooter : GolfBallShooterBase
{
	[SerializeField]
	public float minShootVelocity;

	[SerializeField]
	public float fullShootVelocity;

	[SerializeField]
	public float pitch;

	[SerializeField]
	public float spin;

	[SerializeField]
	protected bool lookInShotDirection;

	public bool lookInAimDirection;

	[SerializeField]
	protected bool onlyLookWhenChargingOnController;

	public float LookInAimDirectionSpeed;

	[SerializeField]
	protected bool dontLookInAimDirectionWhenBlocked;

	[SerializeField]
	protected bool useLocalUp;

	[SerializeField]
	public bool zeroPitchIfNotGrouneded;

	[SerializeField]
	private float depthOfStabbing;

	[SerializeField]
	private float SecondsBeforeSticking;

	private Coroutine stickCooldown;

	private FixedJoint stickJoint;

	private Rigidbody collisionRb;

	private bool isAiming;

	private bool canStick;

	private void Start()
	{
		if (rigidbodyC != null)
		{
			rigidbodyC.maxAngularVelocity = 100f;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if ((rigidbodyC == null || !rigidbodyC.isKinematic) && !stickJoint)
		{
			return;
		}
		base.OnAimUpdate(boost, onlyAimArrow);
		isAiming = true;
		if (!lookInAimDirection || (onlyAimArrow && onlyLookWhenChargingOnController) || (dontLookInAimDirectionWhenBlocked && IsBlocking()))
		{
			return;
		}
		Vector3 upwards = (useLocalUp ? base.transform.up : Vector3.up);
		if (rigidbodyC != null && boost.sqrMagnitude > 1E-06f)
		{
			if (LookInAimDirectionSpeed == float.PositiveInfinity)
			{
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upwards));
			}
			else
			{
				rigidbodyC.MoveRotation(Quaternion.RotateTowards(rigidbodyC.rotation, Quaternion.LookRotation(boost, upwards), LookInAimDirectionSpeed * Time.deltaTime));
			}
		}
	}

	private void Update()
	{
		if (GolfBallController != null && rigidbodyC != null)
		{
			if (rigidbodyC.isKinematic || (bool)stickJoint)
			{
				GolfBallController.BlockShooting = false;
			}
			else
			{
				GolfBallController.BlockShooting = true;
			}
		}
	}

	public override void OnCancel()
	{
		isAiming = false;
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		isAiming = false;
		if (rigidbodyC != null)
		{
			rigidbodyC.isKinematic = false;
			rigidbodyC.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		}
		stickCooldown = StartCoroutine(StickCooldownRoutine(boost));
		Vector3 upwards = (useLocalUp ? base.transform.up : Vector3.up);
		if (lookInShotDirection && rigidbodyC != null && boost.sqrMagnitude > 1E-06f)
		{
			rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upwards));
		}
		Vector3 rhs = ((GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up);
		Vector3 axis = Vector3.Cross(boost, rhs);
		if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
		{
			boost = Quaternion.AngleAxis(pitch, axis) * boost;
		}
		StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
	}

	private void OnCollisionStay(Collision collision)
	{
		if (!canStick || rigidbodyC == null || rigidbodyC.isKinematic || collision == null)
		{
			return;
		}
		if (stickCooldown != null)
		{
			StopCoroutine(stickCooldown);
		}
		collisionRb = collision.transform.GetComponentInParent<Rigidbody>();
		if (collision.contacts != null && collision.contacts.Length > 0)
		{
			base.transform.up = collision.contacts[0].normal;
			base.transform.position = collision.contacts[0].point + base.transform.up * depthOfStabbing;
		}
		if (collisionRb != null)
		{
			stickJoint = base.gameObject.AddComponent<FixedJoint>();
			stickJoint.connectedBody = collisionRb;
			rigidbodyC.collisionDetectionMode = CollisionDetectionMode.Discrete;
		}
		else
		{
			rigidbodyC.isKinematic = true;
			base.transform.parent = collision.transform;
		}
		canStick = false;
	}

	private IEnumerator StickCooldownRoutine(Vector3 shootDir)
	{
		if (stickJoint != null)
		{
			Object.Destroy(stickJoint);
		}
		if ((bool)collisionRb)
		{
			collisionRb.AddForce(-shootDir * fullShootVelocity * 0.2f, ForceMode.VelocityChange);
			collisionRb.AddTorque(-shootDir * fullShootVelocity, ForceMode.VelocityChange);
		}
		base.transform.parent = null;
		yield return new WaitForSeconds(SecondsBeforeSticking);
		collisionRb = null;
		canStick = true;
	}

	public ForkShooter()
	{
		minShootVelocity = 5f;
		fullShootVelocity = 25f;
		LookInAimDirectionSpeed = float.PositiveInfinity;
		zeroPitchIfNotGrouneded = true;
		depthOfStabbing = 4f;
		SecondsBeforeSticking = 0.5f;
	}
}
