using UnityEngine;

namespace Core
{
	public class CartwheelController : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

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
		private Rigidbody[] arms;

		[SerializeField]
		private Rigidbody[] legs;

		[SerializeField]
		private float limbRotationSpeed;

		[SerializeField]
		private Collider cartwheelCollider;

		[SerializeField]
		private float minCartwheelSpeed;

		[SerializeField]
		private Transform[] armTargets;

		[SerializeField]
		private float liftArmsForce;

		private bool hasShotOnce;

		private bool isAiming;

		private Vector3 lastBoost;

		protected override void Awake()
		{
		base.Awake();
	}

		public override void OnActivate()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnCancel()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, pitch, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), spin);
	}

		private void Update()
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}
	}
}
