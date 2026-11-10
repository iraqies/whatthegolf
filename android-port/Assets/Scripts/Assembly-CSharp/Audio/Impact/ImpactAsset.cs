using System.Collections.Generic;
using UnityEngine;

namespace Audio.Impact
{
	public class ImpactAsset : ScriptableObject
	{
		public List<VelocityClipGroup> velocityClipGroups;

		public List<ImpactConditionBase> conditions;

		[SerializeField]
		private bool affectVolume = true;

		[SerializeField]
		private AnimationCurve volumeCurve;

		[SerializeField]
		private bool affectPitch = true;

		[SerializeField]
		private AnimationCurve pitchCurve;

		[SerializeField]
		private float minVelocity;

		[SerializeField]
		private float maxVelocity = 25f;

		[SerializeField]
		private bool includeBelowMin;

		[SerializeField]
		private bool includeAboveMax = true;

		[SerializeField]
		private bool lockVelocityThresholds;

		[SerializeField]
		private float cooldown = 0.05f;

		public SizeModifier CurrentIncomingObjectSize = new SizeModifier(1f, 1f);

		public float m_lastPlayTime { get; private set; }

		private static readonly float[] s_SizeVol = { 0.5f, 1.5f, 0.7f };
		private static readonly float[] s_SizePit = { 1f, 1.1f, 0.9f };

		public float[] SIZE_VOLUME_MULTIPLIER => s_SizeVol;

		public float[] SIZE_PITCH_MULTIPLIER => s_SizePit;

		private void OnEnable()
		{
			m_lastPlayTime = -2f;
			CurrentIncomingObjectSize = new SizeModifier(1f, 1f);
		}

		public void ResetOnSceneLoad()
		{
			m_lastPlayTime = -2f;
		}

		public bool OnCollision(HitInfo info, bool sizeAffects = false, ObjectWeight objectWeight = ObjectWeight.Medium, bool disableSpatial = false)
		{
			float speed = info.impactOnNormal.sqrMagnitude > 0f ? info.impactOnNormal.magnitude : info.incomingVelocity.magnitude;
			float normVel = GetNormalizedVelocity(speed);

			bool withinMax = includeAboveMax || speed <= maxVelocity;
			bool withinMin = includeBelowMin ? withinMax : (speed >= minVelocity ? withinMax : false);
			if (!withinMin)
				return false;

			if (Time.time < m_lastPlayTime + cooldown)
				return false;

			CurrentIncomingObjectSize = new SizeModifier(1f, 1f);
			if (conditions != null)
			{
				for (int i = 0; i < conditions.Count; i++)
				{
					var cond = conditions[i];
					if (cond != null && cond.IsEnabled && !cond.CheckCondition(this, info, normVel))
						return false;
				}
			}

			m_lastPlayTime = Time.time;
			if (velocityClipGroups == null)
				return false;

			for (int i = 0; i < velocityClipGroups.Count; i++)
			{
				var g = velocityClipGroups[i];
				if (g == null) continue;
				bool approxMax = Mathf.Approximately(g.maxVelocityNormalized, normVel);
				if (normVel <= g.minVelocityNormalized && g.minVelocityNormalized > 0f)
					continue;
				if (normVel > g.maxVelocityNormalized && (!approxMax || !includeAboveMax))
					continue;

				float pitMod = GetPitchMod(normVel, sizeAffects, objectWeight, g.ignoreCurve);
				float volMod = GetVolumeMod(normVel, sizeAffects, objectWeight, g.ignoreCurve);

				if (g.collection != null && g.collection.Clips != null && g.collection.Clips.Count > 0)
				{
					var voice = AudioManager.Instance != null ? (AudioManager.Instance.impactEffects ?? AudioManager.Instance.shortEffects) : null;
					g.collection.Play(voice, info.point, volMod, pitMod, 0f, disableSpatial);
				}
				else if (g.asset != null)
				{
					g.asset.Play(info.point, volMod, pitMod, disableSpatial);
				}
			}

			return true;
		}

		public float GetNormalizedVelocity(float velocity)
		{
			return AudioUtility.NormalizeMinMax01(velocity, minVelocity, maxVelocity);
		}

		public bool OnCollision(HitInfo info, ImpactUser user)
		{
			if (user == null)
				return OnCollision(info);
			return OnCollision(info, user.SizeAffects, user.ObjectSize, user.DisableSpatial);
		}

		public float GetPitchMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			float p = 1f;
			if (affectPitch && !ignoreCurve.HasFlag(IgnoreCurve.IgnorePitch) && pitchCurve != null && pitchCurve.length > 0)
				p = pitchCurve.Evaluate(velocityNormalized);
			float sizePitch = CurrentIncomingObjectSize.pitchMultiplier > 0.01f ? CurrentIncomingObjectSize.pitchMultiplier : 1f;
			p *= sizePitch;
			if (affectSize)
			{
				int idx = Mathf.Clamp((int)size, 0, s_SizePit.Length - 1);
				p *= s_SizePit[idx];
			}
			return p;
		}

		public float GetVolumeMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			float v = 1f;
			if (affectVolume && !ignoreCurve.HasFlag(IgnoreCurve.IgnoreVolume) && volumeCurve != null && volumeCurve.length > 0)
				v = volumeCurve.Evaluate(velocityNormalized);
			float sizeVol = CurrentIncomingObjectSize.volumeMultiplier > 0.01f ? CurrentIncomingObjectSize.volumeMultiplier : 1f;
			v *= sizeVol;
			if (affectSize)
			{
				int idx = Mathf.Clamp((int)size, 0, s_SizeVol.Length - 1);
				v *= s_SizeVol[idx];
			}
			return v;
		}

		public List<VelocityClipGroup> GetVelocityClipGroups(float velocityNormalized)
		{
			var res = new List<VelocityClipGroup>();
			if (velocityClipGroups == null)
				return res;
			for (int i = 0; i < velocityClipGroups.Count; i++)
			{
				var g = velocityClipGroups[i];
				if (g != null && velocityNormalized >= g.minVelocityNormalized && velocityNormalized <= g.maxVelocityNormalized)
					res.Add(g);
			}
			return res;
		}

		private void OnTrigger(TriggerInfo obj)
		{
		}
	}
}
