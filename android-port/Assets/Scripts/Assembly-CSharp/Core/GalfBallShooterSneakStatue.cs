using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	public class GalfBallShooterSneakStatue : GolfBallShooterBase, IExplodable
	{
		[SerializeField]
		public Animator animator;

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

		[SerializeField]
		protected bool lookInAimDirection;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

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
	}

		private void Start()
		{
		}

		public override void OnActivate()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnCancel()
		{
		}

		public override void OnReset()
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		private void Update()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, pitch, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), spin);
	}

		public void OnExplode()
		{
		}
	}
}
