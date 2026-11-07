using SpaceGolf;
using UnityEngine;

namespace Audio
{
	public class AudioValueSpaceball : BaseAudioValue
	{
		[SerializeField]
		public SpaceGolfBallShooter shooter;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
