using UnityEngine;

namespace Core
{
	public class FPGShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		private Quaternion startForward;

		private float lastShotTime;

		protected override void Awake()
		{
		base.Awake();
	}

		public override void OnActivate()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}

		private void Shoot(Vector3 boost, bool comingFromUpdate)
		{
		}

		private void LateUpdate()
		{
		}

		public override void OnReset()
		{
		}
	}
}
