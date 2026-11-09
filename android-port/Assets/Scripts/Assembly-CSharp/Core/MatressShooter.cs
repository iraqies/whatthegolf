using CameraStack;
using UnityEngine;

namespace Core
{
	public class MatressShooter : GolfBallShooterBase
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
		public Animator anim;

		[SerializeField]
		public float bendSpeed;

		private string bendParam;

		private float targetBend;

		private float currentBend;

		[SerializeField]
		private float currentSqueeze;

		private string squeezeParam;

		[SerializeField]
		public float squeezeSpeed;

		[SerializeField]
		private float disableSqueezeStartupTime;

		[SerializeField]
		private CBFollow camera;

		[SerializeField]
		private Vector2 cameraFramingAfterFirstShot;

		private float awakeTime;

		private bool isAiming;

		private bool isFirstShot;

		[SerializeField]
		private AnimationCurve squeezeDecay;

		[SerializeField]
		private float squeezeForceNormalizer;

		[SerializeField]
		private float squeezeMinDuration;

		[SerializeField]
		private float squeezeMaxDuration;

		[SerializeField]
		private float oscillationSpeed;

		private float squeezeStrength;

		private float collisionTime;

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

		public override void OnReset()
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

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
