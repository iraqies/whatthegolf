using UnityEngine;

namespace Core
{
	public class PaperPlaneShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float pitch;

		[SerializeField]
		protected float spin;

		private ParticleSystem particle;

		private Quaternion targetRotation;

		private Vector3 shootVelocity;

		protected override void Awake()
		{
		base.Awake();
	}

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, pitch, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), spin);
	}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		private void clampRotation(bool reset)
		{
		}

		private Quaternion AdjustRotation(Vector3 dir)
		{
			return default;
		}

		protected void PaperShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}
	}
}
