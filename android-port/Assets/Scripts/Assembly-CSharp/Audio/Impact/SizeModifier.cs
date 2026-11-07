namespace Audio.Impact
{
	public struct SizeModifier
	{
		public float volumeMultiplier;

		public float pitchMultiplier;

		public static SizeModifier Light;

		public static SizeModifier Medium;

		public static SizeModifier Heavy;

		public SizeModifier(float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
			this.volumeMultiplier = 0f;
			this.pitchMultiplier = 0f;
		}

		public static SizeModifier NewModifier(ObjectWeight weight)
		{
			return default;
		}
	}
}
