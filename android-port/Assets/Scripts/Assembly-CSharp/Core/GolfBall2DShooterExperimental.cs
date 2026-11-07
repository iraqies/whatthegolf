using UnityEngine;

namespace Core
{
	public class GolfBall2DShooterExperimental : GolfBall2DShooterBase
	{
		[SerializeField] public float minShootVelocity = 2f;
		[SerializeField] public float fullShootVelocity = 16f;
		[SerializeField] public float pitch;
		[SerializeField] public float spin;
		[SerializeField] public bool zeroPitchIfNotGrouneded;
		[SerializeField] public bool lookInAimDirection;

		public override void OnActivate() => StartAndWakeup();
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow) { }

		public override void OnShoot(Vector3 boost)
		{
			float p = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : pitch;
			StandardShoot(boost, p, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 16f, spin);
		}
	}
}
