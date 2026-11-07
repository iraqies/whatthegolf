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
		private float maxVelocity;

		[SerializeField]
		private bool includeBelowMin;

		[SerializeField]
		private bool includeAboveMax;

		[SerializeField]
		private bool lockVelocityThresholds;

		[SerializeField]
		private float cooldown;

		public SizeModifier CurrentIncomingObjectSize;

		public float m_lastPlayTime { get; private set; }

		public float[] SIZE_VOLUME_MULTIPLIER => null;

		public float[] SIZE_PITCH_MULTIPLIER => null;

		private void OnEnable()
		{
		}

		public void ResetOnSceneLoad()
		{
		}

		public bool OnCollision(HitInfo info, bool sizeAffects = false, ObjectWeight objectWeight = ObjectWeight.Medium, bool disableSpatial = false)
		{
			return false;
		}

		public float GetNormalizedVelocity(float velocity)
		{
			return 0f;
		}

		public bool OnCollision(HitInfo info, ImpactUser user)
		{
			return false;
		}

		public float GetPitchMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			return 0f;
		}

		public float GetVolumeMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			return 0f;
		}

		public List<VelocityClipGroup> GetVelocityClipGroups(float velocityNormalized)
		{
			return null;
		}

		private void OnTrigger(TriggerInfo obj)
		{
		}
	}
}
