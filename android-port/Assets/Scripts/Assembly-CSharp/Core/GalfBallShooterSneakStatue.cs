using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	public class GalfBallShooterSneakStatue : GolfBallShooterBase, IExplodable
	{
		[SerializeField]
		public Animator animator;

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

		[SerializeField]
		protected bool lookInAimDirection;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		[SerializeField]
		public float blockTimeOnExplode;

		public UnityEvent<bool> OnRun;

		public UnityEvent OnStop;

		public UnityEvent OnExploded;

		private BlockShotIfNotGrounded blocker;

		private Vector3 lastBoost;

		private Vector3 baseBoxPosition;

		private float up;

		public bool isWalking;

		[SerializeField]
		private bool countStrokesOnAimUpdate;

		private bool isAiming;

		protected override void Awake()
		{
			base.Awake();
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
					OnRun?.Invoke(true);
				}
			}
			else if (isWalking)
			{
				OnStop?.Invoke();
				OnRun?.Invoke(false);
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
			up = Mathf.MoveTowards(up, targetUp, Time.deltaTime * 100f);
			if (animator != null)
			{
				animator.SetBool("Run", isWalking);
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
			OnExploded?.Invoke();
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
