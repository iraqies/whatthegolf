using UnityEngine;

namespace Core
{
	public class CartwheelController : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);

		[SerializeField]
		public float spin;

		[SerializeField]
		protected bool lookInShotDirection;

		public bool lookInAimDirection;

		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		public float LookInAimDirectionSpeed = float.PositiveInfinity;

		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		[SerializeField]
		private Rigidbody[] arms;

		[SerializeField]
		private Rigidbody[] legs;

		[SerializeField]
		private float limbRotationSpeed = 360f;

		[SerializeField]
		private Collider cartwheelCollider;

		[SerializeField]
		private float minCartwheelSpeed = 2f;

		[SerializeField]
		private Transform[] armTargets;

		[SerializeField]
		private float liftArmsForce = 10f;

		private bool hasShotOnce;

		private bool isAiming;

		private Vector3 lastBoost;

		protected override void Awake()
		{
			base.Awake();
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = true;
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (onlyAimArrow || (GolfBallController != null && GolfBallController.BlockShooting))
			{
				return;
			}
			isAiming = true;
			lastBoost = boost;
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
			}
			if (cartwheelCollider != null)
			{
				cartwheelCollider.enabled = true;
			}
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
			if (arms == null)
			{
				return;
			}
			for (int i = 0; i < arms.Length; i++)
			{
				if (arms[i] != null)
				{
					arms[i].useGravity = true;
				}
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			Vector3 upwards = (useLocalUp ? base.transform.up : Vector3.up);
			if (lookInShotDirection && rigidbodyC != null && boost.sqrMagnitude > 0.0001f)
			{
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upwards));
			}
			if (arms != null)
			{
				for (int i = 0; i < arms.Length; i++)
				{
					if (arms[i] != null)
					{
						arms[i].useGravity = true;
					}
				}
			}
			float num = ((powerToPitchWeightCurve != null) ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f);
			Vector3 normal = ((GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up);
			float num2 = pitch * num;
			Vector3 axis = Vector3.Cross(boost, normal);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
			{
				boost = Quaternion.AngleAxis(num2, axis) * boost;
			}
			StandardShoot(boost, num2, minShootVelocity, fullShootVelocity, spin);
			hasShotOnce = true;
			isAiming = false;
		}

		private void Update()
		{
			if (!isAiming && hasShotOnce && rigidbodyC != null && rigidbodyC.velocity.magnitude < minCartwheelSpeed && cartwheelCollider != null)
			{
				cartwheelCollider.enabled = false;
			}
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (!isAiming)
			{
				return;
			}
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
				Vector3 vector = (useLocalUp ? base.transform.up : Vector3.up);
				Vector3 vector2 = Vector3.ProjectOnPlane(lastBoost, vector);
				if (vector2.sqrMagnitude > 0.0001f)
				{
					Quaternion quaternion = Quaternion.LookRotation(vector2, vector);
					if (!float.IsInfinity(LookInAimDirectionSpeed))
					{
						quaternion = Quaternion.RotateTowards(rigidbodyC.rotation, quaternion, LookInAimDirectionSpeed * Time.deltaTime);
					}
					rigidbodyC.MoveRotation(quaternion);
				}
			}
			isAiming = true;
			if (arms == null || armTargets == null)
			{
				return;
			}
			for (int i = 0; i < arms.Length && i < armTargets.Length; i++)
			{
				if (arms[i] != null && armTargets[i] != null)
				{
					Vector3 forward = armTargets[i].position - arms[i].position;
					if (forward.sqrMagnitude > 0.0001f)
					{
						Quaternion to = Quaternion.LookRotation(forward);
						arms[i].useGravity = false;
						Quaternion rot = Quaternion.RotateTowards(arms[i].transform.rotation, to, Time.deltaTime * limbRotationSpeed);
						arms[i].MoveRotation(rot);
					}
				}
			}
		}
	}
}
