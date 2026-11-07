using UnityEngine;

namespace Core
{
	public class NoJumpsAllowedHurdleShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float spin;

		[SerializeField]
		public float shotXMultiplier;

		public float allowedZVariance;

		public float zCorrectionSpeedMultiplier;

		public float minimumZCorrectionSpeed;

		private float originZ;

		protected override void Awake()
		{
		}

		protected override void FixedUpdate()
		{
		}

		public override void OnActivate()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}
	}
}
