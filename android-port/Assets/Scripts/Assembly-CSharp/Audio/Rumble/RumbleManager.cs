using System.Collections.Generic;
using UnityEngine;

namespace Audio.Rumble
{
	public class RumbleManager : MonoBehaviour
	{
		public RumbleEventAsset SubtleBump;

		public RumbleEventAsset BumpHard;

		public RumbleEventAsset OnShoot;

		public RumbleEventAsset Explosion;

		public RumbleEventAsset Confetti;

		public RumbleEventAsset HighFreqBump;

		public RumbleEventAsset LongBuildupRumble;

		public RumbleEventAsset GolfBallBounce => SubtleBump;

		public RumbleEventAsset GolfBallShot => OnShoot;

		[SerializeField]
		private PS5HapticsAudioPlayer PS5HapticsAudioSources;

		[SerializeField]
		private AudioClip m_GenericSineWaveRumbleClip;

		public void PlayVibrationValue(float amplitudeLow, float amplitudeHigh, int playerIndex, AudioClip ps5HapticsAudioClip = null)
		{
		}

		public void PlayVibrationValue(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, int playerIndex, AudioClip ps5HapticsAudioClip = null)
		{
		}

		public void StopVibration(int playerIndex)
		{
		}

		public void PlayVibrationFile(RumbleFileSetting rumbleSettings, int playerIndex, float volume)
		{
		}

		public List<int> GetPlayerIndexesInRangeOfSpatial(Vector3 position, float range)
		{
			return null;
		}

		private void PlayVibrationFileInternal(RumbleFileSetting rumbleSettings, int playerIndex, float volume)
		{
		}

		private void PlayVibrationValueInternal(float amplitudeLow, float amplitudeHigh, int playerIndex, AudioClip ps5AudioClip = null)
		{
		}

		private void PlayVibrationValueInternal(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, int playerIndex, AudioClip ps5AudioClip = null)
		{
		}

		private void StopVibrationInternal(int playerIndex)
		{
		}
	}
}
