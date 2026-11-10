using System;
using UnityEngine;

namespace Core
{
	public class PodRacerShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float targetHeight = 4.2f;

		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[SerializeField]
		private float AdjustRotationSpeed;

		[SerializeField]
		private bool useGravity = true;

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

		public bool failLevelOnExplode = true;

		public Action<GameObject> onExplode;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
			if (engines != null)
			{
				for (int i = 0; i < engines.Length; i++)
				{
					if (engines[i] != null)
					{
						engines[i].failLevelOnExplode = failLevelOnExplode;
						engines[i].onExplode = onExplode;
					}
				}
			}
		}

		private void OnEnable()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
			if (engines != null)
			{
				for (int i = 0; i < engines.Length; i++)
				{
					if (engines[i] != null)
						engines[i].OnEnable();
				}
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (GolfBallController == null)
				return;
			bool blocked = GolfBallController.BlockShooting;
			if (onlyAimArrow || blocked)
				return;

			lastShootVelocity = boost.normalized * Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
			isAiming = true;
			if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null)
			{
				AudioManager.Instance.rumbleManager.PlayVibrationValue(0.15f, 80f, 0f, 0f, GolfBallController.PlayerID);
			}
		}

		public override void OnAimStart()
		{
			if (GolfBallController != null && GolfBallController.BlockShooting)
			{
				didAim = false;
				if (engines != null)
				{
					for (int i = 0; i < engines.Length; i++)
					{
						if (engines[i] != null)
							engines[i].didAim = false;
					}
				}
				return;
			}

			base.OnAimStart();
			if (rigidbodyC != null)
				rigidbodyC.useGravity = false;
			if (engines != null)
			{
				for (int i = 0; i < engines.Length; i++)
				{
					if (engines[i] != null && engines[i].rigidbodyC != null)
						engines[i].rigidbodyC.useGravity = false;
				}
			}

			if (!didAim)
			{
				firstAimTime = Time.time;
				if (engines != null)
				{
					for (int i = 0; i < engines.Length; i++)
					{
						if (engines[i] != null)
							engines[i].firstAimTime = Time.time;
					}
				}
			}

			didAim = true;
			if (engines != null)
			{
				for (int i = 0; i < engines.Length; i++)
				{
					if (engines[i] != null)
					{
						engines[i].didAim = true;
						if (engines[i].thrusterParticles != null)
							engines[i].thrusterParticles.Play();
					}
				}
			}
			if (rocketAudioSource != null)
				rocketAudioSource.Play();
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
			if (rigidbodyC != null)
				rigidbodyC.useGravity = useGravity;
			if (engines != null)
			{
				for (int i = 0; i < engines.Length; i++)
				{
					if (engines[i] != null)
					{
						if (engines[i].rigidbodyC != null)
							engines[i].rigidbodyC.useGravity = engines[i].useGravity;
						if (engines[i].thrusterParticles != null)
							engines[i].thrusterParticles.Stop();
					}
				}
			}
			if (rocketAudioSource != null)
				rocketAudioSource.Stop();
			if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && GolfBallController != null)
				AudioManager.Instance.rumbleManager.StopVibration(GolfBallController.PlayerID);
		}

		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
			if (dir.magnitude <= 0.001f || rigidbodyC == null)
				return;

			float speed = isDriving ? AdjustRotationSpeedWhileDriving : AdjustRotationSpeed;
			Quaternion targetRot = Quaternion.LookRotation(dir.normalized);
			Quaternion nextRot = Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, speed * Time.unscaledDeltaTime);
			rigidbodyC.MoveRotation(nextRot);
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && GolfBallController != null)
				AudioManager.Instance.rumbleManager.StopVibration(GolfBallController.PlayerID);

			if (rigidbodyC != null)
				rigidbodyC.angularVelocity = Vector3.zero;

			Vector3 norm = boost.normalized;
			float mag = boost.magnitude;
			Vector3 horizontalBoost = new Vector3(norm.x * mag, mag, norm.z * mag);
			lastShootVelocity = horizontalBoost.normalized * Mathf.Lerp(minShootVelocity, fullShootVelocity, horizontalBoost.magnitude);

			if (rigidbodyC != null)
				rigidbodyC.useGravity = useGravity;

			didAim = true;
			if (engines != null)
			{
				for (int i = 0; i < engines.Length; i++)
				{
					if (engines[i] != null)
					{
						if (engines[i].rigidbodyC != null)
							engines[i].rigidbodyC.useGravity = engines[i].useGravity;
						engines[i].didAim = true;
						if (engines[i].thrusterParticles != null)
							engines[i].thrusterParticles.Stop();
					}
				}
			}
			if (rocketAudioSource != null)
				rocketAudioSource.Stop();
			isAiming = false;
		}

		protected override void FixedUpdate()
		{
			if (GolfBallController != null)
			{
				if (wasBlocked && !GolfBallController.BlockShooting)
					OnActivate();
				wasBlocked = GolfBallController.BlockShooting;
			}
			if (didExplode)
				return;

			if (didAim)
			{
				if (!isAiming)
					return;

				if (useGravity && rigidbodyC != null)
				{
					Vector3 pos = rigidbodyC.position;
					pos.y = Mathf.MoveTowards(pos.y, targetHeight, Time.fixedDeltaTime * 10f);
					rigidbodyC.position = pos;
				}

				AdjustRotation(lastShootVelocity.normalized, true);
				if (rigidbodyC != null)
				{
					Vector3 fwd = rigidbodyC.transform.forward;
					if (useGravity)
						fwd.y = 0f;
					fwd.Normalize();
					float speed = lastShootVelocity.magnitude * warmup;
					rigidbodyC.velocity = fwd * speed;
					if (pilot != null)
					{
						pilot.velocity -= fwd * (0.1f * speed);
					}
				}
				warmup = Mathf.MoveTowards(warmup, 1f, Time.fixedDeltaTime * 2f);
			}
			else if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
		}
	}
}
