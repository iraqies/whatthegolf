using UnityEngine;

namespace Core
{
	public abstract class GolfBallShooterBase : ShooterBase
	{
		protected Rigidbody rigidbodyC;
		[SerializeField] protected float goalPullForce = 5f;
		[SerializeField] protected float goalPullDistance = 1.5f;
		[SerializeField] protected float angleThreshold = 30f;
		[SerializeField] private GolfBallController golfBallControllerOverride;
		[SerializeField] private Rigidbody rigidbodyOverride;
		[SerializeField] public bool isblockedIfNotGrounded;
		public float sqrVelocityShootingThreshold = float.PositiveInfinity;
		public float shootingThreshold
		{
			get => sqrVelocityShootingThreshold;
			set => sqrVelocityShootingThreshold = value;
		}
		public float shootThresholdMinimumTime = 0.2f;
		protected float lastUnderVelocityShootingThreshold;
		private float currentStillTime;
		private float stillTimeThreshold = 0.09f;
		private int lastBlockingFrame = -1;

		public Rigidbody RigidbodyOverride
		{
			get => rigidbodyOverride != null ? rigidbodyOverride : rigidbodyC;
			set { rigidbodyOverride = value; rigidbodyC = value; }
		}

		protected Rigidbody rigid
		{
			get => rigidbodyC;
			set => rigidbodyC = value;
		}

		protected Rigidbody Rigid
		{
			get => rigidbodyC;
			set => rigidbodyC = value;
		}

		protected Rigidbody Rigidbody
		{
			get => rigidbodyC;
			set => rigidbodyC = value;
		}

		protected float MinRestVelocity => sqrVelocityShootingThreshold;

		protected float minimumAimLength => GolfBallController != null ? GolfBallController.CancelThreshold : 0.03f;

		protected bool IsShootingBlocked() => IsBlocking();

		protected GolfBallController GolfManager => GolfBallController;

		protected virtual void Awake()
		{
			GolfBallController = golfBallControllerOverride != null ? golfBallControllerOverride : (GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>());
			if (GolfBallController != null)
			{
				GolfBallController.shooter = this;
				GolfBallController.OnShoot -= GolfBallController_OnShoot;
				GolfBallController.OnShoot += GolfBallController_OnShoot;
				GolfBallController.AddBlockingFunction(IsBlocking);
			}
			rigidbodyC = rigidbodyOverride != null ? rigidbodyOverride : GetComponent<Rigidbody>();
		}

		private void GolfBallController_OnShoot(Vector3 obj)
		{
			currentStillTime = 0f;
			lastUnderVelocityShootingThreshold = Time.time - shootThresholdMinimumTime - 1f;
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC == null)
				rigidbodyC = rigidbodyOverride != null ? rigidbodyOverride : (GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>());
		}

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
			if (rigidbodyC == null) rigidbodyC = rigidbodyOverride != null ? rigidbodyOverride : (GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>());
			if (goalPullDistance > 0f && Level.HasInstance && Level.Instance != null && rigidbodyC != null && GolfBallController != null && GolfBallController.enabled)
			{
				if (rigidbodyC.velocity.magnitude > 5f && Level.Instance.Goal != null)
				{
					Vector3 toGoal = Level.Instance.Goal.transform.position - transform.position;
					if (toGoal.magnitude <= goalPullDistance && Vector3.Angle(rigidbodyC.velocity, toGoal) < angleThreshold)
					{
						rigidbodyC.AddForce(toGoal.normalized * goalPullForce);
					}
				}
			}
			if (GolfBallController != null && rigidbodyC != null && !float.IsInfinity(sqrVelocityShootingThreshold) && !float.IsNaN(sqrVelocityShootingThreshold))
			{
				GolfBallController.isBlocking = IsBlocking();
			}
		}

		protected virtual bool IsBlocking()
		{
			if (rigidbodyC == null) return false;
			if (!float.IsInfinity(sqrVelocityShootingThreshold) && !float.IsNaN(sqrVelocityShootingThreshold) && sqrVelocityShootingThreshold > 0f)
			{
				float sqrVel = rigidbodyC.velocity.sqrMagnitude;
				if (Time.frameCount != lastBlockingFrame)
				{
					lastBlockingFrame = Time.frameCount;
					if (sqrVel < sqrVelocityShootingThreshold)
						currentStillTime += Time.unscaledDeltaTime;
					else
						currentStillTime = 0f;

					if (currentStillTime >= stillTimeThreshold)
						lastUnderVelocityShootingThreshold = Time.time;
				}
				else if (sqrVel >= sqrVelocityShootingThreshold)
				{
					currentStillTime = 0f;
				}
			}
			else
			{
				lastUnderVelocityShootingThreshold = Time.time;
				currentStillTime = stillTimeThreshold;
			}

			bool blocked = (Time.time >= lastUnderVelocityShootingThreshold + shootThresholdMinimumTime) && (currentStillTime < stillTimeThreshold);
			if (isblockedIfNotGrounded && GolfBallController != null && !GolfBallController.IsGrounded)
				blocked = true;
			return blocked;
		}

		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
			if (Mathf.Abs(pitch) > 0.001f)
			{
				Vector3 planeNormal = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
				Vector3 axis = Vector3.Cross(boost, planeNormal);
				if (axis.sqrMagnitude > 1e-6f)
					boost = Quaternion.AngleAxis(pitch, axis) * boost;
			}
			StandardShoot(boost, pitch, 5f, fullShootVelocity, spin);
		}

		protected virtual void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidbodyC == null) rigidbodyC = rigidbodyOverride != null ? rigidbodyOverride : (GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>());
			if (rigidbodyC == null) return;
			rigidbodyC.isKinematic = false;
			rigidbodyC.WakeUp();

			Vector3 planeNormal = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			Vector3 cross = Vector3.Cross(boost, planeNormal);
			rigidbodyC.angularVelocity = Vector3.zero;
			rigidbodyC.velocity = Vector3.zero;

			Vector3 dir = boost.normalized;
			float mag = boost.magnitude;
			Vector3 minVel = dir * minShootVelocity;
			Vector3 maxVel = dir * fullShootVelocity;
			rigidbodyC.velocity = minVel + (maxVel - minVel) * mag;
			rigidbodyC.AddTorque(-cross * spin, ForceMode.VelocityChange);
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

		public void BlockShootingForSeconds(float seconds)
		{
			if (GolfBallController != null)
			{
				GolfBallController.BlockShootingForSeconds(seconds);
			}
		}
	}
}
