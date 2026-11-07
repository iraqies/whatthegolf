using UnityEngine;

namespace Audio
{
	public struct PlayClipInfo
	{
		public AudioClip clip;

		public AudioUtility.AudioManagerVoice voice;

		public float VolumeResult;

		public float PitchResult;
	}
}
