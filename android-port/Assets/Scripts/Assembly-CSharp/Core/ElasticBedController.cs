using RootMotion.Dynamics;
using UnityEngine;

namespace Core
{
	public class ElasticBedController : GolfBallShooterBase
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
		public PuppetMaster puppet;

		[SerializeField]
		public Animator puppetAnimator;

		[SerializeField]
		public float poseUpwardsVelocityThreshold = 1f;

		[SerializeField]
		public float poseHoldTime = 0.5f;

		[SerializeField]
		public float pinWeightChangeSpeed = 5f;

		[SerializeField]
		public float pinWeightMax = 1f;

		[SerializeField]
		public float JumpFromMattressExtraForce;

		private Vector3 lastVel;

		private float poseTimer;

		private const int POSES = 5;

		private float pinWeightTarget;

		public float distToGroundExtraLength;

		public LayerMask groundLayer;

		private float distToGround;

		private float curStillTime;

		private float stillThreshold = 0.09f;

		protected override void Awake()
		{
			base.Awake();
		}

		private void Start()
		{
			if (GolfBallController != null)
			{
				GolfBallController.AddBlockingFunction(IsBlocking);
			}
		}

		private void Update()
		{
			if (poseTimer > 0f)
			{
				poseTimer -= Time.deltaTime;
				if (poseTimer <= 0f)
				{
					pinWeightTarget = 0f;
				}
			}
			if (puppet != null)
			{
				puppet.pinWeight = Mathf.MoveTowards(puppet.pinWeight, Mathf.Min(pinWeightTarget, pinWeightMax), Time.deltaTime * pinWeightChangeSpeed);
			}
			if (rigidbodyC != null)
			{
				lastVel = rigidbodyC.velocity;
			}
		}

		private new void FixedUpdate()
		{
			if (IsGrounded() && rigidbodyC != null && rigidbodyC.velocity.y > 0f)
			{
				rigidbodyC.AddForce(Vector3.up * JumpFromMattressExtraForce, ForceMode.Acceleration);
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (!lookInAimDirection || (onlyAimArrow && onlyLookWhenChargingOnController) || (dontLookInAimDirectionWhenBlocked && IsBlocking()))
			{
				return;
			}
			Vector3 upwards = (useLocalUp ? base.transform.up : Vector3.up);
			if (rigidbodyC != null)
			{
				Quaternion rotation = ((!float.IsPositiveInfinity(LookInAimDirectionSpeed)) ? Quaternion.RotateTowards(rigidbodyC.rotation, Quaternion.LookRotation(boost, upwards), LookInAimDirectionSpeed * Time.deltaTime) : Quaternion.LookRotation(boost, upwards));
				rigidbodyC.MoveRotation(rotation);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (boost.y > poseUpwardsVelocityThreshold)
			{
				pinWeightTarget = 1f;
				if (puppetAnimator != null)
				{
					int integer = puppetAnimator.GetInteger("Pose");
					int value = Random.Range(integer + 1, integer + 5) % 5;
					puppetAnimator.SetInteger("Pose", value);
					puppetAnimator.SetTrigger("EnterPose");
				}
				poseTimer = poseHoldTime;
			}
			Vector3 upwards = (useLocalUp ? base.transform.up : Vector3.up);
			if (lookInShotDirection && rigidbodyC != null)
			{
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upwards));
			}
			float num = ((powerToPitchWeightCurve != null) ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f);
			Vector3 rhs = ((GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up);
			float num2 = pitch * num;
			Vector3 axis = Vector3.Cross(boost, rhs);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || IsGrounded())
			{
				boost = Quaternion.AngleAxis(num2, axis) * boost;
			}
			StandardShoot(boost, num2, minShootVelocity, fullShootVelocity, spin);
		}

		private bool IsGrounded()
		{
			Ray ray = new Ray(base.transform.position, Vector3.down);
			float maxDistance = distToGround + 0.5f + distToGroundExtraLength;
			bool flag = Physics.Raycast(ray, out var hitInfo, maxDistance, groundLayer.value);
			bool flag2 = flag && Vector3.Dot(hitInfo.normal, Vector3.up) > 0.95f;
			if (flag)
			{
				Debug.DrawLine(hitInfo.point, hitInfo.point + hitInfo.normal, Color.blue);
			}
			Debug.DrawRay(ray.origin, ray.direction * maxDistance, flag2 ? Color.green : Color.red);
			return flag2;
		}

		protected override bool IsBlocking()
		{
			if (rigidbodyC == null)
			{
				return false;
			}
			float sqrMagnitude = rigidbodyC.velocity.sqrMagnitude;
			float num = 0f;
			if (sqrMagnitude < sqrVelocityShootingThreshold)
			{
				num = curStillTime + Time.unscaledDeltaTime;
			}
			curStillTime = num;
			if (num >= stillThreshold)
			{
				lastUnderVelocityShootingThreshold = Time.time;
			}
			bool flag = Time.time >= lastUnderVelocityShootingThreshold + shootThresholdMinimumTime && curStillTime < stillThreshold;
			if (isblockedIfNotGrounded)
			{
				flag |= !IsGrounded();
			}
			return flag;
		}

		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (GolfBallController != null)
			{
				_ = GolfBallController.GetPlane(GolfBallController.AimPlane).normal;
			}
			Vector3 normalized = boost.normalized;
			float magnitude = boost.magnitude;
			if (rigidbodyC != null)
			{
				Vector3 vector = normalized * minShootVelocity;
				Vector3 vector2 = normalized * fullShootVelocity;
				rigidbodyC.AddForce(vector + (vector2 - vector) * magnitude, ForceMode.Impulse);
			}
		}
	}
}
