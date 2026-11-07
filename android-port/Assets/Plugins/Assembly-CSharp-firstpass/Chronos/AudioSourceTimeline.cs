using UnityEngine;

namespace Chronos
{
	public class AudioSourceTimeline : ComponentTimeline<AudioSource>
	{
		private float _pitch;

		public float pitch => 0f;

		public AudioSourceTimeline(Timeline timeline, AudioSource component)
			: base((Timeline)null, (AudioSource)null)
		{
		}

		public override void CopyProperties(AudioSource source)
		{
		}

		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
