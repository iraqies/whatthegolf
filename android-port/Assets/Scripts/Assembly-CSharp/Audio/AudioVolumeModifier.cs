namespace Audio
{
	public class AudioVolumeModifier : BaseAudioModifier
	{
		public bool zeroVolumeBelowMinValue;

		public bool startOnFirstValueChange;

		public bool handlePlayback;

		public bool handleByValue;

		public bool handleByVolume;

		private AudioFromSurfaceModifier surfaceModifier;

		private float volume;

		private bool valueChanged;

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
