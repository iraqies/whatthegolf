namespace Audio
{
	public class PitchModifierMultiple : ModifyAudiosource
	{
		public float basePitch;

		protected override void UpdateModifier()
		{
			if (source != null)
				source.pitch = output + basePitch;
		}
	}
}
