using System.Collections.Generic;
using Audio.Conditions;
using UnityEngine;

namespace Audio
{
	public static class AudioUtility
	{
		public enum AudioManagerVoice
		{
			ShortEffects = 0,
			ImpactEffects = 1,
			UiEffects = 2,
			AmbientEffects = 3,
			OverworldSpatial = 4
		}

		private static float twelfthRootOfTwo;

		public static float LinearToDecibel(float linear, float zeroVolume = -80f)
		{
			return 0f;
		}

		public static float NormalizeMinMax(float value, float min, float max)
		{
			return 0f;
		}

		public static float NormalizeMinMax(float value, MinMax minMax)
		{
			return 0f;
		}

		public static float NormalizeMinMax01(float value, float min, float max)
		{
			return 0f;
		}

		public static float NormalizeMinMax01(float value, MinMax minMax)
		{
			return 0f;
		}

		public static bool CheckConditions(this List<SerializedAudioCondition> conditions)
		{
			return false;
		}

		public static AudioSources GetVoice(AudioManagerVoice voice)
		{
			return null;
		}

		public static HitInfo GetHitInfo(Collision collision)
		{
			return default;
		}

		public static HitInfo GetHitInfo(Collision2D collision)
		{
			return default;
		}

		public static HitInfo GetHitInfo(RaycastHit raycastHit, Rigidbody hitter)
		{
			return default;
		}
	}
}
