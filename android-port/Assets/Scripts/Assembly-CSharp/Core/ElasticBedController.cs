using RootMotion.Dynamics;
using UnityEngine;

namespace Core
{
	public class ElasticBedController : GolfBallShooterBase
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
		public PuppetMaster puppet;

		[SerializeField]
		public Animator puppetAnimator;

		[SerializeField]
		public float poseUpwardsVelocityThreshold;

		[SerializeField]
		public float poseHoldTime;

		[SerializeField]
		public float pinWeightChangeSpeed;

		[SerializeField]
		public float pinWeightMax;

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

		private float stillThreshold;

		protected override void Awake()
		{
		base.Awake();
	}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private new void FixedUpdate()
		{
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

		private bool IsGrounded()
		{
			return false;
		}

		protected override bool IsBlocking()
		{
			return false;
		}

		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}
	}
}
