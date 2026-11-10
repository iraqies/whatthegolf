using SpaceGolf;
using UnityEngine;

namespace Audio
{
	public class AudioValueSpaceball : BaseAudioValue
	{
		[SerializeField]
		public SpaceGolfBallShooter shooter;

		protected override bool Use2D => true;

		private void Update()
		{
			SetValue();
		}

		protected override void SetValue()
		{
			if (shooter == null) return;
			value = shooter.isStuck ? 0f : shooter.BallVelocity.magnitude;
			base.SetValue();
		}
	}
}
