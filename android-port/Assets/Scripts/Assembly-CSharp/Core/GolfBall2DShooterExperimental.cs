using UnityEngine;

namespace Core
{
	public class GolfBall2DShooterExperimental : GolfBall2DShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public float spin;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[SerializeField]
		public bool lookInAimDirection;

		public override void OnActivate()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}
	}
}
