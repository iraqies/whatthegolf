using System.Collections;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class ChuckNorrisShooter : GolfBall2DShooterBase
	{
		public bool customForceOnFirstShot;

		public float firstShotVelocity = 800f;

		public float firstShotPitch = 9f;

		public float minVelocity = 20f;

		public float fullVelocity = 40f;

		public float fullPitch = 30f;

		public float fullSpin = 30f;

		public float turnSpeed = 20f;

		public Rigidbody2D GolfClub;

		public Animator golfAnimator;

		public UnityEvent OnCollapse;

		public Transform ClubRoot;

		private Rigidbody2D[] rigidbodies;

		private Rigidbody2D hips;

		private Rigidbody2D head;

		private Rigidbody2D leftFoot;

		private Rigidbody2D rightFoot;

		private GolfBallController controller;

		private Vector3 lastBoost;

		private bool hasCollapsed;

		private bool isCollapsing;

		private Vector3 oldPosition;

		private Quaternion oldRotation;

		public Follow2D followCamera;

		private Vector3 targetBlend;

		private float velRef;

		public float lookDirectionForce = 20f;

		public float feetForceMultiplier = 0.2f;

		protected override void Awake()
		{
			base.Awake();
			controller = GolfBallController;
			rigidbodies = GetComponentsInChildren<Rigidbody2D>();
			if (golfAnimator != null)
			{
				Transform hipsBone = golfAnimator.GetBoneTransform(HumanBodyBones.Hips);
				if (hipsBone != null)
					hips = hipsBone.GetComponent<Rigidbody2D>();
				Transform headBone = golfAnimator.GetBoneTransform(HumanBodyBones.Head);
				if (headBone != null)
					head = headBone.GetComponent<Rigidbody2D>();
				Transform rightFootBone = golfAnimator.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				if (rightFootBone != null)
					rightFoot = rightFootBone.GetComponent<Rigidbody2D>();
				Transform leftFootBone = golfAnimator.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				if (leftFootBone != null)
					leftFoot = leftFootBone.GetComponent<Rigidbody2D>();
			}
			golfAnimator = GetComponentInChildren<Animator>();
			oldPosition = base.transform.position;
			oldRotation = base.transform.rotation;
			if (followCamera == null && CameraManager.Instance != null)
			{
				followCamera = CameraManager.Instance.GetComponent<Follow2D>();
			}
			if (rigidbodies != null)
			{
				Collider2D clubCol = GolfClub != null ? GolfClub.GetComponent<Collider2D>() : null;
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					Rigidbody2D rb = rigidbodies[i];
					if (rb != null)
					{
						rb.isKinematic = true;
						rb.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
						if (clubCol != null)
						{
							Collider2D rbCol = rb.GetComponent<Collider2D>();
							if (rbCol != null)
								Physics2D.IgnoreCollision(rbCol, clubCol, true);
						}
					}
				}
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
			if (controller != null && controller.isAiming && hips != null)
			{
				Vector2 pos = hips.position;
				Vector2 headForcePos = pos + (Vector2)(lastBoost * 2.5f);
				if (head != null)
				{
					head.AddForceAtPosition(lastBoost * lookDirectionForce, headForcePos, ForceMode2D.Force);
				}
				Vector2 feetForcePos = pos - (Vector2)(lastBoost * 2.5f);
				Vector2 feetForce = -lastBoost * feetForceMultiplier * lookDirectionForce;
				if (leftFoot != null)
				{
					leftFoot.AddForceAtPosition(feetForce, feetForcePos, ForceMode2D.Force);
				}
				if (rightFoot != null)
				{
					rightFoot.AddForceAtPosition(feetForce, feetForcePos, ForceMode2D.Force);
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
							rigidbodies[i].angularVelocity = 0f;
						}
					}
				}
				Vector3 norm = pitched.normalized;
				float t = Mathf.Clamp01(pitched.magnitude);
				Vector3 force = Vector3.Lerp(norm * minVelocity, norm * fullVelocity, t);
				if (hips != null)
				{
					hips.AddForce(force, ForceMode2D.Impulse);
					hips.AddTorque(fullSpin);
				}
				if (head != null)
				{
					head.AddForce(force, ForceMode2D.Impulse);
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
			Vector3 pitched = PitchBoost(boost, true);
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
						rigidbodies[i].velocity = Vector2.zero;
						rigidbodies[i].angularVelocity = 0f;
					}
				}
			}
			if (GolfClub != null)
			{
				GolfClub.transform.SetParent(null);
				GolfClub.AddForce((pitched / 3f) * fullVelocity, ForceMode2D.Impulse);
				GolfClub.AddTorque(fullSpin);
			}
			Vector3 norm = pitched.normalized;
			float t = Mathf.Clamp01(pitched.magnitude);
			Vector2 force = customForceOnFirstShot
				? (Vector2)(pitched * firstShotVelocity)
				: (Vector2)Vector3.Lerp(norm * minVelocity, norm * fullVelocity, t);
			if (hips != null)
			{
				hips.AddForce(force);
				hips.AddTorque(fullSpin, ForceMode2D.Impulse);
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
						rigidbodies[i].velocity = Vector2.zero;
						rigidbodies[i].angularVelocity = 0f;
					}
				}
			}
		}

		private Vector3 PitchBoost(Vector3 boost, bool first = false)
		{
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			float pitch = (first && customForceOnFirstShot) ? firstShotPitch : fullPitch;
			return Quaternion.AngleAxis(pitch * boost.magnitude, axis) * boost;
		}

		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			float startBlend = golfAnimator != null ? Mathf.Min(0.9f, golfAnimator.GetFloat("Blend")) : 0f;
			yield return StartCoroutine(pTween.To(0.1f, delegate(float t)
			{
				if (golfAnimator != null)
				{
					golfAnimator.SetFloat("Blend", Mathf.Lerp(startBlend, 0f, TweenFunctions.EaseIn(t)));
				}
			}));
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
				followCamera.SetFollowTarget(hips.transform);
			}
			if (GolfBallController != null)
			{
				GolfBallController.ArrowPosition = base.transform;
			}
		}
	}
}
