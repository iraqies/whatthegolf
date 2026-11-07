using UnityEngine;

namespace Core
{
	public class GolfBallShooterStandardSpin : GolfBallShooterBase
	{
		[SerializeField]
		private float fullShootVelocity;

		[SerializeField]
		private float pitch;

		[SerializeField]
		private float spin;

		public override void OnActivate()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}
	}
}
