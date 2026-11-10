using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class SwimmerShooter : GolfBallShooterBase
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
		private Transform body;

		private Quaternion startBodyRotation;

		private Vector3 startBodyLocalPosition;

		[Range(0f, 1f)]
		[SerializeField]
		private float moveMaxTilt = 0.5f;

		[SerializeField]
		private float moveTiltSpeed = 300f;

		[SerializeField]
		private float maxTiltAngle = 45f;

		[SerializeField]
		private float speedToTiltNormalizer = 15f;

		private Transform t;

		[SerializeField]
		private AnimationCurve speedToStaticBuoyancyCurve;

		[SerializeField]
		private float staticBuoyancyBounceAmplitude = 0.3f;

		[SerializeField]
		private float staticBuoyancyBounceFrequency = 1f;

		[SerializeField]
		private List<AudioClip> splashSfx;

		[SerializeField]
		private float minDelayBetweenSplashes = 0.4f;

		[SerializeField]
		private float maxDelayBetweenSplashes = 1f;

		[SerializeField]
		private float speedToSplashDelayNormalizer = 15f;

		[SerializeField]
		private AudioSource audioPlayer;

		[SerializeField]
		private float minSplashingSpeed;

		private float lastSplashSfxTime;

		[SerializeField]
		private float minSplashVolume = 0.4f;

		[SerializeField]
		private float maxSplashVolume = 1f;

		[SerializeField]
		private float speedToSplashVolumeNormalizer = 15f;

		[SerializeField]
		private float minSplashPitch = 0.7f;

		[SerializeField]
		private float maxSplashVPitch = 1f;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private float animationMaxSpeed = 0.5f;

		private string animParameterName = "IdleState";

		private bool isPlayingCoolAnimation;

		private bool hasShotAtLeastOnce;

		private int lastAnimIndex = -1;

		private int[] animSequence = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

		protected override void Awake()
		{
			base.Awake();
			t = GetComponent<Transform>();
			if (body != null)
			{
				startBodyRotation = body.rotation;
				startBodyLocalPosition = body.localPosition;
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigid != null)
			{
				rigid.isKinematic = false;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (!lookInAimDirection)
				return;
			if (onlyAimArrow && onlyLookWhenChargingOnController)
				return;
			if (dontLookInAimDirectionWhenBlocked && IsShootingBlocked())
				return;

			Vector3 upVec = useLocalUp ? base.transform.up : Vector3.up;
			if (rigid != null && boost != Vector3.zero)
			{
				Quaternion targetRot = Quaternion.LookRotation(boost, upVec);
				if (!float.IsPositiveInfinity(LookInAimDirectionSpeed))
				{
					targetRot = Quaternion.RotateTowards(rigid.rotation, targetRot, LookInAimDirectionSpeed * Time.deltaTime);
				}
				rigid.MoveRotation(targetRot);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			Vector3 upVec = useLocalUp ? base.transform.up : Vector3.up;
			if (lookInShotDirection && rigid != null && boost != Vector3.zero)
			{
				rigid.MoveRotation(Quaternion.LookRotation(boost, upVec));
			}

			float weight = powerToPitchWeightCurve != null ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f;
			Vector3 planeNormal = (GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			float weightedPitch = pitch * weight;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
			{
				boost = Quaternion.AngleAxis(weightedPitch, axis) * boost;
			}

			StandardShoot(boost, weightedPitch, minShootVelocity, fullShootVelocity, spin);
			isPlayingCoolAnimation = false;
			if (anim != null)
			{
				anim.SetInteger(animParameterName, 0);
			}
			hasShotAtLeastOnce = true;
		}

		protected override void FixedUpdate()
		{
			if (rigid == null || body == null)
				return;

			float speed = rigid.velocity.magnitude;
			Vector3 normVel = rigid.velocity.normalized;
			Quaternion prevRot = body.rotation;
			body.rotation = startBodyRotation;

			Vector3 tiltAxis = Vector3.Cross(normVel, Vector3.up);
			if (t != null)
			{
				Debug.DrawRay(t.position, tiltAxis, Color.green);
			}
			float tiltAngle = Mathf.Lerp(0f, maxTiltAngle, (speedToTiltNormalizer > 0f) ? (speed / speedToTiltNormalizer) : 0f);
			body.Rotate(tiltAxis, tiltAngle);

			Quaternion targetRot = (speed > 0.1f) ? body.rotation : startBodyRotation;
			body.rotation = Quaternion.Lerp(prevRot, targetRot, Time.deltaTime * moveTiltSpeed);

			Vector3 localPos = body.localPosition;
			float bounceMult = speedToStaticBuoyancyCurve != null ? speedToStaticBuoyancyCurve.Evaluate(speed) : 1f;
			localPos.y = startBodyLocalPosition.y + bounceMult * staticBuoyancyBounceAmplitude * Mathf.Sin(Time.time * staticBuoyancyBounceFrequency);
			body.localPosition = localPos;

			if (hasShotAtLeastOnce && !isPlayingCoolAnimation && speed < animationMaxSpeed && animSequence != null && animSequence.Length > 0 && anim != null)
			{
				lastAnimIndex = (lastAnimIndex + 1) % animSequence.Length;
				anim.SetInteger(animParameterName, animSequence[lastAnimIndex]);
				isPlayingCoolAnimation = true;
			}
		}

		private void Update()
		{
			if (rigid == null)
				return;

			float now = Time.time;
			float speed = rigid.velocity.magnitude;
			float delay = Mathf.Lerp(maxDelayBetweenSplashes, minDelayBetweenSplashes, (speedToSplashDelayNormalizer > 0f) ? (speed / speedToSplashDelayNormalizer) : 0f);
			if (speed > minSplashingSpeed && (now - lastSplashSfxTime) > delay && splashSfx != null && splashSfx.Count > 0 && audioPlayer != null)
			{
				int idx = Random.Range(0, splashSfx.Count);
				audioPlayer.clip = splashSfx[idx];
				audioPlayer.volume = Mathf.Lerp(minSplashVolume, maxSplashVolume, (speedToSplashVolumeNormalizer > 0f) ? (speed / speedToSplashVolumeNormalizer) : 0f);
				audioPlayer.pitch = Random.Range(minSplashPitch, maxSplashVPitch);
				audioPlayer.Play();
				lastSplashSfxTime = Time.time;
			}
		}
	}
}
