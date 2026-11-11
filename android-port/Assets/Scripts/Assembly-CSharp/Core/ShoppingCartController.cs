using UnityEngine;

namespace Core
{
	public class ShoppingCartController : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

		[SerializeField]
		public float spin;

		[SerializeField]
		protected bool lookInShotDirection;

		public bool lookInAimDirection;

		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		public float LookInAimDirectionSpeed = 360f;

		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		[SerializeField]
		private float minWheelsVelocity = 1f;

		[SerializeField]
		private float maxWheelsVelocity = 10f;

		[SerializeField]
		private PhysicMaterial noFrictionMaterial;

		[SerializeField]
		private Collider wheelCollider;

		[SerializeField]
		private Transform[] wheelTransforms;

		[SerializeField]
		private float wheelRotationSpeed = 10f;

		[SerializeField]
		private AnimationCurve wheelSpinDownAnim;

		private float lastOnWheelsTime;

		private Transform t;

		protected override void Awake()
		{
			base.Awake();
			t = transform;
		}

		public override void OnActivate()
		{
			enabled = true;
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (onlyAimArrow && onlyLookWhenChargingOnController)
			{
				return;
			}
			if (dontLookInAimDirectionWhenBlocked && GolfBallController != null && GolfBallController.BlockShooting)
			{
				return;
			}
			if (lookInAimDirection && boost.sqrMagnitude > 0.001f && rigidbodyC != null)
			{
				Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
				Quaternion targetRot = Quaternion.LookRotation(boost, upVec);
				if (LookInAimDirectionSpeed <= 0f)
				{
					rigidbodyC.MoveRotation(targetRot);
				}
				else
				{
					rigidbodyC.MoveRotation(Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, LookInAimDirectionSpeed * Time.deltaTime));
				}
			}
			if (IsOnWheels() && rigidbodyC != null && boost.sqrMagnitude > 0.001f)
			{
				float forceMag = Mathf.Lerp(minWheelsVelocity, maxWheelsVelocity, boost.sqrMagnitude);
				rigidbodyC.AddForce(boost.normalized * forceMag, ForceMode.Acceleration);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			if (lookInShotDirection && boost.sqrMagnitude > 0.001f && rigidbodyC != null)
			{
				Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upVec));
			}
			float weight = powerToPitchWeightCurve != null && powerToPitchWeightCurve.length > 0 ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f;
			Vector3 planeNorm = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			Vector3 rightAxis = Vector3.Cross(planeNorm, boost);
			float actualPitch = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : (pitch * weight);
			Vector3 pitchedBoost = Quaternion.AngleAxis(actualPitch, rightAxis) * boost;
			StandardShoot(pitchedBoost, actualPitch, minShootVelocity, fullShootVelocity, spin);
		}

		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidbodyC == null)
			{
				return;
			}
			Vector3 planeNorm = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			Vector3 rightAxis = Vector3.Cross(planeNorm, boost);
			float mag = Mathf.Clamp01(boost.magnitude);
			Vector3 dir = boost.normalized;
			Vector3 vel = Vector3.Lerp(dir * minShootVelocity, dir * fullShootVelocity, mag);
			rigidbodyC.AddForce(vel, ForceMode.VelocityChange);
			rigidbodyC.AddTorque(rightAxis * (spin * mag), ForceMode.VelocityChange);
		}

		private bool IsOnWheels()
		{
			return Vector3.Dot(transform.up, Vector3.up) > 0.7f && (GolfBallController == null || GolfBallController.IsGrounded);
		}

		private new void FixedUpdate()
		{
			if (IsOnWheels() && wheelCollider != null && noFrictionMaterial != null && wheelCollider.sharedMaterial != noFrictionMaterial)
			{
				wheelCollider.sharedMaterial = noFrictionMaterial;
			}
			if (t != null && rigidbodyC != null && wheelTransforms != null && wheelTransforms.Length > 0)
			{
				Vector3 flatVel = Vector3.ProjectOnPlane(rigidbodyC.velocity, t.up);
				if (flatVel.sqrMagnitude > 0.05f)
				{
					Vector3 dir = flatVel.normalized;
					for (int i = 0; i < wheelTransforms.Length; i++)
					{
						Transform wt = wheelTransforms[i];
						if (wt != null)
						{
							Vector3 nextFwd = Vector3.RotateTowards(wt.forward, dir, wheelRotationSpeed * Time.fixedDeltaTime, 0f);
							if (nextFwd.sqrMagnitude > 0.001f)
							{
								wt.LookAt(wt.position + nextFwd, t.up);
							}
						}
					}
				}
			}
		}
	}
}
