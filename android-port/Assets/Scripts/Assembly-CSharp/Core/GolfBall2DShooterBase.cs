using System.Collections;
using UnityEngine;

namespace Core
{
	public abstract class GolfBall2DShooterBase : ShooterBase
	{
		protected Rigidbody2D rigidbodyC;

		[SerializeField]
		private float goalPullForce;

		[SerializeField]
		private float goalPullDistance;

		[SerializeField]
		private bool useCurrentForce;

		public float sqrVelocityShootingThreshold;

		private float currentStillTime;

		private float stillTimeThreshold;

		private Coroutine lockRoutine;

		protected virtual void Awake()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual bool IsBlocking()
		{
			return false;
		}

		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
		}

		public void StopAndSleep()
		{
		}

		public void StartAndWakeup()
		{
		}

		protected void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		public void LockForDuration(float v)
		{
		}

		private IEnumerator LockForDurationRoutine(float duration)
		{
			return null;
		}
	}
}
