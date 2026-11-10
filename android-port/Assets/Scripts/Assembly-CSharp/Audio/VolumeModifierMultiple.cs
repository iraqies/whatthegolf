namespace Audio
{
	public class VolumeModifierMultiple : ModifyAudiosource
	{
		public float baseVolume;

		public bool startAndStopByVolume;

		protected override void UpdateModifier()
		{
			if (source == null) return;
			source.volume = output + baseVolume;
			if (startAndStopByVolume)
			{
				if (source.volume > 0f && !source.isPlaying)
					source.Play();
				else if (source.volume < 0.01f && source.isPlaying)
					source.Stop();
			}
		}
	}
}
