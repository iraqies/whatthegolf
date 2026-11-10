using System.Collections;
using Buoyancy;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class SwimmerGolferShooter : GolfBallShooterBase
	{
		[SerializeField]
		private bool extraForceOnFirstSkip;

		[SerializeField]
		private bool onlyAfterFirstShot;

		[SerializeField]
		private float firstSkipExtraYVelocity = 100f;

		[SerializeField]
		private float firstSkipExtraXZVelocity = 100f;

		[SerializeField]
		private bool customForceOnFirstShot;

		[SerializeField]
		private float firstShotVelocity = 800f;

		[SerializeField]
		private float firstShotPitch = 9f;

		[SerializeField]
		private float minVelocity = 20f;

		[SerializeField]
		private float fullVelocity = 40f;

		[SerializeField]
		private float fullPitch = 30f;

		[SerializeField]
		private float swimmingPitchMultiplier = 1.5f;

		[SerializeField]
		private float swimmingVelocityMultiplier = 1f;

		[SerializeField]
		private float fullSpin = 30f;

		[SerializeField]
		private float turnSpeed = 30f;

		[SerializeField]
		private Rigidbody GolfClub;

		[SerializeField]
		private Animator golfAnimator;

		[SerializeField]
		private BuoyancyTarget buoyancyTarget;

		[SerializeField]
		private UnityEvent OnCollapse;

		[SerializeField]
		private bool CollapseAtStart;

		[SerializeField]
		private Transform ClubRoot;

		[SerializeField]
		private bool playShootRoutine = true;

		[SerializeField]
		private bool doFullReset;

		private Rigidbody[] rigidbodies;

		private Rigidbody hips;

		private Rigidbody head;

		private Rigidbody leftFoot;

		private Rigidbody rightFoot;

		private GolfBallController controller;

		private Vector3 lastBoost;

		private bool hasCollapsed;

		private bool isCollapsing;

		private Vector3 oldPosition;

		private Quaternion oldRotation;

		public CBFollow followCamera;

		private Vector3 targetBlend;

		private float velRef;

		private int skipCountAfterShot;

		private int shotCount;

		private Vector3 baseClubLocalPosition;

		private Quaternion baseClubLocalRotation;

		private Transform baseClubParent;

		private Transform baseArrowFollow;

		public float lookDirectionForce = 20f;

		public float feetForceMultiplier = 0.2f;

		protected override void Awake()
		{
			base.Awake();
			controller = GolfBallController;
			rigidbodies = GetComponentsInChildren<Rigidbody>();
			if (golfAnimator != null)
			{
				Transform hipsBone = golfAnimator.GetBoneTransform(HumanBodyBones.Hips);
				if (hipsBone != null)
					hips = hipsBone.GetComponent<Rigidbody>();
				Transform headBone = golfAnimator.GetBoneTransform(HumanBodyBones.Head);
				if (headBone != null)
					head = headBone.GetComponent<Rigidbody>();
				Transform rightFootBone = golfAnimator.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				if (rightFootBone != null)
					rightFoot = rightFootBone.GetComponent<Rigidbody>();
				Transform leftFootBone = golfAnimator.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				if (leftFootBone != null)
					leftFoot = leftFootBone.GetComponent<Rigidbody>();
			}
			golfAnimator = GetComponentInChildren<Animator>();
			oldPosition = base.transform.position;
			oldRotation = base.transform.rotation;
			if (followCamera == null && CameraManager.Instance != null)
			{
				followCamera = CameraManager.Instance.GetComponent<CBFollow>();
			}
			if (rigidbodies != null)
			{
				Collider clubCol = GolfClub != null ? GolfClub.GetComponent<Collider>() : null;
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					Rigidbody rb = rigidbodies[i];
					if (rb != null)
					{
						rb.isKinematic = true;
						rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
						rb.maxAngularVelocity = 500f;
						if (clubCol != null)
						{
							Collider rbCol = rb.GetComponent<Collider>();
							if (rbCol != null)
								Physics.IgnoreCollision(rbCol, clubCol, true);
						}
					}
				}
			}
			if (buoyancyTarget != null)
			{
				buoyancyTarget.OnPostSkip += BuoyancyTarget_OnPostSkip;
			}
		}

		private void BuoyancyTarget_OnPostSkip(Vector3 obj)
		{
			skipCountAfterShot++;
			if (onlyAfterFirstShot && shotCount > 1)
				return;
			if (extraForceOnFirstSkip && skipCountAfterShot <= 1)
			{
				Vector3 xzDir = new Vector3(obj.x, 0f, obj.z).normalized;
				if (hips != null)
				{
					hips.AddForce(Vector3.up * firstSkipExtraYVelocity + xzDir * firstSkipExtraXZVelocity, ForceMode.Impulse);
				}
			}
		}

		private void Start()
		{
			if (GolfClub != null && doFullReset)
			{
				baseClubLocalPosition = GolfClub.transform.localPosition;
				baseClubLocalRotation = GolfClub.transform.localRotation;
				baseClubParent = GolfClub.transform.parent;
			}
			if (GolfBallController != null)
			{
				baseArrowFollow = GolfBallController.ArrowPosition;
			}
			if (CollapseAtStart)
			{
				OnShoot(Vector3.zero);
			}
		}

		private void Update()
		{
			if (hasCollapsed || isCollapsing || golfAnimator == null)
				return;

			float current = golfAnimator.GetFloat("Blend");
			float target = targetBlend.magnitude;
			float smoothed = Mathf.SmoothDamp(current, target, ref velRef, 0.2f, float.PositiveInfinity, Time.unscaledDeltaTime);
			golfAnimator.SetFloat("Blend", Mathf.Min(0.9f, smoothed));
			if (GolfBallController != null && GolfBallController.GetPlayerButtonUp(0, "GolfBallShoot"))
			{
				if (GolfBallController.GetPlayerAxisDirection(0, "GolfBallAimHorizontal", "GolfBallAimVertical").magnitude == 0f)
				{
					targetBlend = Vector3.zero;
				}
			}
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (controller != null && controller.isAiming && buoyancyTarget != null && buoyancyTarget.IsInWater && hips != null)
			{
				Vector3 pos = hips.position;
				Vector3 headForcePos = pos + lastBoost * 2.5f;
				if (head != null)
				{
					head.AddForceAtPosition(lastBoost * lookDirectionForce, headForcePos, ForceMode.Acceleration);
				}
				Vector3 feetForcePos = pos - lastBoost * 2.5f;
				Vector3 feetForce = -lastBoost * feetForceMultiplier * lookDirectionForce;
				if (leftFoot != null)
				{
					leftFoot.AddForceAtPosition(feetForce, feetForcePos, ForceMode.Acceleration);
				}
				if (rightFoot != null)
				{
					rightFoot.AddForceAtPosition(feetForce, feetForcePos, ForceMode.Acceleration);
				}
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (!onlyAimArrow && !hasCollapsed)
			{
				targetBlend = boost;
			}
			lastBoost = boost;
		}

		public override void OnCancel()
		{
			base.OnCancel();
			if (!hasCollapsed)
			{
				targetBlend = Vector3.zero;
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			skipCountAfterShot = 0;
			if (isCollapsing)
				return;

			base.OnShoot(boost);
			if (hasCollapsed)
			{
				Vector3 pitched = PitchBoost(boost, false);
				Vector3 cross = Vector3.Cross(boost, Vector3.up);
				Debug.DrawRay(base.transform.position, cross * 10f, Color.red, 2f);
				if (rigidbodies != null)
				{
					for (int i = 0; i < rigidbodies.Length; i++)
					{
						if (rigidbodies[i] != hips && rigidbodies[i] != null)
						{
							rigidbodies[i].velocity = pitched * 0.1f;
							rigidbodies[i].angularVelocity = pitched * 0.1f;
						}
					}
				}
				float swimMult = (buoyancyTarget != null && buoyancyTarget.IsInWater) ? swimmingVelocityMultiplier : 1f;
				Vector3 norm = pitched.normalized;
				float t = Mathf.Clamp01(pitched.magnitude);
				Vector3 force = Vector3.Lerp(norm * minVelocity * swimMult, norm * fullVelocity * swimMult, t);
				if (hips != null)
				{
					hips.AddForce(force, ForceMode.VelocityChange);
				}
				if (head != null)
				{
					head.AddForce(force, ForceMode.VelocityChange);
				}
				if (hips != null)
				{
					hips.AddTorque(-cross * fullSpin, ForceMode.Impulse);
				}
				shotCount++;
			}
			else
			{
				StartCoroutine(ShootRoutine(boost));
			}
		}

		private IEnumerator ShootRoutine(Vector3 boost)
		{
			OnCollapse?.Invoke();
			isCollapsing = true;
			yield return StartCoroutine(PlayShootSequence(boost));
			Vector3 pitched = PitchBoost(boost, true);
			Vector3 cross = Vector3.Cross(boost, Vector3.up);
			if (golfAnimator != null)
				golfAnimator.enabled = false;
			yield return null;
			yield return new WaitForFixedUpdate();
			if (rigidbodies != null)
			{
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					if (rigidbodies[i] != null)
					{
						rigidbodies[i].isKinematic = false;
						rigidbodies[i].velocity = Vector3.zero;
						rigidbodies[i].angularVelocity = Vector3.zero;
					}
				}
			}
			if (GolfClub != null)
			{
				GolfClub.transform.SetParent(null);
				GolfClub.AddForce((pitched / 3f) * fullVelocity, ForceMode.VelocityChange);
				GolfClub.AddTorque(-cross * fullSpin, ForceMode.VelocityChange);
			}
			float swimMult = (buoyancyTarget != null && buoyancyTarget.IsInWater) ? swimmingVelocityMultiplier : 1f;
			Vector3 norm = pitched.normalized;
			float t = Mathf.Clamp01(pitched.magnitude);
			Vector3 force = customForceOnFirstShot
				? (pitched * firstShotVelocity)
				: Vector3.Lerp(norm * minVelocity * swimMult, norm * fullVelocity * swimMult, t);
			if (hips != null)
			{
				hips.AddForce(force, ForceMode.VelocityChange);
				hips.AddTorque(Vector3.up * fullSpin, ForceMode.VelocityChange);
			}
		}

		public override void OnReset()
		{
			base.OnReset();
			if (rigidbodies != null)
			{
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					if (rigidbodies[i] != null)
					{
						rigidbodies[i].velocity = Vector3.zero;
						rigidbodies[i].angularVelocity = Vector3.zero;
					}
				}
			}
			if (doFullReset)
			{
				if (rigidbodies != null)
				{
					for (int i = 0; i < rigidbodies.Length; i++)
					{
						if (rigidbodies[i] != null)
							rigidbodies[i].isKinematic = true;
					}
				}
				hasCollapsed = false;
				isCollapsing = false;
				if (golfAnimator != null)
					golfAnimator.enabled = true;
				if (GolfClub != null)
				{
					GolfClub.transform.SetParent(baseClubParent);
					GolfClub.transform.localPosition = baseClubLocalPosition;
					GolfClub.transform.localRotation = baseClubLocalRotation;
				}
				if (followCamera != null)
				{
					followCamera.FollowTarget = baseArrowFollow;
				}
				if (GolfBallController != null)
				{
					GolfBallController.ArrowPosition = baseArrowFollow;
				}
			}
		}

		private Vector3 PitchBoost(Vector3 boost, bool first = false)
		{
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			float swimPitch = (buoyancyTarget != null && buoyancyTarget.IsInWater) ? swimmingPitchMultiplier : 1f;
			float angle = (first && customForceOnFirstShot)
				? (firstShotPitch * boost.magnitude)
				: (swimPitch * fullPitch * boost.magnitude);
			return Quaternion.AngleAxis(angle, axis) * boost;
		}

		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			float startBlend = golfAnimator != null ? Mathf.Min(0.9f, golfAnimator.GetFloat("Blend")) : 0f;
			if (playShootRoutine)
			{
				yield return StartCoroutine(pTween.To(0.1f, delegate(float t)
				{
					if (golfAnimator != null)
					{
						golfAnimator.SetFloat("Blend", Mathf.Lerp(startBlend, 0f, TweenFunctions.EaseIn(t)));
					}
				}));
			}
			hasCollapsed = true;
			isCollapsing = false;
			if (GolfBallController != null)
			{
				GolfBallController.CheckpointHit(oldPosition, oldRotation);
			}
			hasCollapsed = true;
			if (GolfClub != null)
			{
				GolfClub.transform.SetParent(ClubRoot);
			}
			if (followCamera != null && hips != null)
			{
				followCamera.FollowTarget = hips.transform;
			}
			if (GolfBallController != null)
			{
				GolfBallController.ArrowPosition = base.transform;
			}
		}
	}
}
