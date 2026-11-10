namespace Audio.Impact
{
	public struct SizeModifier
	{
		public float volumeMultiplier;

		public float pitchMultiplier;

		public static SizeModifier Light = new SizeModifier(0.5f, 1.5f);

		public static SizeModifier Medium = new SizeModifier(0.7f, 1f);

		public static SizeModifier Heavy = new SizeModifier(1.1f, 0.9f);

		public SizeModifier(float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
			this.volumeMultiplier = volumeMultiplier;
			this.pitchMultiplier = pitchMultiplier;
		}

		public static SizeModifier NewModifier(ObjectWeight weight)
		{
			switch (weight)
			{
				case ObjectWeight.Light:
					return Light;
				case ObjectWeight.Medium:
					return Medium;
				case ObjectWeight.Heavy:
					return Heavy;
				default:
					return Medium;
			}
		}
	}
}
