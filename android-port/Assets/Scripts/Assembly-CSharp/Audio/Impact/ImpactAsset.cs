using System.Collections.Generic;
using UnityEngine;

namespace Audio.Impact
{
	public class ImpactAsset : ScriptableObject
	{
		public List<VelocityClipGroup> velocityClipGroups;

		public List<ImpactConditionBase> conditions;

		[SerializeField]
		private bool affectVolume;

		[SerializeField]
		private AnimationCurve volumeCurve;

		[SerializeField]
		private bool affectPitch;

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

		public SizeModifier CurrentIncomingObjectSize;

		public float m_lastPlayTime { get; private set; }

		private static readonly float[] s_SizeVol = { 0.75f, 1f, 1.25f };
		private static readonly float[] s_SizePit = { 1.15f, 1f, 0.85f };

		public float[] SIZE_VOLUME_MULTIPLIER => s_SizeVol;

		public float[] SIZE_PITCH_MULTIPLIER => s_SizePit;

		private void OnEnable()
		{
			m_lastPlayTime = -10f;
		}

		public void ResetOnSceneLoad()
		{
			m_lastPlayTime = -10f;
		}

		public bool OnCollision(HitInfo info, bool sizeAffects = false, ObjectWeight objectWeight = ObjectWeight.Medium, bool disableSpatial = false)
		{
			if (Time.time < m_lastPlayTime + cooldown)
				return false;
			float speed = info.impactOnNormal.sqrMagnitude > 0f ? info.impactOnNormal.magnitude : info.incomingVelocity.magnitude;
			if (speed < minVelocity && !includeBelowMin)
				return false;
			if (speed > maxVelocity && !includeAboveMax)
				return false;

			float normVel = GetNormalizedVelocity(speed);
			var groups = GetVelocityClipGroups(normVel);
			if (groups == null || groups.Count == 0)
				return false;

			bool played = false;
			for (int i = 0; i < groups.Count; i++)
			{
				var g = groups[i];
				if (g == null) continue;
				float volMod = GetVolumeMod(normVel, sizeAffects, objectWeight, g.ignoreCurve);
				float pitMod = GetPitchMod(normVel, sizeAffects, objectWeight, g.ignoreCurve);
				if (g.asset != null)
				{
					g.asset.Play(info.point, volMod, pitMod, disableSpatial);
					played = true;
				}
				else if (g.collection != null && g.collection.Count > 0)
				{
					g.collection.Play(null, info.point, volMod, pitMod, 0f, disableSpatial);
					played = true;
				}
			}

			if (played)
				m_lastPlayTime = Time.time;
			return played;
		}

		public float GetNormalizedVelocity(float velocity)
		{
			if (maxVelocity <= minVelocity)
				return 1f;
			return Mathf.Clamp01((velocity - minVelocity) / (maxVelocity - minVelocity));
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
			if (affectPitch && (ignoreCurve & IgnoreCurve.IgnorePitch) == 0 && pitchCurve != null && pitchCurve.length > 0)
				p = Mathf.Max(0.25f, pitchCurve.Evaluate(velocityNormalized));
			if (affectSize)
			{
				int idx = Mathf.Clamp((int)size, 0, s_SizePit.Length - 1);
				p *= s_SizePit[idx];
			}
			return p;
		}

		public float GetVolumeMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			float v = Mathf.Lerp(0.35f, 1f, velocityNormalized);
			if (affectVolume && (ignoreCurve & IgnoreCurve.IgnoreVolume) == 0 && volumeCurve != null && volumeCurve.length > 0)
				v = Mathf.Clamp(volumeCurve.Evaluate(velocityNormalized), 0.05f, 1.5f);
			if (affectSize)
			{
				int idx = Mathf.Clamp((int)size, 0, s_SizeVol.Length - 1);
				v *= s_SizeVol[idx];
			}
			return v;
		}

		public List<VelocityClipGroup> GetVelocityClipGroups(float velocityNormalized)
		{
			if (velocityClipGroups == null || velocityClipGroups.Count == 0)
				return null;
			var res = new List<VelocityClipGroup>();
			for (int i = 0; i < velocityClipGroups.Count; i++)
			{
				var g = velocityClipGroups[i];
				if (g == null) continue;
				if (velocityNormalized >= g.minVelocityNormalized && (velocityNormalized <= g.maxVelocityNormalized || g.maxVelocityNormalized <= 0f))
					res.Add(g);
			}
			if (res.Count == 0 && velocityClipGroups.Count > 0)
				res.Add(velocityClipGroups[velocityClipGroups.Count - 1]);
			return res;
		}

		private void OnTrigger(TriggerInfo obj)
		{
		}
	}
}
