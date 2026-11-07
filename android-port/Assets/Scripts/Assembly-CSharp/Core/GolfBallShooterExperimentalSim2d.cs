using UnityEngine;

namespace Core
{
	public class GolfBallShooterExperimentalSim2d : GolfBallShooterBase
	{
		[SerializeField] public float minShootVelocity = 2f;
		[SerializeField] public float fullShootVelocity = 18f;
		[SerializeField] public float pitch;
		[SerializeField] public AnimationCurve powerToPitchWeightCurve;
		[SerializeField] public float spin;
		[SerializeField] protected bool lookInShotDirection;
		public bool lookInAimDirection;
		[SerializeField] protected bool onlyLookWhenChargingOnController;
		public float LookInAimDirectionSpeed = 10f;
		[SerializeField] protected bool dontLookInAimDirectionWhenBlocked;
		[SerializeField] protected bool useLocalUp;
		[SerializeField] public bool zeroPitchIfNotGrouneded;
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

		public override void OnActivate() => StartAndWakeup();
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow) { }

		public override void OnShoot(Vector3 boost)
		{
			float p = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : pitch;
			StandardShoot(boost, p, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
