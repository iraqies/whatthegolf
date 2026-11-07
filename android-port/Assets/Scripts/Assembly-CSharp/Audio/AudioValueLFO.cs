namespace Audio
{
	public class AudioValueLFO : BaseAudioValue
	{
		public enum Signal
		{
			Sine = 0,
			Square = 1
		}

		public bool useAffector;

		public AudioValueMapper Affector;

		public bool isOn;

		public float rate;

		public float depth;

		public Signal signal;

		private float m_rate;

		private float m_depth;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		public override string ValueInputName()
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
