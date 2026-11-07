using UnityEngine;

namespace Core
{
	public class GolfBallShooterStandard : GolfBallShooterBase
	{
		[SerializeField]
		private float fullShootVelocity;

		[SerializeField]
		private float pitch;

		public override void OnActivate()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}
	}
}
