using System;
using UnityEngine;

namespace Core
{
	public class PodRacerShooter : GolfBallShooterBase
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
		private bool useGravity;

		[SerializeField]
		private AudioSource rocketAudioSource;

		[SerializeField]
		private PodRacerEngine[] engines;

		[SerializeField]
		private Rigidbody pilot;

		private bool didExplode;

		public GolfBallController ballController;

		private bool wasBlocked;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private bool didAim;

		private float firstAimTime;

		private float warmup;

		public bool failLevelOnExplode;

		public Action<GameObject> onExplode;

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
		base.OnShoot(boost);
		StandardShoot(boost, 15f, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), 5f);
	}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}
	}
}
