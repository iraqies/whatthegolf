using UnityEngine;

namespace Core
{
	public class UfoShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float targetHeight;

		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[SerializeField]
		private float AdjustRotationSpeed;

		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[SerializeField]
		private bool useGravity;

		[SerializeField]
		private Transform upOverride;

		private GolfBallController controller;

		public GolfBallController ballController;

		private ExplosionBarrel barrel;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private bool didAim;

		private float firstAimTime;

		private float warmup;

		public override void OnActivate()
		{
		}

		private void OnEnable()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnAimStart()
		{
		}

		public override void OnCancel()
		{
		}

		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		protected override void FixedUpdate()
		{
		}
	}
}
