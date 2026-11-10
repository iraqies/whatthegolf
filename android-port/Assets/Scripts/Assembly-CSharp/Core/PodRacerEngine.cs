using System;
using System.Collections;
using UnityEngine;

namespace Core
{
	public class PodRacerEngine : MonoBehaviour
	{
		[SerializeField]
		public ParticleSystem thrusterParticles;

		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[SerializeField]
		public bool useGravity = true;

		[SerializeField]
		private GolfBallController golfBallController;

		private bool didExplode;

		private ExplosionBarrel barrel;

		public bool didAim;

		public float firstAimTime;

		public bool failLevelOnExplode = true;

		public Action<GameObject> onExplode;

		public Rigidbody rigidbodyC;

		public void Awake()
		{
			rigidbodyC = GetComponent<Rigidbody>();
		}

		public void OnEnable()
		{
			barrel = GetComponent<ExplosionBarrel>();
			if (rigidbodyC == null)
				rigidbodyC = GetComponent<Rigidbody>();
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision == null || collision.gameObject == null)
				return;

			int mask = collisionBlackListLayer;
			if (mask == (mask | (1 << collision.gameObject.layer)))
				return;

			if (!didAim || Time.time <= firstAimTime + 0.1f || didExplode)
				return;

			if (barrel != null)
			{
				barrel.DestroyOnExplosion = false;
				barrel.Explode(null);
			}
			didExplode = true;
			StartCoroutine(Boom(collision.gameObject));
		}

		private IEnumerator Boom(GameObject hitObject)
		{
			if (thrusterParticles != null)
				thrusterParticles.Stop();
			if (golfBallController != null)
			{
				golfBallController.enabled = false;
				golfBallController.CancelShooting();
			}
			if (rigidbodyC != null)
				rigidbodyC.drag = 8f;
			onExplode?.Invoke(hitObject);

			yield return new WaitForSeconds(0.1f);

			if (rigidbodyC != null)
				rigidbodyC.drag = 0.5f;

			if (Level.Instance != null && Level.Instance.IsMultiplayer)
			{
				if (barrel != null)
					barrel.DestroyOnExplosion = true;
				yield return new WaitForSeconds(1f);
				didAim = false;
				if (barrel != null)
				{
					barrel.didExplode = false;
					if (barrel.burnedRender != null)
						barrel.burnedRender.enabled = false;
					if (barrel.normalRender != null)
						barrel.normalRender.enabled = true;
				}
				if (rigidbodyC != null)
					rigidbodyC.drag = 0.25f;
				didExplode = false;
			}

			if (failLevelOnExplode && Level.Instance != null)
			{
				Level.Instance.Fail(true, true, golfBallController, 0f, true, "");
			}
		}
	}
}
