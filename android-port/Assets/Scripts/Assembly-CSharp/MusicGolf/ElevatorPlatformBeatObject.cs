using UnityEngine;

namespace MusicGolf
{
	public class ElevatorPlatformBeatObject : BeatObject
	{
		[SerializeField]
		private Rigidbody2D rigidbody2D;

		[SerializeField]
		private AnimationCurve elevationCurve;

		[SerializeField]
		private float elevationMax;

		public override void PlayProgress(float t)
		{
		}
	}
}
