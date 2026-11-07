using UnityEngine;

namespace Core
{
	public abstract class GolfBallShooterBase : ShooterBase
	{
		protected Rigidbody rigidbodyC;

		[SerializeField]
		protected float goalPullForce;

		[SerializeField]
		protected float goalPullDistance;

		[SerializeField]
		protected float angleThreshold;

		[SerializeField]
		private GolfBallController golfBallControllerOverride;

		[SerializeField]
		private Rigidbody rigidbodyOverride;

		[SerializeField]
		public bool isblockedIfNotGrounded;

		public float sqrVelocityShootingThreshold;

		public float shootThresholdMinimumTime;

		protected float lastUnderVelocityShootingThreshold;

		private float currentStillTime;

		private float stillTimeThreshold;

		public Rigidbody RigidbodyOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		private void GolfBallController_OnShoot(Vector3 obj)
		{
		}

		public void SetOwner(GolfBallController newOwner)
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

		protected virtual void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		public void StopAndSleep()
		{
		}

		public void StartAndWakeup()
		{
		}
	}
}
