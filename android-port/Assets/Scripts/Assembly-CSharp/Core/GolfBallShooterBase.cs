using UnityEngine;

namespace Core
{
	public abstract class GolfBallShooterBase : ShooterBase
	{
		protected Rigidbody rigidbodyC;
		[SerializeField] protected float goalPullForce = 5f;
		[SerializeField] protected float goalPullDistance = 1.5f;
		[SerializeField] protected float angleThreshold = 45f;
		[SerializeField] private GolfBallController golfBallControllerOverride;
		[SerializeField] private Rigidbody rigidbodyOverride;
		[SerializeField] public bool isblockedIfNotGrounded;
		public float sqrVelocityShootingThreshold = 0.25f;
		public float shootThresholdMinimumTime = 0.05f;
		protected float lastUnderVelocityShootingThreshold;
		private float currentStillTime;
		private float stillTimeThreshold = 0.05f;

		public Rigidbody RigidbodyOverride
		{
			get => rigidbodyOverride != null ? rigidbodyOverride : rigidbodyC;
			set { rigidbodyOverride = value; rigidbodyC = value; }
		}

		protected virtual void Awake()
		{
			rigidbodyC = rigidbodyOverride != null ? rigidbodyOverride : (GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>());
			GolfBallController = golfBallControllerOverride != null ? golfBallControllerOverride : (GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>());
			if (GolfBallController != null)
			{
				GolfBallController.shooter = this;
				GolfBallController.OnShoot -= GolfBallController_OnShoot;
				GolfBallController.OnShoot += GolfBallController_OnShoot;
				GolfBallController.AddBlockingFunction(IsBlocking);
			}
		}

		private void GolfBallController_OnShoot(Vector3 obj) => OnShoot(obj);

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
		}

		public void SetOwner(GolfBallController newOwner)
		{
			GolfBallController = newOwner;
			if (GolfBallController != null)
				GolfBallController.shooter = this;
		}

		protected virtual void FixedUpdate()
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>();
		}

		protected virtual bool IsBlocking()
		{
			if (isblockedIfNotGrounded && GolfBallController != null && !GolfBallController.IsGrounded)
				return true;
			if (rigidbodyC != null && sqrVelocityShootingThreshold > 0f)
				return rigidbodyC.velocity.sqrMagnitude > sqrVelocityShootingThreshold;
			return false;
		}

		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
			StandardShoot(boost, pitch, 0f, fullShootVelocity, spin);
		}

		protected virtual void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>();
			if (rigidbodyC == null) return;
			rigidbodyC.isKinematic = false;
			rigidbodyC.WakeUp();

			float mag = Mathf.Clamp01(boost.magnitude);
			if (mag <= 1e-4f) return;
			Vector3 dir = boost.normalized;
			if (Mathf.Abs(pitch) > 0.01f)
			{
				Vector3 right = Vector3.Cross(Vector3.up, dir).normalized;
				if (right.sqrMagnitude < 1e-4f) right = Vector3.right;
				dir = Quaternion.AngleAxis(-pitch * mag, right) * dir;
			}
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, mag);
			rigidbodyC.velocity = dir.normalized * speed;
			if (Mathf.Abs(spin) > 0.01f)
				rigidbodyC.AddTorque(Vector3.Cross(Vector3.up, dir) * spin * mag, ForceMode.Impulse);
		}

		public void StopAndSleep()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
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
	}
}
