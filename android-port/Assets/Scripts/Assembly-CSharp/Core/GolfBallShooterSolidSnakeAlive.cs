using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	public class GolfBallShooterSolidSnakeAlive : GolfBallShooterBase, IExplodable
	{
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
		public bool zeroPitchIfNotGrouneded;

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
		}

		private void Update()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		public void OnExplode()
		{
		}
	}
}
