using UnityEngine;

namespace Core
{
	public class GolfBallShooterStandardSpin : GolfBallShooterBase
	{
		[SerializeField] private float fullShootVelocity = 18f;
		[SerializeField] private float pitch;
		[SerializeField] private float spin = 5f;

		public override void OnActivate() => StartAndWakeup();

		public override void OnShoot(Vector3 boost)
		{
			StandardShoot(boost, pitch, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
