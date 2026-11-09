using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class SwimmerShooter : GolfBallShooterBase
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
		private Transform body;

		private Quaternion startBodyRotation;

		private Vector3 startBodyLocalPosition;

		[SerializeField]
		private float moveMaxTilt;

		[SerializeField]
		private float moveTiltSpeed;

		[SerializeField]
		private float maxTiltAngle;

		[SerializeField]
		private float speedToTiltNormalizer;

		private Transform t;

		[SerializeField]
		private AnimationCurve speedToStaticBuoyancyCurve;

		[SerializeField]
		private float staticBuoyancyBounceAmplitude;

		[SerializeField]
		private float staticBuoyancyBounceFrequency;

		[SerializeField]
		private List<AudioClip> splashSfx;

		[SerializeField]
		private float minDelayBetweenSplashes;

		[SerializeField]
		private float maxDelayBetweenSplashes;

		[SerializeField]
		private float speedToSplashDelayNormalizer;

		[SerializeField]
		private AudioSource audioPlayer;

		[SerializeField]
		private float minSplashingSpeed;

		private float lastSplashSfxTime;

		[SerializeField]
		private float minSplashVolume;

		[SerializeField]
		private float maxSplashVolume;

		[SerializeField]
		private float speedToSplashVolumeNormalizer;

		[SerializeField]
		private float minSplashPitch;

		[SerializeField]
		private float maxSplashVPitch;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private float animationMaxSpeed;

		private string animParameterName;

		private bool isPlayingCoolAnimation;

		private bool hasShotAtLeastOnce;

		private int lastAnimIndex;

		private int[] animSequence;

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
		base.OnShoot(boost);
		StandardShoot(boost, pitch, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), spin);
	}

		public new void FixedUpdate()
		{
		}

		private void Update()
		{
		}
	}
}
