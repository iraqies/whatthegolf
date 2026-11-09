using System;
using System.Collections;
using UnityEngine;

namespace Core
{
	public class FlyingExplosionShooter : GolfBallShooterBase
	{
		[SerializeField] public float fullShootVelocity = 25f;
		[SerializeField] public float minShootVelocity;
		[SerializeField] private float targetHeight = 4.2f;
		[SerializeField] private float AdjustRotationSpeedWhileDriving;
		[SerializeField] private float AdjustRotationSpeed;
		[SerializeField] private ParticleSystem thrusterParticles;
		[SerializeField] private LayerMask collisionBlackListLayer;
		[SerializeField] private bool useGravity = true;
		[SerializeField] private Transform upOverride;
		[SerializeField] private AudioSource rocketAudioSource;

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
		public bool failLevelOnExplode = true;
		public Action<GameObject> onExplode;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
		}

		private void OnEnable()
		{
			barrel = GetComponent<ExplosionBarrel>();
			controller = GetComponent<GolfBallController>();
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (GolfBallController == null || onlyAimArrow || GolfBallController.BlockShooting)
				return;
			Vector3 dir = boost.normalized;
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
			lastShootVelocity = dir * speed;
			isAiming = true;
		}

		public override void OnAimStart()
		{
			if (GolfBallController == null) return;
			if (GolfBallController.BlockShooting)
			{
				didAim = false;
				return;
			}
			base.OnAimStart();
			if (rigidbodyC != null)
				rigidbodyC.useGravity = false;
			if (!didAim)
				firstAimTime = Time.time;
			didAim = true;
			if (thrusterParticles != null)
				thrusterParticles.Play();
			if (rocketAudioSource != null)
				rocketAudioSource.Play();
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
			if (rigidbodyC != null)
				rigidbodyC.useGravity = useGravity;
			if (thrusterParticles != null)
				thrusterParticles.Stop();
			if (rocketAudioSource != null)
				rocketAudioSource.Stop();
		}

		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
			if (dir.magnitude <= 0.001f || rigidbodyC == null) return;
			float rotSpeed = isDriving ? AdjustRotationSpeedWhileDriving : AdjustRotationSpeed;
			Quaternion targetRot = Quaternion.LookRotation(dir.normalized);
			rigidbodyC.MoveRotation(Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, rotSpeed * Time.unscaledDeltaTime));
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (rigidbodyC != null)
				rigidbodyC.angularVelocity = Vector3.zero;
			Vector3 n = boost.normalized;
			float mag = boost.magnitude;
			Vector3 adjusted = new Vector3(n.x * mag, mag, n.z * mag);
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, adjusted.magnitude);
			lastShootVelocity = adjusted.normalized * speed;
			if (rigidbodyC != null)
				rigidbodyC.useGravity = useGravity;
			didAim = true;
			if (thrusterParticles != null)
				thrusterParticles.Stop();
			if (rocketAudioSource != null)
				rocketAudioSource.Stop();
			isAiming = false;
			warmup = 0f;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision == null || collision.gameObject == null) return;
			if ((collisionBlackListLayer.value & (1 << collision.gameObject.layer)) != 0)
				return;
			if (!didAim || Time.time <= firstAimTime + 0.1f || didExplode)
				return;
			if (controller != null)
				controller.CancelShooting();
			if (barrel != null)
			{
				barrel.canExplode = true;
				barrel.Explode(null);
			}
			didExplode = true;
			StartCoroutine(Boom(collision.gameObject));
		}

		protected override void FixedUpdate()
		{
			if (GolfBallController != null)
			{
				if (wasBlocked && !GolfBallController.BlockShooting)
					OnAimStart();
				wasBlocked = GolfBallController.BlockShooting;
			}
			if (didExplode) return;
			if (!didAim)
			{
				if (rigidbodyC != null)
				{
					rigidbodyC.velocity = Vector3.zero;
					rigidbodyC.angularVelocity = Vector3.zero;
				}
				return;
			}
			if (isAiming)
			{
				if (useGravity && rigidbodyC != null)
				{
					Vector3 pos = rigidbodyC.position;
					pos.y = Mathf.MoveTowards(pos.y, targetHeight, Time.fixedDeltaTime * 10f);
					rigidbodyC.MovePosition(pos);
				}
				else if (upOverride != null && rigidbodyC != null)
				{
					Vector3 targetPos = (rigidbodyC.position - upOverride.position).normalized * targetHeight;
					rigidbodyC.MovePosition(Vector3.MoveTowards(rigidbodyC.position, targetPos, Time.fixedDeltaTime * 50f));
				}
				AdjustRotation(lastShootVelocity.normalized, true);
				if (rigidbodyC != null)
				{
					Vector3 fwd = rigidbodyC.transform.forward;
					if (useGravity) fwd.y = 0f;
					fwd.Normalize();
					rigidbodyC.velocity = fwd * lastShootVelocity.magnitude * warmup;
					warmup = Mathf.MoveTowards(warmup, 1f, Time.fixedDeltaTime * 2f);
				}
			}
		}

		private IEnumerator Boom(GameObject hitObject)
		{
			if (thrusterParticles != null) thrusterParticles.Stop();
			if (rocketAudioSource != null) rocketAudioSource.Stop();
			if (controller != null) controller.enabled = false;
			if (rigidbodyC != null) rigidbodyC.drag = 8f;
			onExplode?.Invoke(hitObject);
			yield return new WaitForSeconds(0.1f);
			if (rigidbodyC != null) rigidbodyC.drag = 0.5f;
			if (Level.HasInstance && Level.Instance.IsMultiplayer)
			{
				if (barrel != null) barrel.canExplode = false;
				yield return new WaitForSeconds(1f);
				didAim = false;
				if (barrel != null) barrel.Reset();
				if (rigidbodyC != null) rigidbodyC.drag = 0.25f;
				didExplode = false;
				if (controller != null) controller.enabled = true;
			}
			if (failLevelOnExplode && Level.HasInstance)
			{
				Level.Instance.Fail(true, true, GolfBallController, 0f, true, "ID_FAIL_BOOM");
			}
		}
	}
}
