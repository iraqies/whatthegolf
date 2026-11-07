using System;

namespace Audio.Impact
{
	[Serializable]
	public class VelocityClipGroup
	{
		public IgnoreCurve ignoreCurve;

		public float minVelocityNormalized;

		public float maxVelocityNormalized;

		public AudioEventAsset asset;

		public ClipSettingsCollection collection;

		public VelocityClipGroup()
		{
		}

		public VelocityClipGroup(float minVelocityNormalized, float maxVelocityNormalized)
		{
		}
	}
}
