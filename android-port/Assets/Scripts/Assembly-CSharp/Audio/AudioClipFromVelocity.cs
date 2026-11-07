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

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public void SetSoundValues(float velocity, out Action<AudioSource> modifier)
		{
			modifier = null;
		}
	}
}
