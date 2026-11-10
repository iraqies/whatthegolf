using System.Collections.Generic;
using Buoyancy;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class HighDiverShooter2 : GolfBallShooterBase
	{
		[SerializeField]
		private MinMax velocityLimits = new MinMax(10f, 30f);

		[SerializeField]
		private float pitchOnGround = 20f;

		[SerializeField]
		private float pitchInWater = 20f;

		[SerializeField]
		private Vector3 pitchVector = Vector3.left;

		[SerializeField]
		private MinMax angularVelocityLimits = new MinMax(10f, 30f);

		[SerializeField]
		private float waterMovementMultiplier = 0.5f;

		[SerializeField]
		private float waterAngularMultiplier = 0.5f;

		[SerializeField]
		private BuoyancyTarget buoyancyTarget;

		[SerializeField]
		private SphereCastGroundCheck groundCheck;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private UnityEvent OnDive;

		[SerializeField]
		private UnityEvent OnPostDiveShot;

		private List<Rigidbody> rigidbodies;

		private Rigidbody head;

		private bool hasDived;

		public float lookDirectionForce = 20f;

		protected override void Awake()
		{
			base.Awake();
			rigidbodies = new List<Rigidbody>();
			GetComponentsInChildren(rigidbodies);
			if (animator != null)
			{
				Transform headBone = animator.GetBoneTransform(HumanBodyBones.Head);
				if (headBone != null)
					head = headBone.GetComponent<Rigidbody>();
				animator.keepAnimatorControllerStateOnDisable = true;
			}
			if (rigidbodies != null)
			{
				foreach (Rigidbody rb in rigidbodies)
				{
					if (rb != null)
					{
						rb.isKinematic = true;
						rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
						rb.maxAngularVelocity = 500f;
					}
				}
			}
			if (GolfBallController != null)
			{
				GolfBallController.AddBlockingFunction(IsShotBlocked);
			}
		}

		private bool IsShotBlocked()
		{
			if (!hasDived)
				return false;
			if (buoyancyTarget != null && buoyancyTarget.IsInWater)
				return !buoyancyTarget.IsFloatingOnSurface;
			if (groundCheck != null)
				return !groundCheck.IsGrounded();
			return false;
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (GolfBallController != null && GolfBallController.isAiming && buoyancyTarget != null && buoyancyTarget.IsInWater && rigid != null && head != null)
			{
				Vector3 pos = rigid.position;
				Vector3 aimDir = GolfBallController.GetAimInputDirection;
				head.AddForceAtPosition(aimDir * lookDirectionForce, pos + aimDir * 2.5f, ForceMode.Acceleration);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (!hasDived)
			{
				Collapse();
				hasDived = true;
				OnDive?.Invoke();
			}
			else
			{
				OnPostDiveShot?.Invoke();
			}
			Shoot(boost);
		}

		private void Shoot(Vector3 boost)
		{
			if (buoyancyTarget == null || velocityLimits == null || angularVelocityLimits == null || rigid == null)
				return;

			bool inWater = buoyancyTarget.IsInWater;
			Vector3 pitched = inWater ? PitchBoost(boost, pitchInWater) : PitchBoost(boost, pitchOnGround);
			float velMult = inWater ? waterMovementMultiplier : 1f;
			float angMult = inWater ? waterAngularMultiplier : 1f;

			if (rigidbodies != null)
			{
				foreach (Rigidbody rb in rigidbodies)
				{
					if (rb != rigid && rb != null)
					{
						rb.velocity = Vector3.zero;
						rb.angularVelocity = Vector3.zero;
					}
				}
			}

			Vector3 norm = pitched.normalized;
			float t = Mathf.Clamp01(pitched.magnitude);
			Vector3 force = Vector3.Lerp(norm * velocityLimits.min * velMult, norm * velocityLimits.max * velMult, t);
			rigid.AddForce(force, ForceMode.VelocityChange);

			Vector3 axis = Vector3.Cross(boost, Vector3.up).normalized;
			float angT = Mathf.Clamp01(boost.magnitude);
			Vector3 torque = Vector3.Lerp(-axis * angularVelocityLimits.min * angMult, -axis * angularVelocityLimits.max * angMult, angT);
			rigid.AddTorque(torque, ForceMode.Impulse);
		}

		private void Collapse()
		{
			if (animator != null)
			{
				animator.SetBool("HoldingJump", false);
				animator.enabled = false;
			}
			if (rigidbodies != null)
			{
				foreach (Rigidbody rb in rigidbodies)
				{
					if (rb != null)
					{
						rb.isKinematic = false;
						rb.velocity = Vector3.zero;
						rb.angularVelocity = Vector3.zero;
					}
				}
			}
		}

		public override void OnAimStart()
		{
			base.OnAimStart();
			if (animator != null && animator.enabled)
			{
				animator.SetBool("HoldingJump", true);
			}
		}

		public override void OnCancel()
		{
			base.OnCancel();
			if (animator != null && animator.enabled)
			{
				animator.SetBool("HoldingJump", false);
			}
		}

		public override void OnReset()
		{
			base.OnReset();
			hasDived = false;
			if (animator != null)
			{
				animator.SetBool("HoldingJump", false);
				animator.enabled = true;
			}
			if (rigidbodies != null)
			{
				foreach (Rigidbody rb in rigidbodies)
				{
					if (rb != null)
					{
						rb.velocity = Vector3.zero;
						rb.angularVelocity = Vector3.zero;
						rb.isKinematic = true;
					}
				}
			}
		}

		private Vector3 PitchBoost(Vector3 boost, float pitch)
		{
			Vector3 axis = Vector3.Cross(boost, pitchVector);
			float mult = (buoyancyTarget != null && buoyancyTarget.IsInWater) ? waterMovementMultiplier : 1f;
			return Quaternion.AngleAxis(mult * pitch * boost.magnitude, axis) * boost;
		}
	}
}
