using UnityEngine;

namespace Core
{
	public class ShoppingCartController : GolfBallShooterBase
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
		private float minWheelsVelocity;

		[SerializeField]
		private float maxWheelsVelocity;

		[SerializeField]
		private PhysicMaterial noFrictionMaterial;

		[SerializeField]
		private Collider wheelCollider;

		[SerializeField]
		private Transform[] wheelTransforms;

		[SerializeField]
		private float wheelRotationSpeed;

		[SerializeField]
		private AnimationCurve wheelSpinDownAnim;

		private float lastOnWheelsTime;

		private Transform t;

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

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}

		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		private bool IsOnWheels()
		{
			return false;
		}

		private new void FixedUpdate()
		{
		}
	}
}
