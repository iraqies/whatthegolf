using UnityEngine;

namespace Core
{
	public class GolfBallShooterSolidSnake : GolfBallShooterBase, IExplodable
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

		public AnimationClip still;

		public AnimationClip walking;

		public bool isWalking;

		[SerializeField]
		private bool countStrokesOnAimUpdate;

		private bool isAiming;

		protected override void Awake()
		{
			base.Awake();
			if (box != null)
				baseBoxPosition = box.localPosition;
			if (boxAnimation != null)
				boxAnimation.Play();
			blocker = GetComponent<BlockShotIfNotGrounded>();
		}

		private void Start()
		{
			if (countStrokesOnAimUpdate && GolfBallController != null)
				GolfBallController.CountStrokes = false;
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
			if (boxAnimation != null)
				boxAnimation.Play();
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (GolfBallController == null)
				return;
			if (blocker != null && blocker.enabled && GolfBallController.IsBlockingFromFunctions())
				return;

			base.OnAimUpdate(boost, onlyAimArrow);
			if (lookInAimDirection && boost.sqrMagnitude > 1e-6f && rigidbodyC != null)
			{
				Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upVec));
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
				Vector3 fwd = transform.forward;
				float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, lastBoost.magnitude);
				if (rigidbodyC != null)
				{
					Vector3 vel = rigidbodyC.velocity;
					rigidbodyC.velocity = new Vector3(fwd.x * speed, vel.y, fwd.z * speed);
				}
				if (!isWalking)
				{
					isWalking = true;
					if (walking != null && boxAnimation != null)
						boxAnimation.CrossFade(walking.name, 0.1f);
				}
				if (walking != null && boxAnimation != null)
				{
					var state = boxAnimation[walking.name];
					if (state != null)
						state.speed = lastBoost.magnitude + 0.3f;
				}
			}
			else
			{
				if (isWalking)
				{
					if (walking != null && boxAnimation != null)
					{
						var state = boxAnimation[walking.name];
						if (state != null)
							state.speed = 1f;
					}
					if (still != null && boxAnimation != null)
						boxAnimation.CrossFade(still.name, 0.1f);
				}
				isWalking = false;
			}
		}

		private void Update()
		{
			if (GolfBallController == null)
				return;

			float targetUp = 0f;
			if (GolfBallController.IsAiming && lastBoost.magnitude > GolfBallController.CancelThreshold)
				targetUp = 1f;

			up = Mathf.MoveTowards(up, targetUp, Time.deltaTime * 5f);
			if (box != null)
			{
				box.localPosition = baseBoxPosition + Vector3.up * (up * 2f);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
			if (lookInShotDirection && rigidbodyC != null && boost.sqrMagnitude > 1e-6f)
			{
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upVec));
			}

			float eval = powerToPitchWeightCurve != null ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f;
			Vector3 planeNormal = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			float weightedPitch = pitch * eval;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
			{
				if (axis.sqrMagnitude > 1e-6f)
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
				GolfBallController.CancelShooting();
			OnShoot(Vector3.zero);
			if (blocker != null)
			{
				blocker.enabled = false;
				StartCoroutine(pTween.To(blockTimeOnExplode, _ => { }).Then(() =>
				{
					if (blocker != null)
						blocker.enabled = true;
				}));
			}
		}
	}
}
