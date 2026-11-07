namespace Audio
{
	public class AudioTremoloModifier : BaseAudioModifier
	{
		public float minFrequency;

		public float maxFrequency;

		private float depth;

		private float frequency;

		private AudioTremolo tremolo;

		private void Awake()
		{
		}

		protected override void OnValueChange(float _value)
		{
		}

		private void Update()
		{
		}
	}
}
