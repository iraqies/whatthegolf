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

		private static float twelfthRootOfTwo = 1.0594631f;

		public static float LinearToDecibel(float linear, float zeroVolume = -80f)
		{
			if (linear <= 0.0001f) return zeroVolume;
			return Mathf.Clamp(20f * Mathf.Log10(linear), zeroVolume, 0f);
		}

		public static float NormalizeMinMax(float value, float min, float max)
		{
			if (Mathf.Abs(max - min) < 1e-5f) return 1f;
			return (value - min) / (max - min);
		}

		public static float NormalizeMinMax(float value, MinMax minMax)
		{
			if (minMax == null) return 1f;
			return NormalizeMinMax(value, minMax.min, minMax.max);
		}

		public static float NormalizeMinMax01(float value, float min, float max)
		{
			return Mathf.Clamp01(NormalizeMinMax(value, min, max));
		}

		public static float NormalizeMinMax01(float value, MinMax minMax)
		{
			if (minMax == null) return 1f;
			return NormalizeMinMax01(value, minMax.min, minMax.max);
		}

		public static bool CheckConditions(this List<SerializedAudioCondition> conditions)
		{
			return true;
		}

		public static AudioSources GetVoice(AudioManagerVoice voice)
		{
			var am = AudioManager.Instance;
			if (am == null) return null;
			switch (voice)
			{
				case AudioManagerVoice.ShortEffects: return am.shortEffects;
				case AudioManagerVoice.ImpactEffects: return am.impactEffects ?? am.shortEffects;
				case AudioManagerVoice.UiEffects: return am.uiEffects ?? am.shortEffects;
				case AudioManagerVoice.AmbientEffects: return am.ambientEffects ?? am.shortEffects;
				case AudioManagerVoice.OverworldSpatial: return am.overworldSpatial ?? am.shortEffects;
				default: return am.shortEffects;
			}
		}

		public static HitInfo GetHitInfo(Collision collision)
		{
			if (collision == null) return default;
			Vector3 pt = collision.contactCount > 0 ? collision.GetContact(0).point : collision.transform.position;
			return new HitInfo
			{
				point = pt,
				incomingVelocity = collision.relativeVelocity,
				impactOnNormal = collision.relativeVelocity,
				childHit = collision.gameObject,
				otherHit = collision.collider != null ? collision.collider.gameObject : collision.gameObject
			};
		}

		public static HitInfo GetHitInfo(Collision2D collision)
		{
			if (collision == null) return default;
			Vector3 pt = collision.contactCount > 0 ? (Vector3)collision.GetContact(0).point : collision.transform.position;
			return new HitInfo
			{
				point = pt,
				incomingVelocity = collision.relativeVelocity,
				impactOnNormal = collision.relativeVelocity,
				childHit = collision.gameObject,
				otherHit = collision.collider != null ? collision.collider.gameObject : collision.gameObject
			};
		}

		public static HitInfo GetHitInfo(RaycastHit raycastHit, Rigidbody hitter)
		{
			Vector3 vel = hitter != null ? hitter.velocity : Vector3.one;
			return new HitInfo
			{
				point = raycastHit.point,
				incomingVelocity = vel,
				impactOnNormal = vel,
				childHit = hitter != null ? hitter.gameObject : null,
				otherHit = raycastHit.collider != null ? raycastHit.collider.gameObject : null
			};
		}
	}
}
