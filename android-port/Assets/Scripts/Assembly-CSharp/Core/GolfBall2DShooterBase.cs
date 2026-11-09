using System.Collections;
using UnityEngine;

namespace Core
{
	public abstract class GolfBall2DShooterBase : ShooterBase
	{
		protected Rigidbody2D rigidbodyC;
		[SerializeField] private float goalPullForce = 5f;
		[SerializeField] private float goalPullDistance = 1.5f;
		[SerializeField] private bool useCurrentForce;
		public float sqrVelocityShootingThreshold = 0.25f;
		private float currentStillTime;
		private float stillTimeThreshold = 0.05f;
		private Coroutine lockRoutine;

		protected virtual void Awake()
		{
			rigidbodyC = GetComponent<Rigidbody2D>() ?? GetComponentInChildren<Rigidbody2D>();
			GolfBallController = GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>();
			if (GolfBallController != null)
			{
				GolfBallController.shooter = this;
				GolfBallController.AddBlockingFunction(IsBlocking);
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC == null)
				rigidbodyC = GetComponent<Rigidbody2D>() ?? GetComponentInChildren<Rigidbody2D>();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
		}

		protected virtual void FixedUpdate()
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody2D>() ?? GetComponentInChildren<Rigidbody2D>();
		}

		protected virtual bool IsBlocking()
		{
			if (rigidbodyC != null && sqrVelocityShootingThreshold > 0f)
				return rigidbodyC.velocity.sqrMagnitude > sqrVelocityShootingThreshold;
			return false;
		}

		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
			StandardShoot(boost, pitch, 0f, fullShootVelocity, spin);
		}

		public void StopAndSleep()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector2.zero;
				rigidbodyC.angularVelocity = 0f;
				rigidbodyC.Sleep();
			}
		}

		public void StartAndWakeup()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
				rigidbodyC.WakeUp();
			}
		}

		protected void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody2D>() ?? GetComponentInChildren<Rigidbody2D>();
			if (rigidbodyC == null) return;
			rigidbodyC.isKinematic = false;
			rigidbodyC.WakeUp();

			Vector2 dir2 = new Vector2(boost.x, boost.y);
			if (dir2.sqrMagnitude < 1e-4f)
				dir2 = new Vector2(boost.x, boost.z);
			float mag = Mathf.Clamp01(dir2.magnitude);
			if (mag <= 1e-4f) return;

			Vector2 dir = dir2.normalized;
			if (Mathf.Abs(pitch) > 0.01f)
			{
				float sign = dir.x >= 0f ? 1f : -1f;
				dir = Quaternion.Euler(0f, 0f, pitch * sign * mag) * dir;
			}
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 16f, mag);
			rigidbodyC.velocity = dir.normalized * speed;
			if (Mathf.Abs(spin) > 0.01f)
				rigidbodyC.AddTorque(-Mathf.Sign(dir.x) * spin * mag, ForceMode2D.Impulse);
		}

		public void LockForDuration(float v)
		{
			if (gameObject.activeInHierarchy)
				lockRoutine = StartCoroutine(LockForDurationRoutine(v));
		}

		private IEnumerator LockForDurationRoutine(float duration)
		{
			StopAndSleep();
			yield return new WaitForSeconds(duration);
			StartAndWakeup();
		}
	}
}
