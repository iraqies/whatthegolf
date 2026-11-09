using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class AudioClipFromVelocity
	{
		public List<AudioClip> clips;

		public float minVelocity;

		public float maxVelocity;

		public float minVolume = 0.2f;

		public float maxVolume = 1f;

		public float minPitch = 0.9f;

		public float maxPitch = 1.1f;

		public void SetSoundValues(float velocity, out Action<AudioSource> modifier)
		{
			float t = maxVelocity > minVelocity ? Mathf.Clamp01((velocity - minVelocity) / (maxVelocity - minVelocity)) : 1f;
			float vol = Mathf.Lerp(minVolume > 0f ? minVolume : 0.3f, maxVolume > 0f ? maxVolume : 1f, t);
			float pit = Mathf.Lerp(minPitch > 0.05f ? minPitch : 0.95f, maxPitch > 0.05f ? maxPitch : 1.05f, t);
			modifier = s =>
			{
				if (s != null)
				{
					s.volume = vol;
					s.pitch = pit;
				}
			};
		}
	}
}
