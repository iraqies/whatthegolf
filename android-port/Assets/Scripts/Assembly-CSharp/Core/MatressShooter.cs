using CameraStack;
using UnityEngine;

namespace Core
{
	public class MatressShooter : GolfBallShooterBase
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
		public Animator anim;

		[SerializeField]
		public float bendSpeed = 1f;

		private string bendParam = "Bend";

		private float targetBend;

		private float currentBend;

		[SerializeField]
		private float currentSqueeze;

		private string squeezeParam = "Squeeze";

		[SerializeField]
		public float squeezeSpeed = 1f;

		[SerializeField]
		private float disableSqueezeStartupTime = 0.5f;

		[SerializeField]
		private CBFollow camera;

		[SerializeField]
		private Vector2 cameraFramingAfterFirstShot = new Vector2(0.5f, 0.5f);

		private float awakeTime;

		private bool isAiming;

		private bool isFirstShot = true;

		[SerializeField]
		private AnimationCurve squeezeDecay;

		[SerializeField]
		private float squeezeForceNormalizer = 10f;

		[SerializeField]
		private float squeezeMinDuration = 0.5f;

		[SerializeField]
		private float squeezeMaxDuration = 3f;

		[SerializeField]
		private float oscillationSpeed = 3f;

		private float squeezeStrength;

		private float collisionTime = float.NegativeInfinity;

		protected override void Awake()
		{
			base.Awake();
			awakeTime = Time.time;
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
			if (lookInAimDirection)
			{
				if (onlyAimArrow && onlyLookWhenChargingOnController)
					return;
				if (!dontLookInAimDirectionWhenBlocked || !IsShootingBlocked())
				{
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
			}

			if (!onlyAimArrow && !isFirstShot)
			{
				float mag = boost.magnitude;
				float sign = Mathf.Sign(mag - currentSqueeze);
				float nextSqueeze = currentSqueeze + sign * bendSpeed * Time.deltaTime;
				if (sign > 0f)
				{
					currentSqueeze = Mathf.Clamp(nextSqueeze, currentSqueeze, mag);
				}
				else
				{
					currentSqueeze = Mathf.Clamp(nextSqueeze, mag, currentSqueeze);
				}
				if (anim != null)
				{
					anim.SetFloat(squeezeParam, currentSqueeze);
				}
				isAiming = true;
			}
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
		}

		public override void OnReset()
		{
			base.OnReset();
			isAiming = false;
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
			Vector3 planeNormal = (GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.planeType).normal : Vector3.up;
			float weightedPitch = pitch * weight;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
			{
				boost = Quaternion.AngleAxis(weightedPitch, axis) * boost;
			}

			StandardShoot(boost, weightedPitch, minShootVelocity, fullShootVelocity, spin);
			targetBend = 0f;
			isAiming = false;
			if (GolfBallController != null)
			{
				GolfBallController.ArrowPosition = base.transform;
			}
			if (camera != null)
			{
				camera.screenRelativePivot = cameraFramingAfterFirstShot;
			}
			isFirstShot = false;
		}

		private void Update()
		{
			if (isAiming)
				return;

			float duration = Mathf.Lerp(squeezeMinDuration, squeezeMaxDuration, squeezeStrength);
			float normTime = ( duration > 0f ) ? Mathf.Clamp((Time.time - collisionTime) / duration, 0f, 1f) : 1f;
			float decay = squeezeDecay != null ? squeezeDecay.Evaluate(normTime) : 0f;
			float targetSqueeze = decay * Mathf.Sin(normTime * oscillationSpeed);
			currentSqueeze = Mathf.Clamp(Mathf.Lerp(currentSqueeze, targetSqueeze, Time.deltaTime * squeezeSpeed), 0f, 1f);
			if (anim != null)
			{
				anim.SetFloat(squeezeParam, currentSqueeze);
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (Time.time - awakeTime < disableSqueezeStartupTime || collision == null)
				return;

			float strength = Mathf.Clamp(collision.relativeVelocity.magnitude / squeezeForceNormalizer, 0f, 1f);
			float duration = Mathf.Lerp(squeezeMinDuration, squeezeMaxDuration, squeezeStrength);
			if (squeezeStrength < strength || Time.time - collisionTime > duration)
			{
				squeezeStrength = strength;
				collisionTime = Time.time;
			}
		}
	}
}
