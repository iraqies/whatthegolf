using System.Collections;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class ChuckNorrisShooter : GolfBallShooterBase
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
		private Rigidbody rigidToShoot;

		[SerializeField]
		private float force = 10f;

		private Rigidbody[] rigidbodies;

		private Rigidbody hips;

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

		protected override void Awake()
		{
			base.Awake();
			rigidbodies = GetComponentsInChildren<Rigidbody>();
			if (golfAnimator != null)
			{
				Transform hipsBone = golfAnimator.GetBoneTransform(HumanBodyBones.Hips);
				if (hipsBone != null)
					hips = hipsBone.GetComponent<Rigidbody>();
			}
			golfAnimator = GetComponentInParent<Animator>();
			oldPosition = base.transform.position;
			oldRotation = base.transform.rotation;
			if (followCamera == null && CameraManager.Instance != null)
			{
				followCamera = CameraManager.Instance.GetComponent<CBFollow>();
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

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (!onlyAimArrow && !hasCollapsed)
			{
				targetBlend = boost;
			}
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
			if (hasCollapsed)
				return;

			StartCoroutine(ShootRoutine(boost));
			if (rigidToShoot != null)
			{
				rigidToShoot.velocity = Vector3.zero;
				rigidToShoot.angularVelocity = Vector3.zero;
				rigidToShoot.AddForce(boost * force, ForceMode.Impulse);
			}
		}

		private IEnumerator ShootRoutine(Vector3 boost)
		{
			yield return StartCoroutine(PlayShootSequence(boost));
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

		private Vector3 PitchBoost(Vector3 boost)
		{
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			return Quaternion.AngleAxis(fullPitch * boost.magnitude, axis) * boost;
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
			targetBlend = Vector3.zero;
		}
	}
}
