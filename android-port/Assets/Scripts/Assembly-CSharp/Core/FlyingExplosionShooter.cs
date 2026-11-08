using System;
using System.Collections;
using UnityEngine;

namespace Core
{
	public class FlyingExplosionShooter : GolfBallShooterBase
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
		private ParticleSystem thrusterParticles;

		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[SerializeField]
		private bool useGravity;

		[SerializeField]
		private Transform upOverride;

		[SerializeField]
		private AudioSource rocketAudioSource;

		private GolfBallController controller;

		private bool didExplode;

		public GolfBallController ballController;

		private ExplosionBarrel barrel;

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
		StandardShoot(boost, 20f, 18f, 5f);
	}

		private void OnCollisionEnter(Collision collision)
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		private IEnumerator Boom(GameObject hitObject)
		{
			return null;
		}
	}
}
