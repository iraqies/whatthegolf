using UnityEngine;

namespace Core
{
	public class GolfBallShooterExperimentalSim2d : GolfBallShooterBase
	{
		[SerializeField] public float minShootVelocity = 5f;
		[SerializeField] public float fullShootVelocity = 25f;
		[SerializeField] public float pitch;
		[SerializeField] public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);
		[SerializeField] public float spin;
		[SerializeField] protected bool lookInShotDirection;
		public bool lookInAimDirection;
		[SerializeField] protected bool onlyLookWhenChargingOnController;
		public float LookInAimDirectionSpeed = float.PositiveInfinity;
		[SerializeField] protected bool dontLookInAimDirectionWhenBlocked;
		[SerializeField] protected bool useLocalUp;
		[SerializeField] public bool zeroPitchIfNotGrouneded = true;
		public float allowedZVariance = 0.05f;
		public float zCorrectionSpeedMultiplier = 10f;
		public float minimumZCorrectionSpeed = 1f;
		private float originZ;

		protected override void Awake()
		{
			base.Awake();
			originZ = transform.position.z;
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (rigidbodyC != null && Mathf.Abs(transform.position.z - originZ) > allowedZVariance)
			{
				Vector3 p = transform.position;
				p.z = Mathf.MoveTowards(p.z, originZ, Time.fixedDeltaTime * Mathf.Max(minimumZCorrectionSpeed, zCorrectionSpeedMultiplier));
				transform.position = p;
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (!lookInAimDirection) return;
			if (onlyAimArrow && onlyLookWhenChargingOnController) return;
			if (dontLookInAimDirectionWhenBlocked && IsBlocking()) return;
			if (boost.sqrMagnitude <= 1e-6f || rigidbodyC == null) return;

			Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
			Quaternion targetRot = Quaternion.LookRotation(boost, upVec);
			if (!float.IsInfinity(LookInAimDirectionSpeed))
			{
				targetRot = Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, LookInAimDirectionSpeed * Time.deltaTime);
			}
			rigidbodyC.MoveRotation(targetRot);
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
			if (lookInShotDirection && rigidbodyC != null && boost.sqrMagnitude > 1e-6f)
			{
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upVec));
			}

			float weight = powerToPitchWeightCurve != null ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f;
			Vector3 planeNormal = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.forward;
			float weightedPitch = pitch * weight;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
			{
				if (axis.sqrMagnitude > 1e-6f)
				{
					boost = Quaternion.AngleAxis(weightedPitch, axis) * boost;
				}
			}

			StandardShoot(boost, weightedPitch, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
