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
			ContactPoint contact = collision.contactCount > 0 ? collision.GetContact(0) : default;
			Vector3 pt = collision.contactCount > 0 ? contact.point : collision.transform.position;
			GameObject otherGo = collision.rigidbody != null ? collision.rigidbody.gameObject : (contact.otherCollider != null ? contact.otherCollider.gameObject : (collision.collider != null ? collision.collider.gameObject : collision.gameObject));
			GameObject thisGo = contact.thisCollider != null ? contact.thisCollider.gameObject : collision.gameObject;
			Vector3 relVel = collision.relativeVelocity;
			Vector3 projVel = collision.contactCount > 0 ? Vector3.Project(relVel, contact.normal) : relVel;
			return new HitInfo
			{
				point = pt,
				incomingVelocity = relVel,
				impactOnNormal = projVel,
				childHit = thisGo,
				otherHit = otherGo
			};
		}

		public static HitInfo GetHitInfo(Collision2D collision)
		{
			if (collision == null) return default;
			ContactPoint2D contact = collision.contactCount > 0 ? collision.GetContact(0) : default;
			Vector3 pt = collision.contactCount > 0 ? (Vector3)contact.point : collision.transform.position;
			Vector3 inVel = collision.collider != null && collision.collider.attachedRigidbody != null ? (Vector3)collision.collider.attachedRigidbody.velocity : Vector3.zero;
			GameObject otherGo = collision.rigidbody != null ? collision.rigidbody.gameObject : (contact.collider != null ? contact.collider.gameObject : (collision.collider != null ? collision.collider.gameObject : collision.gameObject));
			GameObject thisGo = contact.otherCollider != null ? contact.otherCollider.gameObject : collision.gameObject;
			Vector3 relVel = collision.relativeVelocity;
			Vector3 projVel = collision.contactCount > 0 ? Vector3.Project(relVel, contact.normal) : relVel;
			return new HitInfo
			{
				point = pt,
				incomingVelocity = inVel,
				impactOnNormal = projVel,
				childHit = thisGo,
				otherHit = otherGo
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
