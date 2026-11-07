namespace Audio
{
	public class AudioValueSkidmark : BaseAudioValue
	{
		public Skidmarks skidmarks;

		public float smoothTime;

		private float lastIntensity;

		private float smoothVelocity;

		protected override bool Use2D => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override string ValueInputName()
		{
			return null;
		}

		private void OnCreateSkidmark(float v)
		{
		}

		private void LateUpdate()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
