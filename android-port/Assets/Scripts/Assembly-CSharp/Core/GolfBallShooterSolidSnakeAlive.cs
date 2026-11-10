using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	public class GolfBallShooterSolidSnakeAlive : GolfBallShooterBase, IExplodable
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
		public Transform box;

		[SerializeField]
		public Animation boxAnimation;

		[SerializeField]
		protected bool lookInShotDirection;

		[SerializeField]
		protected bool lookInAimDirection;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		[SerializeField]
		public float blockTimeOnExplode;

		private BlockShotIfNotGrounded blocker;

		private Vector3 lastBoost;

		private Vector3 baseBoxPosition;

		private float up;

		public float animationSpeed;

		public AnimationClip still;

		public AnimationClip walking;

		public bool isWalking;

		[SerializeField]
		private bool countStrokesOnAimUpdate;

		private bool isAiming;

		public UnityEvent OnWalking;

		public UnityEvent OnStopped;

		protected override void Awake()
		{
			base.Awake();
			if (box != null)
			{
				baseBoxPosition = box.localPosition;
			}
			if (boxAnimation != null)
			{
				boxAnimation.Play();
			}
			blocker = GetComponent<BlockShotIfNotGrounded>();
		}

		private void Start()
		{
			if (countStrokesOnAimUpdate && GolfBallController != null)
			{
				GolfBallController.countStrokes = false;
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigid != null)
			{
				rigid.isKinematic = false;
			}
			if (boxAnimation != null)
			{
				boxAnimation.Play();
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (GolfBallController == null || GolfBallController.BlockShooting)
				return;
			if (blocker != null && blocker.isBlocked)
				return;

			base.OnAimUpdate(boost, onlyAimArrow);
			if (lookInAimDirection && rigid != null)
			{
				Vector3 upVec = useLocalUp ? base.transform.up : Vector3.up;
				if (boost != Vector3.zero)
				{
					rigid.MoveRotation(Quaternion.LookRotation(boost, upVec));
				}
			}
			lastBoost = boost;
			if (countStrokesOnAimUpdate && !isAiming && GolfBallController != null)
			{
				GolfBallController.CountShot();
			}
			isAiming = true;
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

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (Mathf.Approximately(up, 1f))
			{
				Vector3 fwd = base.transform.forward;
				float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, lastBoost.magnitude);
				if (rigid != null)
				{
					rigid.velocity = new Vector3(fwd.x * speed, rigid.velocity.y, fwd.z * speed);
				}
				if (!isWalking)
				{
					isWalking = true;
					if (walking != null && boxAnimation != null)
					{
						boxAnimation.CrossFade(walking.name, 0.1f);
					}
					OnWalking?.Invoke();
				}
				if (walking != null && boxAnimation != null && boxAnimation[walking.name] != null)
				{
					boxAnimation[walking.name].speed = animationSpeed + lastBoost.magnitude;
				}
			}
			else if (isWalking)
			{
				if (walking != null && boxAnimation != null && boxAnimation[walking.name] != null)
				{
					boxAnimation[walking.name].speed = animationSpeed;
				}
				if (still != null && boxAnimation != null)
				{
					boxAnimation.CrossFade(still.name, 0.1f);
				}
				OnStopped?.Invoke();
				isWalking = false;
			}
		}

		private void Update()
		{
			if (GolfBallController == null)
				return;

			float targetUp = 0f;
			if (GolfBallController.isAiming)
			{
				targetUp = (lastBoost.magnitude > minimumAimLength) ? 1f : 0f;
			}
			up = Mathf.MoveTowards(up, targetUp, Time.deltaTime * 5f);
			if (box != null)
			{
				box.transform.localPosition = baseBoxPosition + Vector3.up * up * 2f;
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
			Vector3 planeNormal = (GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.planeType).normal : Vector3.up;
			float weightedPitch = pitch * weight;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
			{
				boost = Quaternion.AngleAxis(weightedPitch, axis) * boost;
			}

			StandardShoot(boost, weightedPitch, minShootVelocity, fullShootVelocity, spin);
			lastBoost = Vector3.zero;
			isAiming = false;
		}

		public void OnExplode()
		{
			isAiming = false;
			if (GolfBallController != null)
			{
				GolfBallController.CancelShooting();
			}
			OnShoot(Vector3.zero);
			if (blocker != null)
			{
				blocker.enabled = false;
				StartCoroutine(pTween.To(blockTimeOnExplode, delegate
				{
				}).Then(delegate
				{
					if (blocker != null)
					{
						blocker.enabled = true;
					}
				}));
			}
		}
	}
}
