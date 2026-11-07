using System;
using UnityEngine;

namespace Audio.Rumble
{
	[Serializable]
	public class RumbleFileSetting
	{
		public TextAsset rumbleFile;

		public AudioClip ps5HapticsAudioClip;

		public float[] vibrationData;
	}
}
