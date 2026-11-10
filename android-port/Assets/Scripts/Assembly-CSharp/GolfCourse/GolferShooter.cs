using System.Collections;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class GolferShooter : GolfBallShooterBase
	{
		[SerializeField]
		private float minVelocity = 20f;

		[SerializeField]
		private float fullVelocity = 40f;

		[SerializeField]
		private float fullPitch = 30f;

		[SerializeField]
		private float fullSpin = 30f;

		[SerializeField]
		private Rigidbody GolfClub;

		[SerializeField]
		private Animator golfAnimator;

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

		[SerializeField]
		private Rigidbody hips;

		[SerializeField]
		private bool forceSpecificDirection;

		[SerializeField]
		private Vector3 boostOverride;

		private Rigidbody[] rigidbodies;

		private bool hasCollapsed;

		private bool isCollapsing;

		private Vector3 oldPosition;

		private Quaternion oldRotation;

		public CBFollow followCamera;

		private Vector3 targetBlend;

		private float velRef;

		private Vector3 baseClubLocalPosition;

		private Quaternion baseClubLocalRotation;

		private Transform baseClubParent;

		private Transform baseArrowFollow;

		[SerializeField]
		private bool isEditorGolfer;

		[SerializeField]
		private Transform anchor;

		protected override void Awake()
		{
			base.Awake();
			rigidbodies = GetComponentsInChildren<Rigidbody>();
			if (golfAnimator == null)
				golfAnimator = GetComponentInParent<Animator>() ?? GetComponentInChildren<Animator>();
			if (hips == null && golfAnimator != null)
			{
				Transform hipBone = golfAnimator.GetBoneTransform(HumanBodyBones.Hips);
				if (hipBone != null)
					hips = hipBone.GetComponent<Rigidbody>();
			}
			if (hips == null && rigidbodies != null && rigidbodies.Length > 0)
				hips = rigidbodies[0];

			oldPosition = transform.position;
			oldRotation = transform.rotation;

			if (followCamera == null && CameraManager.Instance != null)
				followCamera = CameraManager.Instance.GetComponent<CBFollow>() ?? CameraManager.Instance.GetComponentInChildren<CBFollow>();
			if (followCamera == null)
				followCamera = FindObjectOfType<CBFollow>();
			if (followCamera != null && followCamera.FollowTarget == null)
			{
				GolfBallController gbcInit = GolfBallController != null ? GolfBallController : GetComponentInParent<GolfBallController>();
				if (gbcInit != null)
					followCamera.FollowTarget = gbcInit.ArrowPosition != null ? gbcInit.ArrowPosition : (hips != null ? hips.transform : transform);
			}

			if (rigidbodies != null)
			{
				Collider clubCol = GolfClub != null ? GolfClub.GetComponent<Collider>() : null;
				GolfBallController gbc = GolfBallController != null ? GolfBallController : GetComponentInParent<GolfBallController>();
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					Rigidbody rb = rigidbodies[i];
					if (rb == null) continue;
					rb.isKinematic = true;
					rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
					rb.maxAngularVelocity = 500f;
					if (clubCol != null)
					{
						Collider c = rb.GetComponent<Collider>();
						if (c != null)
							Physics.IgnoreCollision(c, clubCol, true);
					}
					if (gbc != null && rb.gameObject != gbc.gameObject)
					{
						var fwd = rb.gameObject.GetComponent<ChildOutOfBoundsForwarder>();
						if (fwd == null) fwd = rb.gameObject.AddComponent<ChildOutOfBoundsForwarder>();
						fwd.controller = gbc;
					}
				}
			}
		}

		private void Start()
		{
			if (isEditorGolfer && anchor != null)
				anchor.localRotation = Quaternion.Euler(0f, 90f, 0f);

			if (GolfClub != null && doFullReset)
			{
				baseClubLocalPosition = GolfClub.transform.localPosition;
				baseClubLocalRotation = GolfClub.transform.localRotation;
				baseClubParent = GolfClub.transform.parent;
			}

			if (GolfBallController != null)
				baseArrowFollow = GolfBallController.ArrowPosition;

			if (CollapseAtStart)
				OnShoot(Vector3.zero);
		}

		private void Update()
		{
			if (hasCollapsed || isCollapsing) return;
			if (golfAnimator != null)
			{
				float cur = golfAnimator.GetFloat("Blend");
				float target = targetBlend.magnitude;
				float next = Mathf.Min(0.9f, Mathf.SmoothDamp(cur, target, ref velRef, 0.2f, float.PositiveInfinity, Time.unscaledDeltaTime));
				golfAnimator.SetFloat("Blend", next);
			}
			if (GolfClub != null && isEditorGolfer)
			{
				GolfClub.transform.localPosition = baseClubLocalPosition;
				GolfClub.transform.localRotation = baseClubLocalRotation;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (!onlyAimArrow && !hasCollapsed)
				targetBlend = boost;
		}

		public override void OnCancel()
		{
			base.OnCancel();
			if (!hasCollapsed)
				targetBlend = Vector3.zero;
		}

		protected override bool IsBlocking()
		{
			if (isCollapsing) return true;
			if (hasCollapsed && hips != null)
				rigidbodyC = hips;
			return base.IsBlocking();
		}

		public override void OnShoot(Vector3 boost)
		{
			if (isCollapsing) return;
			base.OnShoot(boost);
			if (hasCollapsed)
			{
				Vector3 pitched = PitchBoost(boost);
				Vector3 cross = Vector3.Cross(boost, Vector3.up);
				if (rigidbodies != null)
				{
					for (int i = 0; i < rigidbodies.Length; i++)
					{
						Rigidbody rb = rigidbodies[i];
						if (rb != null && rb != hips)
						{
							rb.velocity = pitched * 0.1f;
							rb.angularVelocity = pitched * 0.1f;
						}
					}
				}
				if (hips != null)
				{
					Vector3 dir = pitched.normalized;
					float mag = Mathf.Clamp01(pitched.magnitude);
					float speed = Mathf.Lerp(minVelocity, fullVelocity, mag);
					hips.AddForce(dir * speed, ForceMode.VelocityChange);
					hips.AddTorque(-cross * fullSpin, ForceMode.VelocityChange);
				}
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
			if (forceSpecificDirection)
				boost = boostOverride;
			Vector3 pitched = PitchBoost(boost);
			Vector3 cross = Vector3.Cross(boost, Vector3.up);
			if (golfAnimator != null)
				golfAnimator.enabled = false;
			yield return new WaitForFixedUpdate();

			if (rigidbodies != null)
			{
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					Rigidbody rb = rigidbodies[i];
					if (rb != null)
					{
						rb.isKinematic = false;
						rb.velocity = Vector3.zero;
						rb.angularVelocity = Vector3.zero;
					}
				}
			}

			if (GolfClub != null)
			{
				GolfClub.AddForce((pitched / 3f) * fullVelocity, ForceMode.VelocityChange);
				GolfClub.AddTorque(-cross * fullSpin, ForceMode.VelocityChange);
			}

			if (hips != null)
			{
				rigidbodyC = hips;
				Vector3 dir = pitched.normalized;
				float mag = Mathf.Clamp01(pitched.magnitude);
				float speed = Mathf.Lerp(minVelocity, fullVelocity, mag);
				hips.AddForce(dir * speed, ForceMode.VelocityChange);
				hips.AddTorque(Vector3.up * fullSpin, ForceMode.VelocityChange);
			}
			lastUnderVelocityShootingThreshold = Time.time - shootThresholdMinimumTime - 1f;
			hasCollapsed = true;
			isCollapsing = false;
		}

		public override void OnReset()
		{
			base.OnReset();
			if (rigidbodies != null)
			{
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					if (rigidbodies[i] != null && !rigidbodies[i].isKinematic)
					{
						rigidbodies[i].velocity = Vector3.zero;
						rigidbodies[i].angularVelocity = Vector3.zero;
					}
				}
				if (doFullReset)
				{
					for (int i = 0; i < rigidbodies.Length; i++)
					{
						if (rigidbodies[i] != null)
							rigidbodies[i].isKinematic = true;
					}
					hasCollapsed = false;
					isCollapsing = false;
					if (golfAnimator != null)
						golfAnimator.enabled = true;
					ResetClub();
					if (followCamera != null && baseArrowFollow != null)
						followCamera.FollowTarget = baseArrowFollow;
					if (GolfBallController != null && baseArrowFollow != null)
						GolfBallController.ArrowPosition = baseArrowFollow;
					if (golfAnimator != null)
						golfAnimator.SetFloat("Blend", 0f);
					targetBlend = Vector3.zero;
				}
				else if (hips != null && GetComponentInChildren<RagdollReset>() == null)
				{
					hips.transform.position = oldPosition;
					hips.transform.rotation = oldRotation;
				}
			}
		}

		public void ResetClub()
		{
			if (GolfClub != null)
			{
				GolfClub.transform.SetParent(baseClubParent);
				GolfClub.transform.localPosition = baseClubLocalPosition;
				GolfClub.transform.localRotation = baseClubLocalRotation;
			}
		}

		private Vector3 PitchBoost(Vector3 boost)
		{
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			return Quaternion.AngleAxis(fullPitch * boost.magnitude, axis) * boost;
		}

		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			float startBlend = 0f;
			if (golfAnimator != null)
				startBlend = Mathf.Min(0.9f, golfAnimator.GetFloat("Blend"));
			if (playShootRoutine && golfAnimator != null)
			{
				yield return StartCoroutine(pTween.To(0.1f, startBlend, 1f, t =>
				{
					if (golfAnimator != null)
						golfAnimator.SetFloat("Blend", t);
				}));
			}
			if (GolfBallController != null)
				GolfBallController.CheckpointHit(oldPosition, oldRotation);
			if (GolfClub != null)
				GolfClub.transform.SetParent(ClubRoot);
			if (followCamera == null && CameraManager.Instance != null)
				followCamera = CameraManager.Instance.GetComponent<CBFollow>() ?? CameraManager.Instance.GetComponentInChildren<CBFollow>();
			if (followCamera == null)
				followCamera = FindObjectOfType<CBFollow>();
			if (followCamera != null && hips != null)
				followCamera.FollowTarget = hips.transform;
			if (GolfBallController != null)
				GolfBallController.ArrowPosition = transform;
		}
	}
}
